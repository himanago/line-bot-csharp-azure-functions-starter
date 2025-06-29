using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using LineBotFunctions.Models;
using LineBotFunctions.Config;
using Azure.AI.Agents.Persistent;
using Azure.Identity;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using LineOpenApi.MessagingApi.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.DurableTask.Client;
using Microsoft.DurableTask.Entities;

namespace LineBotFunctions
{
    public class CallAIAgentActivity
    {
        private readonly ILogger<CallAIAgentActivity> _logger;

        public CallAIAgentActivity(ILogger<CallAIAgentActivity> logger)
        {
            _logger = logger;
        }

        [Function(nameof(CallAIAgentActivity))]
        public async Task<AIAgentResponse> RunActivity(
            [ActivityTrigger] AIAgentInput input,
            [DurableClient] DurableTaskClient durableClient)
        {
            _logger.LogInformation($"Calling AI agent for user {input.UserId}");

            try
            {
                // 環境変数から設定を取得
                var settings = AIAgentSettings.FromEnvironment();
                settings.Validate();

                _logger.LogInformation($"Using AI Project Endpoint: {settings.ProjectEndpoint}");
                _logger.LogInformation($"Using Agent ID: {settings.AgentId}");

                // PersistentAgentsClientを作成
                var persistentClient = new PersistentAgentsClient(settings.ProjectEndpoint, new DefaultAzureCredential());
                
                // 既存のエージェントを取得（AI Foundryで既にデプロイ済み）
                var agentResponse = await persistentClient.Administration.GetAgentAsync(settings.AgentId);
                var agent = agentResponse.Value;
                _logger.LogInformation($"Using existing agent, agent ID: {agent.Id}");

                // ユーザー専用のスレッドIDを取得または作成
                string threadId = await GetOrCreateUserThreadAsync(persistentClient, durableClient, input.UserId);
                _logger.LogInformation($"Using thread {threadId} for user {input.UserId}");

                // メッセージを送信
                var messageResponse = await persistentClient.Messages.CreateMessageAsync(
                    threadId,
                    MessageRole.User,
                    input.UserMessage
                );
                var message = messageResponse.Value;

                _logger.LogInformation($"Sent message to AI agent thread {threadId}, message ID: {message.Id}");

                // エージェントを実行
                var runResponse = await persistentClient.Runs.CreateRunAsync(
                    threadId,
                    assistantId: agent.Id
                );

                _logger.LogInformation($"Started AI agent run, run ID: {runResponse.Value.Id}");

                // 実行完了まで待機（ポーリング）
                var completedRun = await WaitForRunCompletionAsync(persistentClient, threadId, runResponse.Value.Id);
                _logger.LogInformation($"AI agent run completed, run ID: {completedRun.Id}, status: {completedRun.Status}");

                if (completedRun.Status == RunStatus.Completed)
                {
                    // メッセージを取得
                    var messagesAsyncEnumerable = persistentClient.Messages.GetMessagesAsync(
                        threadId: threadId, 
                        order: ListSortOrder.Descending);

                    _logger.LogInformation($"Retrieved messages from thread {threadId}");

                    // エージェントの最新応答を取得してJSON解析
                    await foreach (var msg in messagesAsyncEnumerable)
                    {
                        if (msg.Role == MessageRole.Agent)
                        {
                            // メッセージの内容を抽出
                            var contentText = string.Empty;
                            
                            // PersistentThreadMessageのContent属性を確認してテキストを抽出
                            foreach (var contentItem in msg.ContentItems)
                            {
                                // テキストコンテンツかどうかチェック
                                if (contentItem is MessageTextContent textContent)
                                {
                                    contentText += textContent.Text;
                                }
                            }

                            if (!string.IsNullOrEmpty(contentText))
                            {
                                _logger.LogInformation($"Agent response content: {contentText}");

                                try
                                {
                                    // JSONとして解析を試行（Newtonsoft.Jsonを使用）
                                    var jsonObject = JToken.Parse(contentText.Trim());

                                    // まず配列かどうかをチェック
                                    if (jsonObject.Type == JTokenType.Array)
                                    {
                                        // 直接メッセージ配列の場合
                                        _logger.LogInformation("Processing direct JSON array response");
                                        
                                        // SDKのデシリアライゼーション問題を回避し、JSONを文字列として保持
                                        var messagesJsonArray = (JArray)jsonObject;
                                        _logger.LogInformation($"Storing {messagesJsonArray.Count} messages as JSON string");
                                        
                                        // メッセージの詳細をログ出力
                                        for (int i = 0; i < messagesJsonArray.Count; i++)
                                        {
                                            var msgJson = messagesJsonArray[i];
                                            var msgType = msgJson["type"]?.ToString() ?? "unknown";
                                            var msgText = msgJson["text"]?.ToString() ?? "";
                                            _logger.LogInformation($"  Message {i}: Type={msgType}, Text={msgText}");
                                        }
                                        
                                        return new AIAgentResponse
                                        {
                                            Status = "success",
                                            MessagesJson = messagesJsonArray.ToString()
                                        };
                                    }
                                    else if (jsonObject.Type == JTokenType.Object && jsonObject["messages"] != null)
                                    {
                                        _logger.LogInformation("Processing JSON object with 'messages' property");
                                        var messagesJsonArray = (JArray)jsonObject["messages"];
                                        _logger.LogInformation($"Storing {messagesJsonArray.Count} messages as JSON array from 'messages' property");
                                        
                                        // メッセージの詳細をログ出力
                                        for (int i = 0; i < messagesJsonArray.Count; i++)
                                        {
                                            var msgJson = messagesJsonArray[i];
                                            var msgType = msgJson["type"]?.ToString() ?? "unknown";
                                            var msgText = msgJson["text"]?.ToString() ?? "";
                                            _logger.LogInformation($"  Message {i}: Type={msgType}, Text={msgText}");
                                        }
                                        
                                        return new AIAgentResponse
                                        {
                                            Status = "success",
                                            MessagesJson = messagesJsonArray.ToString()
                                        };
                                    }
                                    else
                                    {
                                        // JSONだが期待される形式ではない場合、テキストとして扱う
                                        _logger.LogWarning($"Unexpected JSON format from agent: {contentText}");
                                        var textMessageJson = new JArray
                                        {
                                            new JObject
                                            {
                                                ["type"] = "text",
                                                ["text"] = contentText
                                            }
                                        };
                                        
                                        return new AIAgentResponse
                                        {
                                            Status = "success",
                                            MessagesJson = textMessageJson.ToString()
                                        };
                                    }
                                }
                                catch (JsonReaderException ex)
                                {
                                    // JSONでない場合は、通常のテキストメッセージとして扱う
                                    _logger.LogInformation($"Agent response is not JSON, treating as text message. JSON error: {ex.Message}");
                                    var textMessageJson = new JArray
                                    {
                                        new JObject
                                        {
                                            ["type"] = "text",
                                            ["text"] = contentText
                                        }
                                    };
                                    
                                    return new AIAgentResponse
                                    {
                                        Status = "success",
                                        MessagesJson = textMessageJson.ToString()
                                    };
                                }
                                catch (JsonException ex)
                                {
                                    // JSONデシリアライゼーションエラーの場合
                                    _logger.LogInformation($"Agent response JSON deserialization failed, treating as text message. JSON error: {ex.Message}");
                                    var textMessageJson = new JArray
                                    {
                                        new JObject
                                        {
                                            ["type"] = "text",
                                            ["text"] = contentText
                                        }
                                    };
                                    
                                    return new AIAgentResponse
                                    {
                                        Status = "success",
                                        MessagesJson = textMessageJson.ToString()
                                    };
                                }
                            }
                        }
                    }

                    // 応答が見つからない場合
                    _logger.LogWarning("No assistant response found in thread");
                    var fallbackMessageJson = new JArray
                    {
                        new JObject
                        {
                            ["type"] = "text",
                            ["text"] = "申し訳ございません。応答の生成に失敗しました。"
                        }
                    };
                    
                    return new AIAgentResponse
                    {
                        Status = "success",
                        MessagesJson = fallbackMessageJson.ToString()
                    };
                }
                else
                {
                    // 実行が失敗した場合
                    _logger.LogError($"AI agent run failed with status: {completedRun.Status}");
                    var errorMessageJson = new JArray
                    {
                        new JObject
                        {
                            ["type"] = "text",
                            ["text"] = "申し訳ございません。AIの処理に失敗しました。"
                        }
                    };
                    
                    return new AIAgentResponse
                    {
                        Status = "error",
                        MessagesJson = errorMessageJson.ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AI agent call failed");
                _logger.LogError($"Error details: {ex.Message}");
                _logger.LogError($"Stack trace: {ex.StackTrace}");
                
                var exceptionMessageJson = new JArray
                {
                    new JObject
                    {
                        ["type"] = "text",
                        ["text"] = "申し訳ございません。AI処理でエラーが発生しました。"
                    }
                };
                
                return new AIAgentResponse
                {
                    Status = "error",
                    MessagesJson = exceptionMessageJson.ToString()
                };
            }
        }

        private async Task<ThreadRun> WaitForRunCompletionAsync(PersistentAgentsClient persistentClient, string threadId, string runId)
        {
            var maxWaitTime = TimeSpan.FromMinutes(5); // 最大5分待機
            var pollingInterval = TimeSpan.FromSeconds(2); // 2秒間隔でポーリング
            var startTime = DateTime.UtcNow;

            while (DateTime.UtcNow - startTime < maxWaitTime)
            {
                var runResponse = await persistentClient.Runs.GetRunAsync(threadId, runId);
                var run = runResponse.Value;

                _logger.LogInformation($"Run status: {run.Status}");

                // 完了状態をチェック
                if (run.Status == RunStatus.Completed || 
                    run.Status == RunStatus.Failed || 
                    run.Status == RunStatus.Cancelled ||
                    run.Status == RunStatus.Expired)
                {
                    return run;
                }

                await Task.Delay(pollingInterval);
            }

            throw new TimeoutException($"AI agent run {runId} did not complete within {maxWaitTime.TotalMinutes} minutes");
        }

        private async Task<string> GetOrCreateUserThreadAsync(PersistentAgentsClient persistentClient, DurableTaskClient durableClient, string userId)
        {
            var entityId = new EntityInstanceId("LineUserReplyTokenEntity", userId);
            
            try
            {
                // 既存のスレッドIDを取得
                var entity = await durableClient.Entities.GetEntityAsync(entityId);
                var tokenState = entity?.State?.ReadAs<ReplyTokenState>();
                
                if (tokenState != null && !string.IsNullOrEmpty(tokenState.ThreadId))
                {
                    _logger.LogInformation($"Found existing thread {tokenState.ThreadId} for user {userId}");
                    
                    // 最終使用日時を更新
                    await durableClient.Entities.SignalEntityAsync(entityId, "UpdateThreadLastUsed");
                    
                    return tokenState.ThreadId;
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, $"Could not retrieve existing thread for user {userId}, creating new one");
            }

            // 新しいスレッドを作成
            var threadResponse = await persistentClient.Threads.CreateThreadAsync();
            var newThreadId = threadResponse.Value.Id;
            
            _logger.LogInformation($"Created new thread {newThreadId} for user {userId}");
            
            // エンティティにスレッドIDを保存
            await durableClient.Entities.SignalEntityAsync(entityId, "SetThread", newThreadId);
            
            return newThreadId;
        }
    }
}

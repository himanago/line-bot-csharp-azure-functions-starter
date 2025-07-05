using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using LineBotFunctions.Models;
using LineBotFunctions.Config;
using LineBotFunctions.Services;
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
        private readonly LineImageService _lineImageService;

        public CallAIAgentActivity(ILogger<CallAIAgentActivity> logger, LineImageService lineImageService)
        {
            _logger = logger;
            _lineImageService = lineImageService;
        }

        [Function(nameof(CallAIAgentActivity))]
        public async Task<AIAgentResponse> RunActivity(
            [ActivityTrigger] AIAgentInput input,
            [DurableClient] DurableTaskClient durableClient)
        {
            _logger.LogInformation($"Calling AI agent for user {input.UserId}");
            
            // マルチモーダル処理の場合は追加ログ
            if (input.IsMultimodal && !string.IsNullOrEmpty(input.ImageMessageId))
            {
                _logger.LogInformation($"Processing multimodal request with image ID: {input.ImageMessageId}");
            }

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
                if (input.IsMultimodal && !string.IsNullOrEmpty(input.ImageMessageId))
                {
                    // マルチモーダルメッセージを送信
                    await SendMultimodalMessageAsync(persistentClient, threadId, input.UserMessage, input.ImageMessageId);
                }
                else
                {
                    // 通常のテキストメッセージを送信
                    var messageResponse = await persistentClient.Messages.CreateMessageAsync(
                        threadId,
                        MessageRole.User,
                        input.UserMessage
                    );
                    var message = messageResponse.Value;
                    _logger.LogInformation($"Sent text message to AI agent thread {threadId}, message ID: {message.Id}");
                }

                // エージェントを実行（リトライ機能付き）
                var runResponse = await persistentClient.Runs.CreateRunAsync(
                    threadId,
                    assistantId: agent.Id
                );

                _logger.LogInformation($"Started AI agent run, run ID: {runResponse.Value.Id}");

                // 実行完了まで待機（ポーリング）- リトライ機能付き
                var completedRun = await WaitForRunCompletionWithRetryAsync(persistentClient, threadId, runResponse.Value.Id, agent.Id);
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

                                // Markdownコードブロックを除去してからJSON解析
                                var cleanedContent = CleanJsonResponse(contentText);

                                try
                                {
                                    // JSONとして解析を試行（Newtonsoft.Jsonを使用）
                                    var jsonObject = JToken.Parse(cleanedContent);

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
                                        _logger.LogWarning($"Unexpected JSON format from agent: {cleanedContent}");
                                        var textMessageJson = new JArray
                                        {
                                            new JObject
                                            {
                                                ["type"] = "text",
                                                ["text"] = cleanedContent
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
                                            ["text"] = cleanedContent
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
                                            ["text"] = cleanedContent
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

        private async Task<ThreadRun> WaitForRunCompletionWithRetryAsync(PersistentAgentsClient persistentClient, string threadId, string runId, string assistantId)
        {
            const int maxRetries = 2; // 最大2回リトライ（合計3回実行）
            ThreadRun? completedRun = null;
            string currentRunId = runId;
            
            for (int attempt = 0; attempt <= maxRetries; attempt++)
            {
                try
                {
                    completedRun = await WaitForRunCompletionAsync(persistentClient, threadId, currentRunId);
                    
                    if (completedRun.Status == RunStatus.Completed)
                    {
                        if (attempt > 0)
                        {
                            _logger.LogInformation($"AI agent run succeeded on attempt {attempt + 1}");
                        }
                        return completedRun;
                    }
                    else if (completedRun.Status == RunStatus.Failed && attempt < maxRetries)
                    {
                        _logger.LogWarning($"AI agent run failed on attempt {attempt + 1}, retrying...");
                        
                        // 新しいRunを作成してリトライ
                        var retryRunResponse = await persistentClient.Runs.CreateRunAsync(threadId, assistantId: assistantId);
                        currentRunId = retryRunResponse.Value.Id;
                        _logger.LogInformation($"Created retry run, run ID: {currentRunId}");
                        
                        // 少し待ってからリトライ
                        await Task.Delay(TimeSpan.FromSeconds(1));
                    }
                    else
                    {
                        // 最終試行でも失敗、またはキャンセル/期限切れの場合
                        break;
                    }
                }
                catch (Exception ex)
                {
                    if (attempt < maxRetries)
                    {
                        _logger.LogWarning(ex, $"Exception during AI agent run attempt {attempt + 1}, retrying...");
                        
                        // 新しいRunを作成してリトライ
                        try
                        {
                            var retryRunResponse = await persistentClient.Runs.CreateRunAsync(threadId, assistantId: assistantId);
                            currentRunId = retryRunResponse.Value.Id;
                            _logger.LogInformation($"Created retry run after exception, run ID: {currentRunId}");
                            await Task.Delay(TimeSpan.FromSeconds(1));
                        }
                        catch (Exception retryEx)
                        {
                            _logger.LogError(retryEx, $"Failed to create retry run on attempt {attempt + 1}");
                            throw;
                        }
                    }
                    else
                    {
                        _logger.LogError(ex, $"AI agent run failed on final attempt {attempt + 1}");
                        throw;
                    }
                }
            }
            
            return completedRun ?? throw new InvalidOperationException("Run completion failed after all retry attempts");
        }

        private async Task<string> GetOrCreateUserThreadAsync(PersistentAgentsClient persistentClient, DurableTaskClient durableClient, string userId)
        {
            var entityId = new EntityInstanceId("LineTalkEntity", userId);
            
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

        private async Task SendMultimodalMessageAsync(PersistentAgentsClient persistentClient, string threadId, string userMessage, string imageMessageId)
        {
            try
            {
                // LINE APIから画像データを取得
                _logger.LogInformation($"Fetching image data for message ID: {imageMessageId}");
                var imageBase64 = await _lineImageService.GetImageAsBase64Async(imageMessageId);
                
                // 画像付きメッセージを作成 (現在のSDKバージョンでサポートされている方法を使用)
                // 注意: Azure AI Agents SDKのマルチモーダル対応は限定的な場合があります
                var combinedMessage = $"{userMessage}\n\n[Image data: {imageBase64.Substring(0, Math.Min(100, imageBase64.Length))}...]";
                
                var messageResponse = await persistentClient.Messages.CreateMessageAsync(
                    threadId,
                    MessageRole.User,
                    combinedMessage
                );
                
                var message = messageResponse.Value;
                _logger.LogInformation($"Sent multimodal message to AI agent thread {threadId}, message ID: {message.Id}");
                _logger.LogInformation($"Image data size: {imageBase64.Length} characters (base64)");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Failed to send multimodal message, falling back to text only");
                
                // フォールバック: テキストのみで送信
                var fallbackMessage = $"{userMessage}\n\n[画像が添付されていましたが、処理に失敗しました]";
                var messageResponse = await persistentClient.Messages.CreateMessageAsync(
                    threadId,
                    MessageRole.User,
                    fallbackMessage
                );
                
                var message = messageResponse.Value;
                _logger.LogInformation($"Sent fallback text message to AI agent thread {threadId}, message ID: {message.Id}");
            }
        }

        private string CleanJsonResponse(string jsonResponse)
        {
            if (string.IsNullOrEmpty(jsonResponse))
                return jsonResponse;

            // ```json と ``` を除去
            var cleaned = jsonResponse
                .Replace("```json", "")
                .Replace("```", "")
                .Trim();

            _logger.LogInformation($"Cleaned AI agent response: Original length={jsonResponse.Length}, Cleaned length={cleaned.Length}");
            
            return cleaned;
        }
    }
}

using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using LineBotFunctions.Models;
using LineBotFunctions.Config;
using Azure.AI.Agents.Persistent;
using Azure.Identity;
using System;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

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
        public async Task<AIAgentResponse> RunActivity([ActivityTrigger] AIAgentInput input)
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

                // 新しい会話スレッドを作成
                var threadResponse = await persistentClient.Threads.CreateThreadAsync();
                var thread = threadResponse.Value;
                _logger.LogInformation($"Created thread, thread ID: {thread.Id}");

                // メッセージを送信
                var messageResponse = await persistentClient.Messages.CreateMessageAsync(
                    thread.Id,
                    MessageRole.User,
                    input.UserMessage
                );
                var message = messageResponse.Value;

                _logger.LogInformation($"Sent message to AI agent thread {thread.Id}, message ID: {message.Id}");

                // エージェントを実行
                var runResponse = await persistentClient.Runs.CreateRunAsync(
                    thread.Id,
                    assistantId: agent.Id
                );

                _logger.LogInformation($"Started AI agent run, run ID: {runResponse.Value.Id}");

                // 実行完了まで待機（ポーリング）
                var completedRun = await WaitForRunCompletionAsync(persistentClient, thread.Id, runResponse.Value.Id);
                _logger.LogInformation($"AI agent run completed, run ID: {completedRun.Id}, status: {completedRun.Status}");

                if (completedRun.Status == RunStatus.Completed)
                {
                    // メッセージを取得
                    var messagesAsyncEnumerable = persistentClient.Messages.GetMessagesAsync(
                        threadId: thread.Id, 
                        order: ListSortOrder.Ascending);

                    _logger.LogInformation($"Retrieved messages from thread {thread.Id}");

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
                                    // JSONとして解析を試行
                                    using var document = JsonDocument.Parse(contentText.Trim());
                                    var rootElement = document.RootElement;

                                    // まず配列かどうかをチェック
                                    if (rootElement.ValueKind == JsonValueKind.Array)
                                    {
                                        // 直接メッセージ配列の場合
                                        var lineMessages = JsonSerializer.Deserialize<List<LineMessage>>(contentText);
                                        return new AIAgentResponse
                                        {
                                            Status = "success",
                                            Messages = lineMessages ?? new List<LineMessage>()
                                        };
                                    }
                                    else if (rootElement.TryGetProperty("messages", out var messagesProperty))
                                    {
                                        var lineMessages = JsonSerializer.Deserialize<List<LineMessage>>(messagesProperty.GetRawText());
                                        return new AIAgentResponse
                                        {
                                            Status = "success",
                                            Messages = lineMessages ?? new List<LineMessage>()
                                        };
                                    }
                                    else
                                    {
                                        // JSONだが期待される形式ではない場合、テキストとして扱う
                                        _logger.LogWarning($"Unexpected JSON format from agent: {contentText}");
                                        return new AIAgentResponse
                                        {
                                            Status = "success",
                                            Messages = new List<LineMessage>
                                            {
                                                new LineMessage { Type = "text", Text = contentText }
                                            }
                                        };
                                    }
                                }
                                catch (JsonException)
                                {
                                    // JSONでない場合は、通常のテキストメッセージとして扱う
                                    _logger.LogInformation("Agent response is not JSON, treating as text message");
                                    return new AIAgentResponse
                                    {
                                        Status = "success",
                                        Messages = new List<LineMessage>
                                        {
                                            new LineMessage { Type = "text", Text = contentText }
                                        }
                                    };
                                }
                            }
                        }
                    }

                    // 応答が見つからない場合
                    _logger.LogWarning("No assistant response found in thread");
                    return new AIAgentResponse
                    {
                        Status = "success",
                        Messages = new List<LineMessage>
                        {
                            new LineMessage { Type = "text", Text = "申し訳ございません。応答の生成に失敗しました。" }
                        }
                    };
                }
                else
                {
                    // 実行が失敗した場合
                    _logger.LogError($"AI agent run failed with status: {completedRun.Status}");
                    return new AIAgentResponse
                    {
                        Status = "error",
                        Messages = new List<LineMessage>
                        {
                            new LineMessage { Type = "text", Text = "申し訳ございません。AIの処理に失敗しました。" }
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AI agent call failed");
                _logger.LogError($"Error details: {ex.Message}");
                _logger.LogError($"Stack trace: {ex.StackTrace}");
                
                return new AIAgentResponse
                {
                    Status = "error",
                    Messages = new List<LineMessage>
                    {
                        new LineMessage { Type = "text", Text = "申し訳ございません。AI処理でエラーが発生しました。" }
                    }
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
    }
}

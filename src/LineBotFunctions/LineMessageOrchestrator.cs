using Microsoft.Azure.Functions.Worker;
using Microsoft.DurableTask;
using Microsoft.Extensions.Logging;
using LineBotFunctions.Models;
using LineOpenApi.MessagingApi.Model;
using System.Threading.Tasks;

namespace LineBotFunctions
{
    public class LineMessageOrchestrator
    {
        private readonly ILogger<LineMessageOrchestrator> _logger;

        public LineMessageOrchestrator(ILogger<LineMessageOrchestrator> logger)
        {
            _logger = logger;
        }

        [Function(nameof(LineMessageOrchestrator))]
        public async Task<OrchestratorResult> RunOrchestrator(
            [OrchestrationTrigger] TaskOrchestrationContext context)
        {
            var input = context.GetInput<OrchestratorInput>();
            _logger.LogInformation($"Orchestrator started for user {input?.UserId}");

            try
            {
                if (input == null)
                {
                    throw new System.ArgumentNullException(nameof(input));
                }

                // Step 1: AIエージェントでメッセージ処理
                var agentInput = new AIAgentInput
                {
                    UserMessage = input.UserMessage,
                    UserId = input.UserId,
                    ImageMessageId = input.ImageMessageId,
                    IsMultimodal = input.IsMultimodal
                };

                // マルチモーダル処理の場合は、エンティティから画像情報を取得して設定
                // (将来的にマルチモーダル対応時に使用)
                
                var agentResponse = await context.CallActivityAsync<AIAgentResponse>("CallAIAgentActivity", agentInput);
                _logger.LogInformation($"AI Agent response received: Status={agentResponse?.Status}");

                // Step 2: エンティティから最新のリプライトークンを取得してLINE返信処理
                var replyInput = new LineReplyInput
                {
                    UserId = input.UserId,
                    MessagesJson = agentResponse?.MessagesJson ?? "[]"
                };

                var replyResult = await context.CallActivityAsync<LineReplyResult>("SendLineReplyActivity", replyInput);
                _logger.LogInformation($"LINE reply completed: {replyResult?.Status}");

                return new OrchestratorResult
                {
                    Status = "success",
                    UserId = input.UserId,
                    AgentResponse = agentResponse,
                    ReplyResult = replyResult
                };
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, $"Orchestrator error for user {input?.UserId}");

                // エラー時もエンティティから最新のリプライトークンを取得して返信
                var errorReplyInput = new LineReplyInput
                {
                    UserId = input?.UserId ?? string.Empty,
                    MessagesJson = """[{"type": "text", "text": "申し訳ございません。処理中にエラーが発生しました。もう一度お試しください。"}]"""
                };

                try
                {
                    await context.CallActivityAsync<LineReplyResult>("SendLineReplyActivity", errorReplyInput);
                }
                catch (System.Exception replyEx)
                {
                    _logger.LogError(replyEx, "Error sending error reply");
                }

                return new OrchestratorResult
                {
                    Status = "error",
                    Error = ex.Message,
                    UserId = input?.UserId ?? string.Empty
                };
            }
        }
    }
}

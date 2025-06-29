using System.Collections.Generic;
using LineOpenApi.MessagingApi.Model;

namespace LineBotFunctions.Models
{
    public class OrchestratorInput
    {
        public string UserMessage { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        // マルチモーダル対応
        public string? ImageMessageId { get; set; }
        public bool IsMultimodal { get; set; } = false;
    }

    public class AIAgentInput
    {
        public string UserMessage { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        // マルチモーダル対応
        public string? ImageMessageId { get; set; }
        public bool IsMultimodal { get; set; } = false;
    }

    public class AIAgentResponse
    {
        public string Status { get; set; } = string.Empty;
        // JSONレスポンスを文字列として保持（シリアライゼーション問題を回避）
        public string MessagesJson { get; set; } = string.Empty;
    }

    public class LineReplyInput
    {
        public string UserId { get; set; } = string.Empty;
        // JSONレスポンスを文字列として受け取り
        public string MessagesJson { get; set; } = string.Empty;
    }

    public class LineReplyResult
    {
        public string Status { get; set; } = string.Empty;
        public int MessageCount { get; set; }
        public string UserId { get; set; } = string.Empty;
    }

    public class OrchestratorResult
    {
        public string Status { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public AIAgentResponse? AgentResponse { get; set; }
        public LineReplyResult? ReplyResult { get; set; }
        public string? Error { get; set; }
    }

    // 画像待ち状態管理用
    public class ImageWaitingState
    {
        public string ImageMessageId { get; set; } = string.Empty;
        public DateTime ImageReceivedAt { get; set; }
        public bool IsWaitingForText { get; set; }
    }
}

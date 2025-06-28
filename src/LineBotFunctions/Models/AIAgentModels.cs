using System.Collections.Generic;

namespace LineBotFunctions.Models
{
    public class OrchestratorInput
    {
        public string UserMessage { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
    }

    public class AIAgentInput
    {
        public string UserMessage { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
    }

    public class AIAgentResponse
    {
        public string Status { get; set; } = string.Empty;
        public List<LineMessage> Messages { get; set; } = new List<LineMessage>();
    }

    public class LineMessage
    {
        public string Type { get; set; } = "text";
        public string Text { get; set; } = string.Empty;
    }

    public class LineReplyInput
    {
        public string UserId { get; set; } = string.Empty;
        public List<LineMessage> Messages { get; set; } = new List<LineMessage>();
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
}

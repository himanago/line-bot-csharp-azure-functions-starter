using System;

namespace LineBotFunctions.Config
{
    public class AIAgentSettings
    {
        public string ProjectEndpoint { get; set; } = string.Empty;
        public string AgentId { get; set; } = string.Empty;

        public static AIAgentSettings FromEnvironment()
        {
            return new AIAgentSettings
            {
                ProjectEndpoint = Environment.GetEnvironmentVariable("AZURE_AI_PROJECT_ENDPOINT") ?? 
                    throw new InvalidOperationException("AZURE_AI_PROJECT_ENDPOINT environment variable is required"),
                AgentId = Environment.GetEnvironmentVariable("AZURE_AI_AGENT_ID") ?? 
                    throw new InvalidOperationException("AZURE_AI_AGENT_ID environment variable is required")
            };
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(ProjectEndpoint))
                throw new InvalidOperationException("AZURE_AI_PROJECT_ENDPOINT is required");
            if (string.IsNullOrWhiteSpace(AgentId))
                throw new InvalidOperationException("AZURE_AI_AGENT_ID is required");
            
            // URLの形式チェック
            if (!Uri.TryCreate(ProjectEndpoint, UriKind.Absolute, out _))
                throw new InvalidOperationException("AZURE_AI_PROJECT_ENDPOINT must be a valid URL");
        }
    }
}

using Microsoft.Azure.Functions.Worker;
using Microsoft.DurableTask.Entities;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace LineBotFunctions
{
    public class ReplyTokenState
    {
        public string? Token { get; set; }
    }

    public class LineUserReplyTokenEntity : TaskEntity<ReplyTokenState>
    {
        private readonly ILogger logger;

        public LineUserReplyTokenEntity(ILogger<LineUserReplyTokenEntity> logger)
        {
            this.logger = logger;
        }

        public void Set(string replyToken)
        {
            if (this.State == null)
            {
                this.State = new ReplyTokenState();
            }
            this.State.Token = replyToken;
            logger.LogInformation($"Reply token set for entity: {replyToken}");
        }

        public Task<string?> Get()
        {
            if (this.State == null)
            {
                return Task.FromResult<string?>(null);
            }
            return Task.FromResult(this.State.Token);
        }

        public void Clear()
        {
            if (this.State == null)
            {
                this.State = new ReplyTokenState();
            }
            this.State.Token = null;
        }

        [Function(nameof(LineUserReplyTokenEntity))]
        public static Task Run([EntityTrigger] TaskEntityDispatcher dispatcher)
            => dispatcher.DispatchAsync<LineUserReplyTokenEntity>();
    }
}

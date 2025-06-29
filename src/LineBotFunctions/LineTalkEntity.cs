using Microsoft.Azure.Functions.Worker;
using Microsoft.DurableTask.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using LineBotFunctions.Models;

namespace LineBotFunctions
{
    public class ReplyTokenState
    {
        public string? Token { get; set; }
        public string ThreadId { get; set; } = string.Empty;
        public DateTime ThreadCreatedAt { get; set; }
        public DateTime ThreadLastUsedAt { get; set; }
        // 画像待ち状態管理
        public ImageWaitingState? ImageWaiting { get; set; }
    }

    public class LineTalkEntity : TaskEntity<ReplyTokenState>
    {
        private readonly ILogger logger;

        public LineTalkEntity(ILogger<LineTalkEntity> logger)
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

        // スレッド管理メソッド
        public void SetThread(string threadId)
        {
            if (this.State == null)
            {
                this.State = new ReplyTokenState();
            }
            
            this.State.ThreadId = threadId;
            this.State.ThreadCreatedAt = DateTime.UtcNow;
            this.State.ThreadLastUsedAt = DateTime.UtcNow;
            logger.LogInformation($"Thread ID set for entity: {threadId}");
        }

        public void UpdateThreadLastUsed()
        {
            if (this.State != null && !string.IsNullOrEmpty(this.State.ThreadId))
            {
                this.State.ThreadLastUsedAt = DateTime.UtcNow;
                logger.LogInformation($"Thread last used updated for thread: {this.State.ThreadId}");
            }
        }

        public Task<string?> GetThreadId()
        {
            return Task.FromResult(this.State?.ThreadId);
        }

        public void ClearThread()
        {
            if (this.State != null)
            {
                logger.LogInformation($"Clearing thread ID: {this.State.ThreadId}");
                this.State.ThreadId = string.Empty;
                this.State.ThreadCreatedAt = default;
                this.State.ThreadLastUsedAt = default;
            }
        }

        // 画像待ち状態管理メソッド
        public void SetImageWaiting(string imageMessageId)
        {
            if (this.State == null)
            {
                this.State = new ReplyTokenState();
            }
            
            this.State.ImageWaiting = new ImageWaitingState
            {
                ImageMessageId = imageMessageId,
                ImageReceivedAt = DateTime.UtcNow,
                IsWaitingForText = true
            };
            logger.LogInformation($"Set image waiting state for message ID: {imageMessageId}");
        }

        public Task<ImageWaitingState?> GetImageWaiting()
        {
            return Task.FromResult(this.State?.ImageWaiting);
        }

        public void ClearImageWaiting()
        {
            if (this.State != null)
            {
                logger.LogInformation($"Clearing image waiting state");
                this.State.ImageWaiting = null;
            }
        }

        [Function(nameof(LineTalkEntity))]
        public static Task Run([EntityTrigger] TaskEntityDispatcher dispatcher)
            => dispatcher.DispatchAsync<LineTalkEntity>();
    }
}

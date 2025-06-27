using System.Collections.Generic;
using System.Threading.Tasks;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Model;
using LineOpenApi.Webhook.Model;
using LineOpenApi.Webhook;
using Microsoft.Extensions.Logging;

namespace LineBotFunctions
{
    /// <summary>
    /// Echo webhook handler that demonstrates how to use the auto-generated WebhookHandlerBase
    /// </summary>
    public class WebhookHandler : WebhookHandlerBase
    {
        private readonly IMessagingApiApiAsync _api;
        private readonly ILogger<WebhookHandler> _logger;

        public WebhookHandler(IMessagingApiApiAsync api, ILogger<WebhookHandler> logger)
        {
            _api = api;
            _logger = logger;
        }

        protected override async Task HandleTextMessageAsync(MessageEvent ev, TextMessageContent message)
        {
            _logger.LogInformation($"Received text message: {message.Text}");
            
            var replyMessageRequest = new ReplyMessageRequest(ev.ReplyToken, new List<Message>
            {
                new TextMessage(message.Text)
            });
            
            await _api.ReplyMessageAsync(replyMessageRequest);
        }

        protected override async Task HandleStickerMessageAsync(MessageEvent ev, StickerMessageContent message)
        {
            _logger.LogInformation($"Received sticker: packageId={message.PackageId}, stickerId={message.StickerId}");
            
            var replyMessageRequest = new ReplyMessageRequest(ev.ReplyToken, new List<Message>
            {
                new TextMessage("スタンプありがとう！")
            });
            
            await _api.ReplyMessageAsync(replyMessageRequest);
        }

        protected override async Task HandleFollowEventAsync(FollowEvent ev)
        {
            _logger.LogInformation("User followed the bot");
            
            var replyMessageRequest = new ReplyMessageRequest(ev.ReplyToken, new List<Message>
            {
                new TextMessage("フォローありがとうございます！")
            });
            
            await _api.ReplyMessageAsync(replyMessageRequest);
        }

        protected override async Task HandleUnfollowEventAsync(UnfollowEvent ev)
        {
            _logger.LogInformation("User unfollowed the bot");
            // Unfollowイベントにはreply tokenがないため、ログのみ
        }

        protected override async Task HandlePostbackEventAsync(PostbackEvent ev)
        {
            _logger.LogInformation($"Received postback: {ev.Postback.Data}");

            var replyMessageRequest = new ReplyMessageRequest(ev.ReplyToken, new List<Message>
            {
                new TextMessage($"ポストバックを受信しました: {ev.Postback.Data}")
            });

            await _api.ReplyMessageAsync(replyMessageRequest);
        }
    }
}

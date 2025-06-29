using System.Collections.Generic;
using System.Threading.Tasks;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Model;
using LineOpenApi.Webhook.Model;
using LineOpenApi.Webhook;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.Functions.Worker;
using Microsoft.DurableTask;
using Microsoft.DurableTask.Client;
using Microsoft.DurableTask.Entities;
using System.Linq;

#nullable disable warnings

namespace LineBotFunctions
{
    /// <summary>
    /// Echo webhook handler that demonstrates how to use the auto-generated WebhookHandlerBase
    /// </summary>
    public class WebhookHandler : WebhookHandlerBase
    {
        private readonly IMessagingApiApiAsync _api;
        private readonly ILogger<WebhookHandler> _logger;

        private DurableTaskClient _durableClient = null!;

        public WebhookHandler(IMessagingApiApiAsync api, ILogger<WebhookHandler> logger)
        {
            _api = api;
            _logger = logger;
        }

        // DurableTaskClientを使用するメソッド
        public async Task HandleEventWithDurableAsync(Event ev, DurableTaskClient durableClient)
        {
            _durableClient = durableClient;
            await base.HandleEventAsync(ev);
        }

        // 非同期でLINEメッセージを処理するヘルパーメソッド
        public async Task ProcessLineMessageAsync(string userMessage, string userId, string replyToken)
        {
            if (_durableClient == null)
            {
                _logger.LogWarning("DurableTaskClient is not available");
                return;
            }

            try
            {
                var instanceId = userId;
                var entityId = new EntityInstanceId("LineUserReplyTokenEntity", userId);
                var entity = await _durableClient.Entities.GetEntityAsync(entityId);
                var tokenState = entity?.State?.ReadAs<ReplyTokenState>();
                var oldReplyToken = tokenState?.Token;
                _logger.LogInformation($"Entity {entityId} found with reply token: {oldReplyToken}");

                // エンティティが存在する場合は古いリプライトークンを使用
                if (!string.IsNullOrEmpty(oldReplyToken))
                {
                    // 処理中と返信
                    var replyMessageRequest = new ReplyMessageRequest(oldReplyToken, new List<Message>
                    {
                        new TextMessage("いま考え中なので、ちょっとまってくださいね。")
                    });
                    await _api.ReplyMessageAsync(replyMessageRequest);
                    _logger.LogInformation($"Entity {entityId} found, using old reply token: {oldReplyToken}");

                    // エンティティに新しいリプライトークンを設定
                    await _durableClient.Entities.SignalEntityAsync(entityId, "Set", replyToken);
                    return;
                }

                // エンティティに新しいリプライトークンを設定
                await _durableClient.Entities.SignalEntityAsync(entityId, "Set", replyToken);

                // オーケストレーターの処理状態を確認
                var orchestratorStatus = await _durableClient.GetInstanceAsync(instanceId);

                // オーケストレーターの入力データを準備
                var orchestratorInput = new Models.OrchestratorInput
                {
                    UserMessage = userMessage,
                    UserId = userId
                };

                // オーケストレーターを開始
                await _durableClient.ScheduleNewOrchestrationInstanceAsync(
                    "LineMessageOrchestrator",
                    orchestratorInput,
                    new StartOrchestrationOptions { InstanceId = instanceId });

                _logger.LogInformation($"Started orchestrator for user {userId}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error in async message processing for user {userId}");
            }
        }

        protected override async Task HandleTextMessageAsync(MessageEvent ev, TextMessageContent message)
        {
            _logger.LogInformation($"Received text message: {message.Text}");

            // DurableTaskClientが利用可能な場合は新しい処理フローを使用
            if (_durableClient != null && ev.Source is UserSource userSource && userSource.UserId != null)
            {
                await ProcessLineMessageAsync(message.Text, userSource.UserId, ev.ReplyToken);
            }
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

        protected override Task HandleUnfollowEventAsync(UnfollowEvent ev)
        {
            _logger.LogInformation("User unfollowed the bot");
            // Unfollowイベントにはreply tokenがないため、ログのみ
            return Task.CompletedTask;
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

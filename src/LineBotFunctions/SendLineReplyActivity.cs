using Microsoft.Azure.Functions.Worker;
using Microsoft.DurableTask.Client;
using Microsoft.DurableTask.Entities;
using Microsoft.Extensions.Logging;
using LineBotFunctions.Models;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineBotFunctions
{
    public class SendLineReplyActivity
    {
        private readonly ILogger<SendLineReplyActivity> _logger;
        private readonly IMessagingApiApiAsync _messagingApi;

        public SendLineReplyActivity(ILogger<SendLineReplyActivity> logger, IMessagingApiApiAsync messagingApi)
        {
            _logger = logger;
            _messagingApi = messagingApi;
        }

        [Function(nameof(SendLineReplyActivity))]
        public async Task<LineReplyResult> RunActivity(
            [ActivityTrigger] LineReplyInput input,
            [DurableClient] DurableTaskClient durableClient)
        {
            _logger.LogInformation($"Sending LINE reply for user {input.UserId} with {input.Messages.Count} messages");

            var entityId = new EntityInstanceId("LineUserReplyTokenEntity", input.UserId);

            try
            {
                // エンティティから最新のリプライトークンを取得
                var entity = await durableClient.Entities.GetEntityAsync(entityId);
                var tokenState = entity?.State?.ReadAs<ReplyTokenState>();
                var replyToken = tokenState?.Token;

                _logger.LogInformation($"Entity {entityId} found with reply token: {replyToken}");

                if (string.IsNullOrEmpty(replyToken))
                {
                    throw new Exception($"No valid reply token found for user {input.UserId}");
                }

                _logger.LogInformation($"Using reply token from entity for user {input.UserId}");

                // LINE Messaging API でメッセージを送信
                var lineMessages = ConvertToLineMessages(input.Messages);
                var replyMessageRequest = new ReplyMessageRequest(replyToken, lineMessages);
                
                await _messagingApi.ReplyMessageAsync(replyMessageRequest);
                
                _logger.LogInformation($"Successfully sent {input.Messages.Count} messages via LINE API");

                // 処理完了後にトークンをクリア
                await durableClient.Entities.SignalEntityAsync(entityId, "Clear");
                _logger.LogInformation($"Cleared reply token for user {input.UserId}");

                return new LineReplyResult
                {
                    Status = "success",
                    MessageCount = input.Messages.Count,
                    UserId = input.UserId
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"LINE reply failed for user {input.UserId}");
                throw;
            }
        }

        private List<Message> ConvertToLineMessages(List<LineMessage> messages)
        {
            var lineMessages = new List<Message>();

            foreach (var message in messages)
            {
                switch (message.Type.ToLower())
                {
                    case "text":
                        lineMessages.Add(new TextMessage(message.Text));
                        break;
                    // 他のメッセージタイプも必要に応じて追加
                    default:
                        lineMessages.Add(new TextMessage(message.Text));
                        break;
                }
            }

            return lineMessages;
        }
    }
}

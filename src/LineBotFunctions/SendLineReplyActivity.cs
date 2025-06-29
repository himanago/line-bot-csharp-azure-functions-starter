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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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
            _logger.LogInformation($"Sending LINE reply for user {input.UserId}");
            
            // JSONを解析
            JArray messagesJsonArray;
            try 
            {
                messagesJsonArray = JArray.Parse(input.MessagesJson);
                _logger.LogInformation($"Parsed {messagesJsonArray.Count} messages from JSON");
                
                // メッセージの詳細をログ出力
                for (int i = 0; i < messagesJsonArray.Count; i++)
                {
                    var msgJson = messagesJsonArray[i];
                    var msgType = msgJson["type"]?.ToString() ?? "unknown";
                    var msgText = msgJson["text"]?.ToString() ?? "";
                    _logger.LogInformation($"  Message {i}: Type={msgType}, Text={msgText}");
                }
            }
            catch (JsonReaderException ex)
            {
                _logger.LogError(ex, "Failed to parse messages JSON, falling back to error message");
                messagesJsonArray = new JArray
                {
                    new JObject
                    {
                        ["type"] = "text",
                        ["text"] = "メッセージの解析に失敗しました。"
                    }
                };
            }

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

                // JSONからMessageオブジェクトに変換してLINE APIに送信
                var messages = new List<Message>();
                
                foreach (var msgJson in messagesJsonArray)
                {
                    var msgType = msgJson["type"]?.ToString();
                    
                    if (msgType == "text")
                    {
                        // TextMessageを作成
                        var text = msgJson["text"]?.ToString() ?? "";
                        messages.Add(new TextMessage(text));
                        _logger.LogInformation($"Added TextMessage: {text}");
                    }
                    else if (msgType == "flex")
                    {
                        // FlexMessageを作成
                        var altText = msgJson["altText"]?.ToString() ?? "Flex Message";
                        var contentsJson = msgJson["contents"]?.ToString();
                        
                        if (!string.IsNullOrEmpty(contentsJson))
                        {
                            try
                            {
                                var flexContainer = JsonConvert.DeserializeObject<FlexContainer>(contentsJson);
                                messages.Add(new FlexMessage(altText, flexContainer));
                                _logger.LogInformation($"Added FlexMessage: {altText}");
                            }
                            catch (Exception flexEx)
                            {
                                _logger.LogError(flexEx, "Failed to deserialize FlexMessage, falling back to text");
                                messages.Add(new TextMessage(altText));
                            }
                        }
                        else
                        {
                            _logger.LogWarning("FlexMessage missing contents, falling back to text");
                            messages.Add(new TextMessage(altText));
                        }
                    }
                    else
                    {
                        // 他のメッセージタイプは未対応、テキストメッセージにフォールバック
                        _logger.LogWarning($"Unsupported message type: {msgType}, falling back to text");
                        var fallbackText = msgJson["text"]?.ToString() ?? $"Unsupported message type: {msgType}";
                        messages.Add(new TextMessage(fallbackText));
                    }
                }

                if (messages.Count == 0)
                {
                    throw new Exception("No valid messages to send");
                }

                // LINE Messaging API でメッセージを送信
                var replyMessageRequest = new ReplyMessageRequest(replyToken, messages);
                
                await _messagingApi.ReplyMessageAsync(replyMessageRequest);
                
                _logger.LogInformation($"Successfully sent {messages.Count} messages via LINE API");

                // 処理完了後にトークンをクリア
                await durableClient.Entities.SignalEntityAsync(entityId, "Clear");
                _logger.LogInformation($"Cleared reply token for user {input.UserId}");

                return new LineReplyResult
                {
                    Status = "success",
                    MessageCount = messages.Count,
                    UserId = input.UserId
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"LINE reply failed for user {input.UserId}");
                throw;
            }
        }
    }
}

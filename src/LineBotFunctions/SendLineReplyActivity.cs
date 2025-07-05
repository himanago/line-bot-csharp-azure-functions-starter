using Microsoft.Azure.Functions.Worker;
using Microsoft.DurableTask.Client;
using Microsoft.DurableTask.Entities;
using Microsoft.Extensions.Logging;
using LineBotFunctions.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace LineBotFunctions
{
    public class SendLineReplyActivity
    {
        private readonly ILogger<SendLineReplyActivity> _logger;
        private readonly HttpClient _httpClient;

        public SendLineReplyActivity(ILogger<SendLineReplyActivity> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        [Function(nameof(SendLineReplyActivity))]
        public async Task<LineReplyResult> RunActivity(
            [ActivityTrigger] LineReplyInput input,
            [DurableClient] DurableTaskClient durableClient)
        {
            _logger.LogInformation($"Sending LINE reply for user {input.UserId}");
            
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

            var entityId = new EntityInstanceId("LineTalkEntity", input.UserId);

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

                // JSONを直接LINE Messaging APIに送信（SDKのデシリアライゼーション問題を回避）
                var channelAccessToken = Environment.GetEnvironmentVariable("CHANNEL_ACCESS_TOKEN");
                if (string.IsNullOrEmpty(channelAccessToken))
                {
                    throw new Exception("CHANNEL_ACCESS_TOKEN environment variable is not set");
                }

                var replyData = new JObject
                {
                    ["replyToken"] = replyToken,
                    ["messages"] = messagesJsonArray
                };

                var json = replyData.ToString();
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {channelAccessToken}");

                _logger.LogInformation($"Sending to LINE API: {json}");
                
                var response = await _httpClient.PostAsync("https://api.line.me/v2/bot/message/reply", content);
                
                if (response.IsSuccessStatusCode)
                {
                    _logger.LogInformation($"Successfully sent {messagesJsonArray.Count} messages via LINE API");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"LINE API error: {response.StatusCode}, {errorContent}");
                    throw new Exception($"LINE API returned error: {response.StatusCode}");
                }

                // 処理完了後にトークンをクリア
                await durableClient.Entities.SignalEntityAsync(entityId, "Clear");
                _logger.LogInformation($"Cleared reply token for user {input.UserId}");

                return new LineReplyResult
                {
                    Status = "success",
                    MessageCount = messagesJsonArray.Count,
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

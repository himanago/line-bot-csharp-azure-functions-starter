using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace WebhookHandlerGenerator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length < 4 || args[0] != "--webhook-spec" || args[2] != "--output")
            {
                Console.WriteLine("Usage: --webhook-spec <url> --output <directory>");
                return;
            }

            var specUrl = args[1];
            var outputDir = args[3];

            try
            {
                var generator = new WebhookHandlerCodeGenerator();
                var code = await generator.GenerateAsync(specUrl);
                
                var outputPath = Path.Combine(outputDir, "WebhookHandlerBase.cs");
                await File.WriteAllTextAsync(outputPath, code);
                
                Console.WriteLine($"WebhookHandlerBase generated at: {outputPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Environment.Exit(1);
            }
        }
    }

    public class WebhookHandlerCodeGenerator
    {
        public async Task<string> GenerateAsync(string specUrl)
        {
            // OpenAPI仕様を読み込み
            using var httpClient = new System.Net.Http.HttpClient();
            var specContent = await httpClient.GetStringAsync(specUrl);
            
            var reader = new OpenApiStringReader();
            var document = reader.Read(specContent, out var diagnostic);

            // Webhookイベント型を抽出
            var eventTypes = ExtractEventTypes(document);
            var messageTypes = ExtractMessageTypes(document);

            Console.WriteLine($"Found {eventTypes.Count} event types: {string.Join(", ", eventTypes)}");
            Console.WriteLine($"Found {messageTypes.Count} message types: {string.Join(", ", messageTypes)}");

            // コード生成
            return GenerateWebhookHandlerCode(eventTypes, messageTypes);
        }

        private List<string> ExtractEventTypes(OpenApiDocument document)
        {
            var eventTypes = new List<string>();
            
            // Event型のoneOfからサブタイプを抽出
            if (document.Components.Schemas.TryGetValue("Event", out var eventSchema))
            {
                if (eventSchema.OneOf?.Any() == true)
                {
                    foreach (var oneOfSchema in eventSchema.OneOf)
                    {
                        if (oneOfSchema.Reference?.Id != null)
                        {
                            eventTypes.Add(oneOfSchema.Reference.Id);
                        }
                    }
                }
                // discriminatorからも抽出を試行
                else if (eventSchema.Discriminator?.Mapping != null)
                {
                    foreach (var mapping in eventSchema.Discriminator.Mapping.Values)
                    {
                        var typeName = mapping.Split('/').LastOrDefault()?.Replace("#/components/schemas/", "");
                        if (!string.IsNullOrEmpty(typeName))
                        {
                            eventTypes.Add(typeName);
                        }
                    }
                }
            }

            // 見つからない場合は、既知のイベント型を使用
            if (!eventTypes.Any())
            {
                eventTypes.AddRange(new[]
                {
                    "MessageEvent", "FollowEvent", "UnfollowEvent", "JoinEvent", "LeaveEvent",
                    "MemberJoinedEvent", "MemberLeftEvent", "PostbackEvent", "VideoPlayCompleteEvent",
                    "BeaconEvent", "AccountLinkEvent", "ThingsEvent", "BotSuspendedEvent", "BotResumedEvent",
                    "ActivatedEvent", "DeactivatedEvent"
                });
            }

            return eventTypes;
        }

        private List<string> ExtractMessageTypes(OpenApiDocument document)
        {
            var messageTypes = new List<string>();
            
            // MessageContent型のoneOfからサブタイプを抽出
            if (document.Components.Schemas.TryGetValue("MessageContent", out var messageSchema))
            {
                if (messageSchema.OneOf?.Any() == true)
                {
                    foreach (var oneOfSchema in messageSchema.OneOf)
                    {
                        if (oneOfSchema.Reference?.Id != null)
                        {
                            messageTypes.Add(oneOfSchema.Reference.Id);
                        }
                    }
                }
                // discriminatorからも抽出を試行
                else if (messageSchema.Discriminator?.Mapping != null)
                {
                    foreach (var mapping in messageSchema.Discriminator.Mapping.Values)
                    {
                        var typeName = mapping.Split('/').LastOrDefault()?.Replace("#/components/schemas/", "");
                        if (!string.IsNullOrEmpty(typeName))
                        {
                            messageTypes.Add(typeName);
                        }
                    }
                }
            }

            // 見つからない場合は、既知のメッセージ型を使用
            if (!messageTypes.Any())
            {
                messageTypes.AddRange(new[]
                {
                    "TextMessageContent", "ImageMessageContent", "VideoMessageContent", 
                    "AudioMessageContent", "FileMessageContent", "LocationMessageContent", 
                    "StickerMessageContent"
                });
            }

            return messageTypes;
        }

        private string GenerateWebhookHandlerCode(List<string> eventTypes, List<string> messageTypes)
        {
            var code = new StringBuilder();
            
            code.AppendLine("// This file is auto-generated. Do not edit manually.");
            code.AppendLine("using System;");
            code.AppendLine("using System.Threading.Tasks;");
            code.AppendLine("using LineOpenApi.Webhook.Model;");
            code.AppendLine();
            code.AppendLine("namespace LineOpenApi.Webhook");
            code.AppendLine("{");
            code.AppendLine("    /// <summary>");
            code.AppendLine("    /// Base class for handling LINE webhook events.");
            code.AppendLine("    /// This class is auto-generated from OpenAPI specification.");
            code.AppendLine("    /// </summary>");
            code.AppendLine("    public abstract class WebhookHandlerBase");
            code.AppendLine("    {");
            code.AppendLine();
            
            // メインディスパッチャー
            GenerateMainDispatcher(code, eventTypes);
            
            // メッセージディスパッチャー
            GenerateMessageDispatcher(code, messageTypes);
            
            // 仮想メソッド
            GenerateVirtualMethods(code, eventTypes, messageTypes);
            
            code.AppendLine("    }");
            code.AppendLine("}");
            
            return code.ToString();
        }

        private void GenerateMainDispatcher(StringBuilder code, List<string> eventTypes)
        {
            code.AppendLine("        /// <summary>");
            code.AppendLine("        /// Main event dispatcher - auto-generated based on OpenAPI event types");
            code.AppendLine("        /// </summary>");
            code.AppendLine("        public virtual async Task HandleEventAsync(Event ev)");
            code.AppendLine("        {");
            code.AppendLine("            switch (ev)");
            code.AppendLine("            {");
            
            foreach (var eventType in eventTypes)
            {
                var paramName = char.ToLowerInvariant(eventType[0]) + eventType.Substring(1);
                code.AppendLine($"                case {eventType} {paramName}:");
                code.AppendLine($"                    await Handle{eventType}Async({paramName});");
                code.AppendLine("                    break;");
            }
            
            code.AppendLine("                default:");
            code.AppendLine("                    await HandleUnknownEventAsync(ev);");
            code.AppendLine("                    break;");
            code.AppendLine("            }");
            code.AppendLine("        }");
            code.AppendLine();
        }

        private void GenerateMessageDispatcher(StringBuilder code, List<string> messageTypes)
        {
            code.AppendLine("        /// <summary>");
            code.AppendLine("        /// Message event dispatcher - auto-generated based on message content types");
            code.AppendLine("        /// </summary>");
            code.AppendLine("        protected virtual async Task HandleMessageEventAsync(MessageEvent ev)");
            code.AppendLine("        {");
            code.AppendLine("            switch (ev.Message)");
            code.AppendLine("            {");
            
            foreach (var messageType in messageTypes.Where(t => t.EndsWith("MessageContent")))
            {
                var paramName = char.ToLowerInvariant(messageType[0]) + messageType.Substring(1);
                var methodName = messageType.Replace("MessageContent", "Message");
                code.AppendLine($"                case {messageType} {paramName}:");
                code.AppendLine($"                    await Handle{methodName}Async(ev, {paramName});");
                code.AppendLine("                    break;");
            }
            
            code.AppendLine("                default:");
            code.AppendLine("                    await HandleUnknownMessageAsync(ev);");
            code.AppendLine("                    break;");
            code.AppendLine("            }");
            code.AppendLine("        }");
            code.AppendLine();
        }

        private void GenerateVirtualMethods(StringBuilder code, List<string> eventTypes, List<string> messageTypes)
        {
            // イベントハンドラーメソッド
            foreach (var eventType in eventTypes)
            {
                if (eventType == "MessageEvent")
                {
                    code.AppendLine($"        protected virtual async Task Handle{eventType}Async({eventType} ev)");
                    code.AppendLine("        {");
                    code.AppendLine("            await HandleMessageEventAsync(ev);");
                    code.AppendLine("        }");
                }
                else
                {
                    code.AppendLine($"        protected virtual Task Handle{eventType}Async({eventType} ev)");
                    code.AppendLine("            => Task.CompletedTask;");
                }
                code.AppendLine();
            }

            // メッセージハンドラーメソッド
            foreach (var messageType in messageTypes.Where(t => t.EndsWith("MessageContent")))
            {
                var methodName = messageType.Replace("MessageContent", "Message");
                code.AppendLine($"        protected virtual Task Handle{methodName}Async(MessageEvent ev, {messageType} message)");
                code.AppendLine("            => Task.CompletedTask;");
                code.AppendLine();
            }

            // デフォルトハンドラー
            code.AppendLine("        protected virtual Task HandleUnknownEventAsync(Event ev)");
            code.AppendLine("        {");
            code.AppendLine("            return Task.CompletedTask;");
            code.AppendLine("        }");
            code.AppendLine();
            
            code.AppendLine("        protected virtual Task HandleUnknownMessageAsync(MessageEvent ev)");
            code.AppendLine("        {");
            code.AppendLine("            return Task.CompletedTask;");
            code.AppendLine("        }");
        }
    }
}

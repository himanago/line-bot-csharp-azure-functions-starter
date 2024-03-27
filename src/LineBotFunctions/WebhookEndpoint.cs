using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Model;
using LineOpenApi.Webhook.Model;
using System.Collections.Generic;

namespace LineBotFunctions;
public class WebhookEndpoint
{
    private IMessagingApiApiAsync Api { get; }

    public WebhookEndpoint(IMessagingApiApiAsync api)
    {
        Api = api;
    }

    [FunctionName("WebhookEndpoint")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# webhook endpoint function processed a request.");

        try
        {
            var body = await new StreamReader(req.Body).ReadToEndAsync();
            var callbackRequest = JsonConvert.DeserializeObject<CallbackRequest>(body);

            foreach (var ev in callbackRequest.Events)
            {
                // echo when receive text message
                if (ev is MessageEvent messageEvent && messageEvent.Message is TextMessageContent textMessageContent)
                {
                    var replyMessageRequest = new ReplyMessageRequest(messageEvent.ReplyToken, new List<Message>
                    {
                        new TextMessage(textMessageContent.Text)
                        {
                            Type = "text"
                        }
                    });
                    await Api.ReplyMessageAsync(replyMessageRequest);
                }
            }
        }
        catch (Exception e)
        {
            log.LogError($"Error: {e.Message}");
            log.LogError($"Error: {e.StackTrace}");
        }
        
        return new OkObjectResult("OK");
    }
}

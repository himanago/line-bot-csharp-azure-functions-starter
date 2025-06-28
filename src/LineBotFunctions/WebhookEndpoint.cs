using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Model;
using LineOpenApi.Webhook.Model;
using System.Collections.Generic;
using System.Net;
using Microsoft.DurableTask.Client;

namespace LineBotFunctions;
public class WebhookEndpoint
{
    private readonly WebhookHandler _handler;

    public WebhookEndpoint(WebhookHandler handler)
    {
        _handler = handler;
    }

    [Function("WebhookEndpoint")]
    public async Task<HttpResponseData> Run(
        [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req,
        [DurableClient] DurableTaskClient durableClient,
        FunctionContext executionContext)
    {
        var logger = executionContext.GetLogger("WebhookEndpoint");
        logger.LogInformation("C# webhook endpoint function processed a request.");

        try
        {
            var body = await new StreamReader(req.Body).ReadToEndAsync();
            logger.LogInformation($"Received webhook body: {body}");

            var callbackRequest = JsonConvert.DeserializeObject<CallbackRequest>(body);
            if (callbackRequest?.Events != null)
            {
                logger.LogInformation($"Processing {callbackRequest.Events.Count} events");
                foreach (var ev in callbackRequest.Events)
                {
                    // DurableTaskClientを使用してイベントを処理
                    await _handler.HandleEventWithDurableAsync(ev, durableClient);
                }
            }
            else
            {
                logger.LogWarning("No events found in callback request");
            }
        }
        catch (JsonException jsonEx)
        {
            logger.LogError($"JSON deserialization error: {jsonEx.Message}");
            logger.LogError($"Stack trace: {jsonEx.StackTrace}");
        }
        catch (Exception e)
        {
            logger.LogError($"General error: {e.Message}");
            logger.LogError($"Stack trace: {e.StackTrace}");
        }
        
        var response = req.CreateResponse(HttpStatusCode.OK);
        response.WriteString("OK");
        return response;
    }
}

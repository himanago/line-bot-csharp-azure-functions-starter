using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Model;
using LineOpenApi.Webhook.Model;
using System.Collections.Generic;
using System.Net;

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
        FunctionContext executionContext)
    {
        var logger = executionContext.GetLogger("WebhookEndpoint");
        logger.LogInformation("C# webhook endpoint function processed a request.");

        try
        {
            var body = await new StreamReader(req.Body).ReadToEndAsync();
            var callbackRequest = JsonSerializer.Deserialize<CallbackRequest>(body);

            if (callbackRequest?.Events != null)
            {
                foreach (var ev in callbackRequest.Events)
                {
                    await _handler.HandleEventAsync(ev);
                }
            }
        }
        catch (Exception e)
        {
            logger.LogError($"Error: {e.Message}");
            logger.LogError($"Error: {e.StackTrace}");
        }
        
        var response = req.CreateResponse(HttpStatusCode.OK);
        response.WriteString("OK");
        return response;
    }
}

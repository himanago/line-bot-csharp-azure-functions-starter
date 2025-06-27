using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Client;
using LineBotFunctions;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();

        // LINE Messaging API クライアントの設定
        var channelAccessToken = Environment.GetEnvironmentVariable("CHANNEL_ACCESS_TOKEN");
        if (string.IsNullOrEmpty(channelAccessToken))
        {
            throw new InvalidOperationException("CHANNEL_ACCESS_TOKEN environment variable is not set");
        }

        services.AddSingleton<Configuration>(provider =>
        {
            var config = new Configuration();
            config.AccessToken = channelAccessToken;
            return config;
        });

        services.AddSingleton<IMessagingApiApiAsync>(provider =>
        {
            var config = provider.GetRequiredService<Configuration>();
            return new MessagingApiApi(config);
        });

        // WebhookHandlerの登録
        services.AddScoped<WebhookHandler>();

        services.AddLogging();
    })
    .Build();

host.Run();
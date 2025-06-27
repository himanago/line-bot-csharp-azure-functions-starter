using LineBotFunctions.Config;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Client;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


[assembly: FunctionsStartup(typeof(LineBotFunctions.Startup))]
namespace LineBotFunctions;
public class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("local.settings.json", true)
            .AddEnvironmentVariables()
            .Build();

        var settings = config.GetSection(nameof(LineBotSettings)).Get<LineBotSettings>();

        var api = new MessagingApiApi(new Configuration
        {
            AccessToken = settings.ChannelAccessToken
        });

        builder.Services
            .AddSingleton(settings)
            .AddSingleton<IMessagingApiApiAsync>(api);
    }
}
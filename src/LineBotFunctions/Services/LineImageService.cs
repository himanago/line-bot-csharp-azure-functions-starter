using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace LineBotFunctions.Services
{
    public class LineImageService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<LineImageService> _logger;

        public LineImageService(HttpClient httpClient, ILogger<LineImageService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<byte[]> GetImageDataAsync(string messageId)
        {
            try
            {
                var channelAccessToken = Environment.GetEnvironmentVariable("CHANNEL_ACCESS_TOKEN");
                if (string.IsNullOrEmpty(channelAccessToken))
                {
                    throw new InvalidOperationException("CHANNEL_ACCESS_TOKEN environment variable is not set");
                }

                var url = $"https://api-data.line.me/v2/bot/message/{messageId}/content";
                
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {channelAccessToken}");

                _logger.LogInformation($"Fetching image data from LINE API: {url}");
                
                var response = await _httpClient.GetAsync(url);
                
                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Failed to fetch image data: {response.StatusCode}, {errorContent}");
                    throw new HttpRequestException($"Failed to fetch image data: {response.StatusCode}");
                }

                var imageData = await response.Content.ReadAsByteArrayAsync();
                var contentType = response.Content.Headers.ContentType?.MediaType ?? "unknown";
                
                _logger.LogInformation($"Successfully fetched image data: {imageData.Length} bytes, Content-Type: {contentType}");
                
                return imageData;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error fetching image data for message {messageId}");
                throw;
            }
        }

        public async Task<string> GetImageAsBase64Async(string messageId)
        {
            var imageData = await GetImageDataAsync(messageId);
            return Convert.ToBase64String(imageData);
        }
    }
}

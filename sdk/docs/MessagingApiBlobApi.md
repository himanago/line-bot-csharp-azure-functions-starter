# LineOpenApi.MessagingApi.Api.MessagingApiBlobApi

All URIs are relative to *https://api.line.me*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMessageContent**](MessagingApiBlobApi.md#getmessagecontent) | **GET** /v2/bot/message/{messageId}/content |  |
| [**GetMessageContentPreview**](MessagingApiBlobApi.md#getmessagecontentpreview) | **GET** /v2/bot/message/{messageId}/content/preview |  |
| [**GetMessageContentTranscodingByMessageId**](MessagingApiBlobApi.md#getmessagecontenttranscodingbymessageid) | **GET** /v2/bot/message/{messageId}/content/transcoding |  |
| [**GetRichMenuImage**](MessagingApiBlobApi.md#getrichmenuimage) | **GET** /v2/bot/richmenu/{richMenuId}/content |  |
| [**SetRichMenuImage**](MessagingApiBlobApi.md#setrichmenuimage) | **POST** /v2/bot/richmenu/{richMenuId}/content |  |

<a id="getmessagecontent"></a>
# **GetMessageContent**
> FileParameter GetMessageContent (string messageId)



Download image, video, and audio data sent from users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Client;
using LineOpenApi.MessagingApi.Model;

namespace Example
{
    public class GetMessageContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.line.me";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MessagingApiBlobApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // string | Message ID of video or audio

            try
            {
                FileParameter result = apiInstance.GetMessageContent(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiBlobApi.GetMessageContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessageContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileParameter> response = apiInstance.GetMessageContentWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiBlobApi.GetMessageContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** | Message ID of video or audio |  |

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessagecontentpreview"></a>
# **GetMessageContentPreview**
> FileParameter GetMessageContentPreview (string messageId)



Get a preview image of the image or video

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Client;
using LineOpenApi.MessagingApi.Model;

namespace Example
{
    public class GetMessageContentPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.line.me";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MessagingApiBlobApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // string | Message ID of image or video

            try
            {
                FileParameter result = apiInstance.GetMessageContentPreview(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiBlobApi.GetMessageContentPreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessageContentPreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileParameter> response = apiInstance.GetMessageContentPreviewWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiBlobApi.GetMessageContentPreviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** | Message ID of image or video |  |

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessagecontenttranscodingbymessageid"></a>
# **GetMessageContentTranscodingByMessageId**
> GetMessageContentTranscodingResponse GetMessageContentTranscodingByMessageId (string messageId)



Verify the preparation status of a video or audio for getting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Client;
using LineOpenApi.MessagingApi.Model;

namespace Example
{
    public class GetMessageContentTranscodingByMessageIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.line.me";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MessagingApiBlobApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // string | Message ID of video or audio

            try
            {
                GetMessageContentTranscodingResponse result = apiInstance.GetMessageContentTranscodingByMessageId(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiBlobApi.GetMessageContentTranscodingByMessageId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessageContentTranscodingByMessageIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetMessageContentTranscodingResponse> response = apiInstance.GetMessageContentTranscodingByMessageIdWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiBlobApi.GetMessageContentTranscodingByMessageIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** | Message ID of video or audio |  |

### Return type

[**GetMessageContentTranscodingResponse**](GetMessageContentTranscodingResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrichmenuimage"></a>
# **GetRichMenuImage**
> FileParameter GetRichMenuImage (string richMenuId)



Download rich menu image.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Client;
using LineOpenApi.MessagingApi.Model;

namespace Example
{
    public class GetRichMenuImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.line.me";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MessagingApiBlobApi(httpClient, config, httpClientHandler);
            var richMenuId = "richMenuId_example";  // string | ID of the rich menu with the image to be downloaded

            try
            {
                FileParameter result = apiInstance.GetRichMenuImage(richMenuId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiBlobApi.GetRichMenuImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRichMenuImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileParameter> response = apiInstance.GetRichMenuImageWithHttpInfo(richMenuId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiBlobApi.GetRichMenuImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuId** | **string** | ID of the rich menu with the image to be downloaded |  |

### Return type

[**FileParameter**](FileParameter.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setrichmenuimage"></a>
# **SetRichMenuImage**
> void SetRichMenuImage (string richMenuId, FileParameter body = null)



Upload rich menu image

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using LineOpenApi.MessagingApi.Api;
using LineOpenApi.MessagingApi.Client;
using LineOpenApi.MessagingApi.Model;

namespace Example
{
    public class SetRichMenuImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.line.me";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MessagingApiBlobApi(httpClient, config, httpClientHandler);
            var richMenuId = "richMenuId_example";  // string | The ID of the rich menu to attach the image to
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter |  (optional) 

            try
            {
                apiInstance.SetRichMenuImage(richMenuId, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiBlobApi.SetRichMenuImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetRichMenuImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetRichMenuImageWithHttpInfo(richMenuId, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiBlobApi.SetRichMenuImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuId** | **string** | The ID of the rich menu to attach the image to |  |
| **body** | **FileParameter****FileParameter** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


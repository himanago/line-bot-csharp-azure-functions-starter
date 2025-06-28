# LineOpenApi.Webhook.Api.DummyApi

All URIs are relative to *https://example.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Callback**](DummyApi.md#callback) | **POST** /callback |  |

<a id="callback"></a>
# **Callback**
> string Callback (CallbackRequest callbackRequest)



This is the dummy endpoint to generate the model classes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using LineOpenApi.Webhook.Api;
using LineOpenApi.Webhook.Client;
using LineOpenApi.Webhook.Model;

namespace Example
{
    public class CallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://example.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DummyApi(httpClient, config, httpClientHandler);
            var callbackRequest = new CallbackRequest(); // CallbackRequest | 

            try
            {
                string result = apiInstance.Callback(callbackRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DummyApi.Callback: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CallbackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.CallbackWithHttpInfo(callbackRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DummyApi.CallbackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **callbackRequest** | [**CallbackRequest**](CallbackRequest.md) |  |  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


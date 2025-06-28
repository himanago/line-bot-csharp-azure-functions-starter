# LineOpenApi.MessagingApi.Api.MessagingApiApi

All URIs are relative to *https://api.line.me*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Broadcast**](MessagingApiApi.md#broadcast) | **POST** /v2/bot/message/broadcast |  |
| [**CancelDefaultRichMenu**](MessagingApiApi.md#canceldefaultrichmenu) | **DELETE** /v2/bot/user/all/richmenu |  |
| [**CreateRichMenu**](MessagingApiApi.md#createrichmenu) | **POST** /v2/bot/richmenu |  |
| [**CreateRichMenuAlias**](MessagingApiApi.md#createrichmenualias) | **POST** /v2/bot/richmenu/alias |  |
| [**DeleteRichMenu**](MessagingApiApi.md#deleterichmenu) | **DELETE** /v2/bot/richmenu/{richMenuId} |  |
| [**DeleteRichMenuAlias**](MessagingApiApi.md#deleterichmenualias) | **DELETE** /v2/bot/richmenu/alias/{richMenuAliasId} |  |
| [**GetAggregationUnitNameList**](MessagingApiApi.md#getaggregationunitnamelist) | **GET** /v2/bot/message/aggregation/list |  |
| [**GetAggregationUnitUsage**](MessagingApiApi.md#getaggregationunitusage) | **GET** /v2/bot/message/aggregation/info |  |
| [**GetBotInfo**](MessagingApiApi.md#getbotinfo) | **GET** /v2/bot/info |  |
| [**GetDefaultRichMenuId**](MessagingApiApi.md#getdefaultrichmenuid) | **GET** /v2/bot/user/all/richmenu |  |
| [**GetFollowers**](MessagingApiApi.md#getfollowers) | **GET** /v2/bot/followers/ids |  |
| [**GetGroupMemberCount**](MessagingApiApi.md#getgroupmembercount) | **GET** /v2/bot/group/{groupId}/members/count |  |
| [**GetGroupMemberProfile**](MessagingApiApi.md#getgroupmemberprofile) | **GET** /v2/bot/group/{groupId}/member/{userId} |  |
| [**GetGroupMembersIds**](MessagingApiApi.md#getgroupmembersids) | **GET** /v2/bot/group/{groupId}/members/ids |  |
| [**GetGroupSummary**](MessagingApiApi.md#getgroupsummary) | **GET** /v2/bot/group/{groupId}/summary |  |
| [**GetJoinedMembershipUsers**](MessagingApiApi.md#getjoinedmembershipusers) | **GET** /v2/bot/membership/{membershipId}/users/ids |  |
| [**GetMembershipList**](MessagingApiApi.md#getmembershiplist) | **GET** /v2/bot/membership/list |  |
| [**GetMembershipSubscription**](MessagingApiApi.md#getmembershipsubscription) | **GET** /v2/bot/membership/subscription/{userId} |  |
| [**GetMessageQuota**](MessagingApiApi.md#getmessagequota) | **GET** /v2/bot/message/quota |  |
| [**GetMessageQuotaConsumption**](MessagingApiApi.md#getmessagequotaconsumption) | **GET** /v2/bot/message/quota/consumption |  |
| [**GetNarrowcastProgress**](MessagingApiApi.md#getnarrowcastprogress) | **GET** /v2/bot/message/progress/narrowcast |  |
| [**GetNumberOfSentBroadcastMessages**](MessagingApiApi.md#getnumberofsentbroadcastmessages) | **GET** /v2/bot/message/delivery/broadcast |  |
| [**GetNumberOfSentMulticastMessages**](MessagingApiApi.md#getnumberofsentmulticastmessages) | **GET** /v2/bot/message/delivery/multicast |  |
| [**GetNumberOfSentPushMessages**](MessagingApiApi.md#getnumberofsentpushmessages) | **GET** /v2/bot/message/delivery/push |  |
| [**GetNumberOfSentReplyMessages**](MessagingApiApi.md#getnumberofsentreplymessages) | **GET** /v2/bot/message/delivery/reply |  |
| [**GetPNPMessageStatistics**](MessagingApiApi.md#getpnpmessagestatistics) | **GET** /v2/bot/message/delivery/pnp |  |
| [**GetProfile**](MessagingApiApi.md#getprofile) | **GET** /v2/bot/profile/{userId} |  |
| [**GetRichMenu**](MessagingApiApi.md#getrichmenu) | **GET** /v2/bot/richmenu/{richMenuId} |  |
| [**GetRichMenuAlias**](MessagingApiApi.md#getrichmenualias) | **GET** /v2/bot/richmenu/alias/{richMenuAliasId} |  |
| [**GetRichMenuAliasList**](MessagingApiApi.md#getrichmenualiaslist) | **GET** /v2/bot/richmenu/alias/list |  |
| [**GetRichMenuBatchProgress**](MessagingApiApi.md#getrichmenubatchprogress) | **GET** /v2/bot/richmenu/progress/batch |  |
| [**GetRichMenuIdOfUser**](MessagingApiApi.md#getrichmenuidofuser) | **GET** /v2/bot/user/{userId}/richmenu |  |
| [**GetRichMenuList**](MessagingApiApi.md#getrichmenulist) | **GET** /v2/bot/richmenu/list |  |
| [**GetRoomMemberCount**](MessagingApiApi.md#getroommembercount) | **GET** /v2/bot/room/{roomId}/members/count |  |
| [**GetRoomMemberProfile**](MessagingApiApi.md#getroommemberprofile) | **GET** /v2/bot/room/{roomId}/member/{userId} |  |
| [**GetRoomMembersIds**](MessagingApiApi.md#getroommembersids) | **GET** /v2/bot/room/{roomId}/members/ids |  |
| [**GetWebhookEndpoint**](MessagingApiApi.md#getwebhookendpoint) | **GET** /v2/bot/channel/webhook/endpoint |  |
| [**IssueLinkToken**](MessagingApiApi.md#issuelinktoken) | **POST** /v2/bot/user/{userId}/linkToken |  |
| [**LeaveGroup**](MessagingApiApi.md#leavegroup) | **POST** /v2/bot/group/{groupId}/leave |  |
| [**LeaveRoom**](MessagingApiApi.md#leaveroom) | **POST** /v2/bot/room/{roomId}/leave |  |
| [**LinkRichMenuIdToUser**](MessagingApiApi.md#linkrichmenuidtouser) | **POST** /v2/bot/user/{userId}/richmenu/{richMenuId} |  |
| [**LinkRichMenuIdToUsers**](MessagingApiApi.md#linkrichmenuidtousers) | **POST** /v2/bot/richmenu/bulk/link |  |
| [**MarkMessagesAsRead**](MessagingApiApi.md#markmessagesasread) | **POST** /v2/bot/message/markAsRead |  |
| [**Multicast**](MessagingApiApi.md#multicast) | **POST** /v2/bot/message/multicast |  |
| [**Narrowcast**](MessagingApiApi.md#narrowcast) | **POST** /v2/bot/message/narrowcast |  |
| [**PushMessage**](MessagingApiApi.md#pushmessage) | **POST** /v2/bot/message/push |  |
| [**PushMessagesByPhone**](MessagingApiApi.md#pushmessagesbyphone) | **POST** /bot/pnp/push |  |
| [**ReplyMessage**](MessagingApiApi.md#replymessage) | **POST** /v2/bot/message/reply |  |
| [**RichMenuBatch**](MessagingApiApi.md#richmenubatch) | **POST** /v2/bot/richmenu/batch |  |
| [**SetDefaultRichMenu**](MessagingApiApi.md#setdefaultrichmenu) | **POST** /v2/bot/user/all/richmenu/{richMenuId} |  |
| [**SetWebhookEndpoint**](MessagingApiApi.md#setwebhookendpoint) | **PUT** /v2/bot/channel/webhook/endpoint |  |
| [**ShowLoadingAnimation**](MessagingApiApi.md#showloadinganimation) | **POST** /v2/bot/chat/loading/start |  |
| [**TestWebhookEndpoint**](MessagingApiApi.md#testwebhookendpoint) | **POST** /v2/bot/channel/webhook/test |  |
| [**UnlinkRichMenuIdFromUser**](MessagingApiApi.md#unlinkrichmenuidfromuser) | **DELETE** /v2/bot/user/{userId}/richmenu |  |
| [**UnlinkRichMenuIdFromUsers**](MessagingApiApi.md#unlinkrichmenuidfromusers) | **POST** /v2/bot/richmenu/bulk/unlink |  |
| [**UpdateRichMenuAlias**](MessagingApiApi.md#updaterichmenualias) | **POST** /v2/bot/richmenu/alias/{richMenuAliasId} |  |
| [**ValidateBroadcast**](MessagingApiApi.md#validatebroadcast) | **POST** /v2/bot/message/validate/broadcast |  |
| [**ValidateMulticast**](MessagingApiApi.md#validatemulticast) | **POST** /v2/bot/message/validate/multicast |  |
| [**ValidateNarrowcast**](MessagingApiApi.md#validatenarrowcast) | **POST** /v2/bot/message/validate/narrowcast |  |
| [**ValidatePush**](MessagingApiApi.md#validatepush) | **POST** /v2/bot/message/validate/push |  |
| [**ValidateReply**](MessagingApiApi.md#validatereply) | **POST** /v2/bot/message/validate/reply |  |
| [**ValidateRichMenuBatchRequest**](MessagingApiApi.md#validaterichmenubatchrequest) | **POST** /v2/bot/richmenu/validate/batch |  |
| [**ValidateRichMenuObject**](MessagingApiApi.md#validaterichmenuobject) | **POST** /v2/bot/richmenu/validate |  |

<a id="broadcast"></a>
# **Broadcast**
> Object Broadcast (BroadcastRequest broadcastRequest, Guid? xLineRetryKey = null)



Sends a message to multiple users at any time.

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
    public class BroadcastExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var broadcastRequest = new BroadcastRequest(); // BroadcastRequest | 
            var xLineRetryKey = "xLineRetryKey_example";  // Guid? | Retry key. Specifies the UUID in hexadecimal format (e.g., `123e4567-e89b-12d3-a456-426614174000`) generated by any method. The retry key isn't generated by LINE. Each developer must generate their own retry key.  (optional) 

            try
            {
                Object result = apiInstance.Broadcast(broadcastRequest, xLineRetryKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.Broadcast: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BroadcastWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.BroadcastWithHttpInfo(broadcastRequest, xLineRetryKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.BroadcastWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **broadcastRequest** | [**BroadcastRequest**](BroadcastRequest.md) |  |  |
| **xLineRetryKey** | **Guid?** | Retry key. Specifies the UUID in hexadecimal format (e.g., &#x60;123e4567-e89b-12d3-a456-426614174000&#x60;) generated by any method. The retry key isn&#39;t generated by LINE. Each developer must generate their own retry key.  | [optional]  |

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="canceldefaultrichmenu"></a>
# **CancelDefaultRichMenu**
> void CancelDefaultRichMenu ()



Cancel default rich menu

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
    public class CancelDefaultRichMenuExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.CancelDefaultRichMenu();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.CancelDefaultRichMenu: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelDefaultRichMenuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CancelDefaultRichMenuWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.CancelDefaultRichMenuWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="createrichmenu"></a>
# **CreateRichMenu**
> RichMenuIdResponse CreateRichMenu (RichMenuRequest richMenuRequest)



Create rich menu

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
    public class CreateRichMenuExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuRequest = new RichMenuRequest(); // RichMenuRequest | 

            try
            {
                RichMenuIdResponse result = apiInstance.CreateRichMenu(richMenuRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.CreateRichMenu: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRichMenuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RichMenuIdResponse> response = apiInstance.CreateRichMenuWithHttpInfo(richMenuRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.CreateRichMenuWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuRequest** | [**RichMenuRequest**](RichMenuRequest.md) |  |  |

### Return type

[**RichMenuIdResponse**](RichMenuIdResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createrichmenualias"></a>
# **CreateRichMenuAlias**
> void CreateRichMenuAlias (CreateRichMenuAliasRequest createRichMenuAliasRequest)



Create rich menu alias

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
    public class CreateRichMenuAliasExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var createRichMenuAliasRequest = new CreateRichMenuAliasRequest(); // CreateRichMenuAliasRequest | 

            try
            {
                apiInstance.CreateRichMenuAlias(createRichMenuAliasRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.CreateRichMenuAlias: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRichMenuAliasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateRichMenuAliasWithHttpInfo(createRichMenuAliasRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.CreateRichMenuAliasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRichMenuAliasRequest** | [**CreateRichMenuAliasRequest**](CreateRichMenuAliasRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleterichmenu"></a>
# **DeleteRichMenu**
> void DeleteRichMenu (string richMenuId)



Deletes a rich menu.

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
    public class DeleteRichMenuExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuId = "richMenuId_example";  // string | ID of a rich menu

            try
            {
                apiInstance.DeleteRichMenu(richMenuId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.DeleteRichMenu: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRichMenuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteRichMenuWithHttpInfo(richMenuId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.DeleteRichMenuWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuId** | **string** | ID of a rich menu |  |

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

<a id="deleterichmenualias"></a>
# **DeleteRichMenuAlias**
> void DeleteRichMenuAlias (string richMenuAliasId)



Delete rich menu alias

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
    public class DeleteRichMenuAliasExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuAliasId = "richMenuAliasId_example";  // string | Rich menu alias ID that you want to delete.

            try
            {
                apiInstance.DeleteRichMenuAlias(richMenuAliasId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.DeleteRichMenuAlias: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRichMenuAliasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteRichMenuAliasWithHttpInfo(richMenuAliasId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.DeleteRichMenuAliasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuAliasId** | **string** | Rich menu alias ID that you want to delete. |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaggregationunitnamelist"></a>
# **GetAggregationUnitNameList**
> GetAggregationUnitNameListResponse GetAggregationUnitNameList (string limit = null, string start = null)



Get name list of units used this month

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
    public class GetAggregationUnitNameListExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var limit = "limit_example";  // string | The maximum number of aggregation units you can get per request.  (optional) 
            var start = "start_example";  // string | Value of the continuation token found in the next property of the JSON object returned in the response. If you can't get all the aggregation units in one request, include this parameter to get the remaining array.  (optional) 

            try
            {
                GetAggregationUnitNameListResponse result = apiInstance.GetAggregationUnitNameList(limit, start);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetAggregationUnitNameList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAggregationUnitNameListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetAggregationUnitNameListResponse> response = apiInstance.GetAggregationUnitNameListWithHttpInfo(limit, start);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetAggregationUnitNameListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **string** | The maximum number of aggregation units you can get per request.  | [optional]  |
| **start** | **string** | Value of the continuation token found in the next property of the JSON object returned in the response. If you can&#39;t get all the aggregation units in one request, include this parameter to get the remaining array.  | [optional]  |

### Return type

[**GetAggregationUnitNameListResponse**](GetAggregationUnitNameListResponse.md)

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

<a id="getaggregationunitusage"></a>
# **GetAggregationUnitUsage**
> GetAggregationUnitUsageResponse GetAggregationUnitUsage ()



Get number of units used this month

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
    public class GetAggregationUnitUsageExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);

            try
            {
                GetAggregationUnitUsageResponse result = apiInstance.GetAggregationUnitUsage();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetAggregationUnitUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAggregationUnitUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetAggregationUnitUsageResponse> response = apiInstance.GetAggregationUnitUsageWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetAggregationUnitUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetAggregationUnitUsageResponse**](GetAggregationUnitUsageResponse.md)

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

<a id="getbotinfo"></a>
# **GetBotInfo**
> BotInfoResponse GetBotInfo ()



Get bot info

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
    public class GetBotInfoExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);

            try
            {
                BotInfoResponse result = apiInstance.GetBotInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetBotInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBotInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BotInfoResponse> response = apiInstance.GetBotInfoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetBotInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**BotInfoResponse**](BotInfoResponse.md)

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

<a id="getdefaultrichmenuid"></a>
# **GetDefaultRichMenuId**
> RichMenuIdResponse GetDefaultRichMenuId ()



Gets the ID of the default rich menu set with the Messaging API.

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
    public class GetDefaultRichMenuIdExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);

            try
            {
                RichMenuIdResponse result = apiInstance.GetDefaultRichMenuId();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetDefaultRichMenuId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDefaultRichMenuIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RichMenuIdResponse> response = apiInstance.GetDefaultRichMenuIdWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetDefaultRichMenuIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RichMenuIdResponse**](RichMenuIdResponse.md)

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

<a id="getfollowers"></a>
# **GetFollowers**
> GetFollowersResponse GetFollowers (string start = null, int? limit = null)



Get a list of users who added your LINE Official Account as a friend

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
    public class GetFollowersExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var start = "start_example";  // string | Value of the continuation token found in the next property of the JSON object returned in the response. Include this parameter to get the next array of user IDs.  (optional) 
            var limit = 300;  // int? | The maximum number of user IDs to retrieve in a single request. (optional)  (default to 300)

            try
            {
                GetFollowersResponse result = apiInstance.GetFollowers(start, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetFollowersResponse> response = apiInstance.GetFollowersWithHttpInfo(start, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **string** | Value of the continuation token found in the next property of the JSON object returned in the response. Include this parameter to get the next array of user IDs.  | [optional]  |
| **limit** | **int?** | The maximum number of user IDs to retrieve in a single request. | [optional] [default to 300] |

### Return type

[**GetFollowersResponse**](GetFollowersResponse.md)

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

<a id="getgroupmembercount"></a>
# **GetGroupMemberCount**
> GroupMemberCountResponse GetGroupMemberCount (string groupId)



Get number of users in a group chat

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
    public class GetGroupMemberCountExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var groupId = "groupId_example";  // string | Group ID

            try
            {
                GroupMemberCountResponse result = apiInstance.GetGroupMemberCount(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetGroupMemberCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupMemberCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupMemberCountResponse> response = apiInstance.GetGroupMemberCountWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetGroupMemberCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Group ID |  |

### Return type

[**GroupMemberCountResponse**](GroupMemberCountResponse.md)

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

<a id="getgroupmemberprofile"></a>
# **GetGroupMemberProfile**
> GroupUserProfileResponse GetGroupMemberProfile (string groupId, string userId)



Get group chat member profile

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
    public class GetGroupMemberProfileExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var groupId = "groupId_example";  // string | Group ID
            var userId = "userId_example";  // string | User ID

            try
            {
                GroupUserProfileResponse result = apiInstance.GetGroupMemberProfile(groupId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetGroupMemberProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupMemberProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupUserProfileResponse> response = apiInstance.GetGroupMemberProfileWithHttpInfo(groupId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetGroupMemberProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Group ID |  |
| **userId** | **string** | User ID |  |

### Return type

[**GroupUserProfileResponse**](GroupUserProfileResponse.md)

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

<a id="getgroupmembersids"></a>
# **GetGroupMembersIds**
> MembersIdsResponse GetGroupMembersIds (string groupId, string start = null)



Get group chat member user IDs

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
    public class GetGroupMembersIdsExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var groupId = "groupId_example";  // string | Group ID
            var start = "start_example";  // string | Value of the continuation token found in the `next` property of the JSON object returned in the response. Include this parameter to get the next array of user IDs for the members of the group.  (optional) 

            try
            {
                MembersIdsResponse result = apiInstance.GetGroupMembersIds(groupId, start);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetGroupMembersIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupMembersIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MembersIdsResponse> response = apiInstance.GetGroupMembersIdsWithHttpInfo(groupId, start);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetGroupMembersIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Group ID |  |
| **start** | **string** | Value of the continuation token found in the &#x60;next&#x60; property of the JSON object returned in the response. Include this parameter to get the next array of user IDs for the members of the group.  | [optional]  |

### Return type

[**MembersIdsResponse**](MembersIdsResponse.md)

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

<a id="getgroupsummary"></a>
# **GetGroupSummary**
> GroupSummaryResponse GetGroupSummary (string groupId)



Get group chat summary

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
    public class GetGroupSummaryExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var groupId = "groupId_example";  // string | Group ID

            try
            {
                GroupSummaryResponse result = apiInstance.GetGroupSummary(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetGroupSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupSummaryResponse> response = apiInstance.GetGroupSummaryWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetGroupSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Group ID |  |

### Return type

[**GroupSummaryResponse**](GroupSummaryResponse.md)

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

<a id="getjoinedmembershipusers"></a>
# **GetJoinedMembershipUsers**
> GetJoinedMembershipUsersResponse GetJoinedMembershipUsers (int membershipId, string start = null, int? limit = null)



Get a list of user IDs who joined the membership.

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
    public class GetJoinedMembershipUsersExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var membershipId = 56;  // int | Membership plan ID.
            var start = "start_example";  // string | A continuation token to get next remaining membership user IDs. Returned only when there are remaining user IDs that weren't returned in the userIds property in the previous request. The continuation token expires in 24 hours (86,400 seconds).  (optional) 
            var limit = 300;  // int? | The max number of items to return for this API call. The value is set to 300 by default, but the max acceptable value is 1000.  (optional)  (default to 300)

            try
            {
                GetJoinedMembershipUsersResponse result = apiInstance.GetJoinedMembershipUsers(membershipId, start, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetJoinedMembershipUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJoinedMembershipUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetJoinedMembershipUsersResponse> response = apiInstance.GetJoinedMembershipUsersWithHttpInfo(membershipId, start, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetJoinedMembershipUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **membershipId** | **int** | Membership plan ID. |  |
| **start** | **string** | A continuation token to get next remaining membership user IDs. Returned only when there are remaining user IDs that weren&#39;t returned in the userIds property in the previous request. The continuation token expires in 24 hours (86,400 seconds).  | [optional]  |
| **limit** | **int?** | The max number of items to return for this API call. The value is set to 300 by default, but the max acceptable value is 1000.  | [optional] [default to 300] |

### Return type

[**GetJoinedMembershipUsersResponse**](GetJoinedMembershipUsersResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | &#x60;start&#x60; is incorrect or expired, or &#x60;limit&#x60; is under 1 or over 1000. |  -  |
| **404** | Membership ID is not owned by the bot or does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmembershiplist"></a>
# **GetMembershipList**
> MembershipListResponse GetMembershipList ()



Get a list of memberships.

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
    public class GetMembershipListExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);

            try
            {
                MembershipListResponse result = apiInstance.GetMembershipList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetMembershipList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMembershipListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MembershipListResponse> response = apiInstance.GetMembershipListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetMembershipListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MembershipListResponse**](MembershipListResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Unable to get information about the memberships. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmembershipsubscription"></a>
# **GetMembershipSubscription**
> GetMembershipSubscriptionResponse GetMembershipSubscription (string userId)



Get a user's membership subscription.

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
    public class GetMembershipSubscriptionExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // string | User ID

            try
            {
                GetMembershipSubscriptionResponse result = apiInstance.GetMembershipSubscription(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetMembershipSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMembershipSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetMembershipSubscriptionResponse> response = apiInstance.GetMembershipSubscriptionWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetMembershipSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | User ID |  |

### Return type

[**GetMembershipSubscriptionResponse**](GetMembershipSubscriptionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | An invalid user ID is specified. |  -  |
| **404** | Unable to get information about the membership to which the user subscribes. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessagequota"></a>
# **GetMessageQuota**
> MessageQuotaResponse GetMessageQuota ()



Gets the target limit for sending messages in the current month. The total number of the free messages and the additional messages is returned.

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
    public class GetMessageQuotaExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);

            try
            {
                MessageQuotaResponse result = apiInstance.GetMessageQuota();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetMessageQuota: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessageQuotaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MessageQuotaResponse> response = apiInstance.GetMessageQuotaWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetMessageQuotaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MessageQuotaResponse**](MessageQuotaResponse.md)

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

<a id="getmessagequotaconsumption"></a>
# **GetMessageQuotaConsumption**
> QuotaConsumptionResponse GetMessageQuotaConsumption ()



Gets the number of messages sent in the current month.

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
    public class GetMessageQuotaConsumptionExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);

            try
            {
                QuotaConsumptionResponse result = apiInstance.GetMessageQuotaConsumption();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetMessageQuotaConsumption: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessageQuotaConsumptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<QuotaConsumptionResponse> response = apiInstance.GetMessageQuotaConsumptionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetMessageQuotaConsumptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**QuotaConsumptionResponse**](QuotaConsumptionResponse.md)

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

<a id="getnarrowcastprogress"></a>
# **GetNarrowcastProgress**
> NarrowcastProgressResponse GetNarrowcastProgress (string requestId)



Gets the status of a narrowcast message.

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
    public class GetNarrowcastProgressExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var requestId = "requestId_example";  // string | The narrowcast message's request ID. Each Messaging API request has a request ID.

            try
            {
                NarrowcastProgressResponse result = apiInstance.GetNarrowcastProgress(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetNarrowcastProgress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNarrowcastProgressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NarrowcastProgressResponse> response = apiInstance.GetNarrowcastProgressWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetNarrowcastProgressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The narrowcast message&#39;s request ID. Each Messaging API request has a request ID. |  |

### Return type

[**NarrowcastProgressResponse**](NarrowcastProgressResponse.md)

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

<a id="getnumberofsentbroadcastmessages"></a>
# **GetNumberOfSentBroadcastMessages**
> NumberOfMessagesResponse GetNumberOfSentBroadcastMessages (string date)



Get number of sent broadcast messages

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
    public class GetNumberOfSentBroadcastMessagesExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var date = "date_example";  // string | Date the messages were sent  Format: yyyyMMdd (e.g. 20191231) Timezone: UTC+9 

            try
            {
                NumberOfMessagesResponse result = apiInstance.GetNumberOfSentBroadcastMessages(date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetNumberOfSentBroadcastMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNumberOfSentBroadcastMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NumberOfMessagesResponse> response = apiInstance.GetNumberOfSentBroadcastMessagesWithHttpInfo(date);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetNumberOfSentBroadcastMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **string** | Date the messages were sent  Format: yyyyMMdd (e.g. 20191231) Timezone: UTC+9  |  |

### Return type

[**NumberOfMessagesResponse**](NumberOfMessagesResponse.md)

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

<a id="getnumberofsentmulticastmessages"></a>
# **GetNumberOfSentMulticastMessages**
> NumberOfMessagesResponse GetNumberOfSentMulticastMessages (string date)



Get number of sent multicast messages

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
    public class GetNumberOfSentMulticastMessagesExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var date = "date_example";  // string | Date the messages were sent  Format: `yyyyMMdd` (e.g. `20191231`) Timezone: UTC+9 

            try
            {
                NumberOfMessagesResponse result = apiInstance.GetNumberOfSentMulticastMessages(date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetNumberOfSentMulticastMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNumberOfSentMulticastMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NumberOfMessagesResponse> response = apiInstance.GetNumberOfSentMulticastMessagesWithHttpInfo(date);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetNumberOfSentMulticastMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **string** | Date the messages were sent  Format: &#x60;yyyyMMdd&#x60; (e.g. &#x60;20191231&#x60;) Timezone: UTC+9  |  |

### Return type

[**NumberOfMessagesResponse**](NumberOfMessagesResponse.md)

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

<a id="getnumberofsentpushmessages"></a>
# **GetNumberOfSentPushMessages**
> NumberOfMessagesResponse GetNumberOfSentPushMessages (string date)



Get number of sent push messages

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
    public class GetNumberOfSentPushMessagesExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var date = "date_example";  // string | Date the messages were sent  Format: `yyyyMMdd` (e.g. `20191231`) Timezone: UTC+9 

            try
            {
                NumberOfMessagesResponse result = apiInstance.GetNumberOfSentPushMessages(date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetNumberOfSentPushMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNumberOfSentPushMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NumberOfMessagesResponse> response = apiInstance.GetNumberOfSentPushMessagesWithHttpInfo(date);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetNumberOfSentPushMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **string** | Date the messages were sent  Format: &#x60;yyyyMMdd&#x60; (e.g. &#x60;20191231&#x60;) Timezone: UTC+9  |  |

### Return type

[**NumberOfMessagesResponse**](NumberOfMessagesResponse.md)

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

<a id="getnumberofsentreplymessages"></a>
# **GetNumberOfSentReplyMessages**
> NumberOfMessagesResponse GetNumberOfSentReplyMessages (string date)



Get number of sent reply messages

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
    public class GetNumberOfSentReplyMessagesExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var date = "date_example";  // string | Date the messages were sent  Format: `yyyyMMdd` (e.g. `20191231`) Timezone: UTC+9 

            try
            {
                NumberOfMessagesResponse result = apiInstance.GetNumberOfSentReplyMessages(date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetNumberOfSentReplyMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNumberOfSentReplyMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NumberOfMessagesResponse> response = apiInstance.GetNumberOfSentReplyMessagesWithHttpInfo(date);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetNumberOfSentReplyMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **string** | Date the messages were sent  Format: &#x60;yyyyMMdd&#x60; (e.g. &#x60;20191231&#x60;) Timezone: UTC+9  |  |

### Return type

[**NumberOfMessagesResponse**](NumberOfMessagesResponse.md)

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

<a id="getpnpmessagestatistics"></a>
# **GetPNPMessageStatistics**
> NumberOfMessagesResponse GetPNPMessageStatistics (string date)



Get number of sent LINE notification messages　

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
    public class GetPNPMessageStatisticsExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var date = "date_example";  // string | Date the message was sent  Format: `yyyyMMdd` (Example:`20211231`) Time zone: UTC+9 

            try
            {
                NumberOfMessagesResponse result = apiInstance.GetPNPMessageStatistics(date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetPNPMessageStatistics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPNPMessageStatisticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NumberOfMessagesResponse> response = apiInstance.GetPNPMessageStatisticsWithHttpInfo(date);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetPNPMessageStatisticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **string** | Date the message was sent  Format: &#x60;yyyyMMdd&#x60; (Example:&#x60;20211231&#x60;) Time zone: UTC+9  |  |

### Return type

[**NumberOfMessagesResponse**](NumberOfMessagesResponse.md)

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

<a id="getprofile"></a>
# **GetProfile**
> UserProfileResponse GetProfile (string userId)



Get profile

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
    public class GetProfileExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // string | User ID

            try
            {
                UserProfileResponse result = apiInstance.GetProfile(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UserProfileResponse> response = apiInstance.GetProfileWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | User ID |  |

### Return type

[**UserProfileResponse**](UserProfileResponse.md)

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

<a id="getrichmenu"></a>
# **GetRichMenu**
> RichMenuResponse GetRichMenu (string richMenuId)



Gets a rich menu via a rich menu ID.

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
    public class GetRichMenuExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuId = "richMenuId_example";  // string | ID of a rich menu

            try
            {
                RichMenuResponse result = apiInstance.GetRichMenu(richMenuId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetRichMenu: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRichMenuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RichMenuResponse> response = apiInstance.GetRichMenuWithHttpInfo(richMenuId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetRichMenuWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuId** | **string** | ID of a rich menu |  |

### Return type

[**RichMenuResponse**](RichMenuResponse.md)

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

<a id="getrichmenualias"></a>
# **GetRichMenuAlias**
> RichMenuAliasResponse GetRichMenuAlias (string richMenuAliasId)



Get rich menu alias information

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
    public class GetRichMenuAliasExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuAliasId = "richMenuAliasId_example";  // string | The rich menu alias ID whose information you want to obtain.

            try
            {
                RichMenuAliasResponse result = apiInstance.GetRichMenuAlias(richMenuAliasId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetRichMenuAlias: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRichMenuAliasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RichMenuAliasResponse> response = apiInstance.GetRichMenuAliasWithHttpInfo(richMenuAliasId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetRichMenuAliasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuAliasId** | **string** | The rich menu alias ID whose information you want to obtain. |  |

### Return type

[**RichMenuAliasResponse**](RichMenuAliasResponse.md)

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

<a id="getrichmenualiaslist"></a>
# **GetRichMenuAliasList**
> RichMenuAliasListResponse GetRichMenuAliasList ()



Get list of rich menu alias

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
    public class GetRichMenuAliasListExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);

            try
            {
                RichMenuAliasListResponse result = apiInstance.GetRichMenuAliasList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetRichMenuAliasList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRichMenuAliasListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RichMenuAliasListResponse> response = apiInstance.GetRichMenuAliasListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetRichMenuAliasListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RichMenuAliasListResponse**](RichMenuAliasListResponse.md)

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

<a id="getrichmenubatchprogress"></a>
# **GetRichMenuBatchProgress**
> RichMenuBatchProgressResponse GetRichMenuBatchProgress (string requestId)



Get the status of Replace or unlink a linked rich menus in batches.

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
    public class GetRichMenuBatchProgressExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var requestId = "requestId_example";  // string | A request ID used to batch control the rich menu linked to the user. Each Messaging API request has a request ID.

            try
            {
                RichMenuBatchProgressResponse result = apiInstance.GetRichMenuBatchProgress(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetRichMenuBatchProgress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRichMenuBatchProgressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RichMenuBatchProgressResponse> response = apiInstance.GetRichMenuBatchProgressWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetRichMenuBatchProgressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | A request ID used to batch control the rich menu linked to the user. Each Messaging API request has a request ID. |  |

### Return type

[**RichMenuBatchProgressResponse**](RichMenuBatchProgressResponse.md)

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

<a id="getrichmenuidofuser"></a>
# **GetRichMenuIdOfUser**
> RichMenuIdResponse GetRichMenuIdOfUser (string userId)



Get rich menu ID of user

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
    public class GetRichMenuIdOfUserExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // string | User ID. Found in the `source` object of webhook event objects. Do not use the LINE ID used in LINE.

            try
            {
                RichMenuIdResponse result = apiInstance.GetRichMenuIdOfUser(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetRichMenuIdOfUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRichMenuIdOfUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RichMenuIdResponse> response = apiInstance.GetRichMenuIdOfUserWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetRichMenuIdOfUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | User ID. Found in the &#x60;source&#x60; object of webhook event objects. Do not use the LINE ID used in LINE. |  |

### Return type

[**RichMenuIdResponse**](RichMenuIdResponse.md)

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

<a id="getrichmenulist"></a>
# **GetRichMenuList**
> RichMenuListResponse GetRichMenuList ()



Get rich menu list

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
    public class GetRichMenuListExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);

            try
            {
                RichMenuListResponse result = apiInstance.GetRichMenuList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetRichMenuList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRichMenuListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RichMenuListResponse> response = apiInstance.GetRichMenuListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetRichMenuListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RichMenuListResponse**](RichMenuListResponse.md)

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

<a id="getroommembercount"></a>
# **GetRoomMemberCount**
> RoomMemberCountResponse GetRoomMemberCount (string roomId)



Get number of users in a multi-person chat

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
    public class GetRoomMemberCountExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var roomId = "roomId_example";  // string | Room ID

            try
            {
                RoomMemberCountResponse result = apiInstance.GetRoomMemberCount(roomId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetRoomMemberCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomMemberCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RoomMemberCountResponse> response = apiInstance.GetRoomMemberCountWithHttpInfo(roomId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetRoomMemberCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **string** | Room ID |  |

### Return type

[**RoomMemberCountResponse**](RoomMemberCountResponse.md)

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

<a id="getroommemberprofile"></a>
# **GetRoomMemberProfile**
> RoomUserProfileResponse GetRoomMemberProfile (string roomId, string userId)



Get multi-person chat member profile

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
    public class GetRoomMemberProfileExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var roomId = "roomId_example";  // string | Room ID
            var userId = "userId_example";  // string | User ID

            try
            {
                RoomUserProfileResponse result = apiInstance.GetRoomMemberProfile(roomId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetRoomMemberProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomMemberProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RoomUserProfileResponse> response = apiInstance.GetRoomMemberProfileWithHttpInfo(roomId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetRoomMemberProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **string** | Room ID |  |
| **userId** | **string** | User ID |  |

### Return type

[**RoomUserProfileResponse**](RoomUserProfileResponse.md)

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

<a id="getroommembersids"></a>
# **GetRoomMembersIds**
> MembersIdsResponse GetRoomMembersIds (string roomId, string start = null)



Get multi-person chat member user IDs

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
    public class GetRoomMembersIdsExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var roomId = "roomId_example";  // string | Room ID
            var start = "start_example";  // string | Value of the continuation token found in the `next` property of the JSON object returned in the response. Include this parameter to get the next array of user IDs for the members of the group.  (optional) 

            try
            {
                MembersIdsResponse result = apiInstance.GetRoomMembersIds(roomId, start);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetRoomMembersIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomMembersIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MembersIdsResponse> response = apiInstance.GetRoomMembersIdsWithHttpInfo(roomId, start);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetRoomMembersIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **string** | Room ID |  |
| **start** | **string** | Value of the continuation token found in the &#x60;next&#x60; property of the JSON object returned in the response. Include this parameter to get the next array of user IDs for the members of the group.  | [optional]  |

### Return type

[**MembersIdsResponse**](MembersIdsResponse.md)

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

<a id="getwebhookendpoint"></a>
# **GetWebhookEndpoint**
> GetWebhookEndpointResponse GetWebhookEndpoint ()



Get webhook endpoint information

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
    public class GetWebhookEndpointExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);

            try
            {
                GetWebhookEndpointResponse result = apiInstance.GetWebhookEndpoint();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.GetWebhookEndpoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebhookEndpointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetWebhookEndpointResponse> response = apiInstance.GetWebhookEndpointWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.GetWebhookEndpointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetWebhookEndpointResponse**](GetWebhookEndpointResponse.md)

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

<a id="issuelinktoken"></a>
# **IssueLinkToken**
> IssueLinkTokenResponse IssueLinkToken (string userId)



Issue link token

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
    public class IssueLinkTokenExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // string | User ID for the LINE account to be linked. Found in the `source` object of account link event objects. Do not use the LINE ID used in LINE. 

            try
            {
                IssueLinkTokenResponse result = apiInstance.IssueLinkToken(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.IssueLinkToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueLinkTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IssueLinkTokenResponse> response = apiInstance.IssueLinkTokenWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.IssueLinkTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | User ID for the LINE account to be linked. Found in the &#x60;source&#x60; object of account link event objects. Do not use the LINE ID used in LINE.  |  |

### Return type

[**IssueLinkTokenResponse**](IssueLinkTokenResponse.md)

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

<a id="leavegroup"></a>
# **LeaveGroup**
> void LeaveGroup (string groupId)



Leave group chat

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
    public class LeaveGroupExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var groupId = "groupId_example";  // string | Group ID

            try
            {
                apiInstance.LeaveGroup(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.LeaveGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LeaveGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.LeaveGroupWithHttpInfo(groupId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.LeaveGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | Group ID |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="leaveroom"></a>
# **LeaveRoom**
> void LeaveRoom (string roomId)



Leave multi-person chat

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
    public class LeaveRoomExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var roomId = "roomId_example";  // string | Room ID

            try
            {
                apiInstance.LeaveRoom(roomId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.LeaveRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LeaveRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.LeaveRoomWithHttpInfo(roomId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.LeaveRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **string** | Room ID |  |

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

<a id="linkrichmenuidtouser"></a>
# **LinkRichMenuIdToUser**
> void LinkRichMenuIdToUser (string userId, string richMenuId)



Link rich menu to user.

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
    public class LinkRichMenuIdToUserExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // string | User ID. Found in the `source` object of webhook event objects. Do not use the LINE ID used in LINE.
            var richMenuId = "richMenuId_example";  // string | ID of a rich menu

            try
            {
                apiInstance.LinkRichMenuIdToUser(userId, richMenuId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.LinkRichMenuIdToUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkRichMenuIdToUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.LinkRichMenuIdToUserWithHttpInfo(userId, richMenuId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.LinkRichMenuIdToUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | User ID. Found in the &#x60;source&#x60; object of webhook event objects. Do not use the LINE ID used in LINE. |  |
| **richMenuId** | **string** | ID of a rich menu |  |

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

<a id="linkrichmenuidtousers"></a>
# **LinkRichMenuIdToUsers**
> void LinkRichMenuIdToUsers (RichMenuBulkLinkRequest richMenuBulkLinkRequest)



Link rich menu to multiple users

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
    public class LinkRichMenuIdToUsersExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuBulkLinkRequest = new RichMenuBulkLinkRequest(); // RichMenuBulkLinkRequest | 

            try
            {
                apiInstance.LinkRichMenuIdToUsers(richMenuBulkLinkRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.LinkRichMenuIdToUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkRichMenuIdToUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.LinkRichMenuIdToUsersWithHttpInfo(richMenuBulkLinkRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.LinkRichMenuIdToUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuBulkLinkRequest** | [**RichMenuBulkLinkRequest**](RichMenuBulkLinkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="markmessagesasread"></a>
# **MarkMessagesAsRead**
> void MarkMessagesAsRead (MarkMessagesAsReadRequest markMessagesAsReadRequest)



Mark messages from users as read

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
    public class MarkMessagesAsReadExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var markMessagesAsReadRequest = new MarkMessagesAsReadRequest(); // MarkMessagesAsReadRequest | 

            try
            {
                apiInstance.MarkMessagesAsRead(markMessagesAsReadRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.MarkMessagesAsRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarkMessagesAsReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MarkMessagesAsReadWithHttpInfo(markMessagesAsReadRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.MarkMessagesAsReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **markMessagesAsReadRequest** | [**MarkMessagesAsReadRequest**](MarkMessagesAsReadRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="multicast"></a>
# **Multicast**
> Object Multicast (MulticastRequest multicastRequest, Guid? xLineRetryKey = null)



An API that efficiently sends the same message to multiple user IDs. You can't send messages to group chats or multi-person chats.

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
    public class MulticastExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var multicastRequest = new MulticastRequest(); // MulticastRequest | 
            var xLineRetryKey = "xLineRetryKey_example";  // Guid? | Retry key. Specifies the UUID in hexadecimal format (e.g., `123e4567-e89b-12d3-a456-426614174000`) generated by any method. The retry key isn't generated by LINE. Each developer must generate their own retry key.  (optional) 

            try
            {
                Object result = apiInstance.Multicast(multicastRequest, xLineRetryKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.Multicast: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MulticastWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.MulticastWithHttpInfo(multicastRequest, xLineRetryKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.MulticastWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **multicastRequest** | [**MulticastRequest**](MulticastRequest.md) |  |  |
| **xLineRetryKey** | **Guid?** | Retry key. Specifies the UUID in hexadecimal format (e.g., &#x60;123e4567-e89b-12d3-a456-426614174000&#x60;) generated by any method. The retry key isn&#39;t generated by LINE. Each developer must generate their own retry key.  | [optional]  |

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="narrowcast"></a>
# **Narrowcast**
> Object Narrowcast (NarrowcastRequest narrowcastRequest, Guid? xLineRetryKey = null)



Send narrowcast message

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
    public class NarrowcastExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var narrowcastRequest = new NarrowcastRequest(); // NarrowcastRequest | 
            var xLineRetryKey = "xLineRetryKey_example";  // Guid? | Retry key. Specifies the UUID in hexadecimal format (e.g., `123e4567-e89b-12d3-a456-426614174000`) generated by any method. The retry key isn't generated by LINE. Each developer must generate their own retry key.  (optional) 

            try
            {
                Object result = apiInstance.Narrowcast(narrowcastRequest, xLineRetryKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.Narrowcast: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NarrowcastWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.NarrowcastWithHttpInfo(narrowcastRequest, xLineRetryKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.NarrowcastWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **narrowcastRequest** | [**NarrowcastRequest**](NarrowcastRequest.md) |  |  |
| **xLineRetryKey** | **Guid?** | Retry key. Specifies the UUID in hexadecimal format (e.g., &#x60;123e4567-e89b-12d3-a456-426614174000&#x60;) generated by any method. The retry key isn&#39;t generated by LINE. Each developer must generate their own retry key.  | [optional]  |

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pushmessage"></a>
# **PushMessage**
> PushMessageResponse PushMessage (PushMessageRequest pushMessageRequest, Guid? xLineRetryKey = null)



Sends a message to a user, group chat, or multi-person chat at any time.

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
    public class PushMessageExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var pushMessageRequest = new PushMessageRequest(); // PushMessageRequest | 
            var xLineRetryKey = "xLineRetryKey_example";  // Guid? | Retry key. Specifies the UUID in hexadecimal format (e.g., `123e4567-e89b-12d3-a456-426614174000`) generated by any method. The retry key isn't generated by LINE. Each developer must generate their own retry key.  (optional) 

            try
            {
                PushMessageResponse result = apiInstance.PushMessage(pushMessageRequest, xLineRetryKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.PushMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PushMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PushMessageResponse> response = apiInstance.PushMessageWithHttpInfo(pushMessageRequest, xLineRetryKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.PushMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pushMessageRequest** | [**PushMessageRequest**](PushMessageRequest.md) |  |  |
| **xLineRetryKey** | **Guid?** | Retry key. Specifies the UUID in hexadecimal format (e.g., &#x60;123e4567-e89b-12d3-a456-426614174000&#x60;) generated by any method. The retry key isn&#39;t generated by LINE. Each developer must generate their own retry key.  | [optional]  |

### Return type

[**PushMessageResponse**](PushMessageResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pushmessagesbyphone"></a>
# **PushMessagesByPhone**
> void PushMessagesByPhone (PnpMessagesRequest pnpMessagesRequest, string xLineDeliveryTag = null)



Send LINE notification message

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
    public class PushMessagesByPhoneExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var pnpMessagesRequest = new PnpMessagesRequest(); // PnpMessagesRequest | 
            var xLineDeliveryTag = "xLineDeliveryTag_example";  // string | String returned in the delivery.data property of the delivery completion event via Webhook. (optional) 

            try
            {
                apiInstance.PushMessagesByPhone(pnpMessagesRequest, xLineDeliveryTag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.PushMessagesByPhone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PushMessagesByPhoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PushMessagesByPhoneWithHttpInfo(pnpMessagesRequest, xLineDeliveryTag);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.PushMessagesByPhoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pnpMessagesRequest** | [**PnpMessagesRequest**](PnpMessagesRequest.md) |  |  |
| **xLineDeliveryTag** | **string** | String returned in the delivery.data property of the delivery completion event via Webhook. | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="replymessage"></a>
# **ReplyMessage**
> ReplyMessageResponse ReplyMessage (ReplyMessageRequest replyMessageRequest)



Send reply message

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
    public class ReplyMessageExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var replyMessageRequest = new ReplyMessageRequest(); // ReplyMessageRequest | 

            try
            {
                ReplyMessageResponse result = apiInstance.ReplyMessage(replyMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.ReplyMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplyMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ReplyMessageResponse> response = apiInstance.ReplyMessageWithHttpInfo(replyMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.ReplyMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **replyMessageRequest** | [**ReplyMessageRequest**](ReplyMessageRequest.md) |  |  |

### Return type

[**ReplyMessageResponse**](ReplyMessageResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="richmenubatch"></a>
# **RichMenuBatch**
> void RichMenuBatch (RichMenuBatchRequest richMenuBatchRequest)



You can use this endpoint to batch control the rich menu linked to the users using the endpoint such as Link rich menu to user. The following operations are available:  1. Replace a rich menu with another rich menu for all users linked to a specific rich menu 2. Unlink a rich menu for all users linked to a specific rich menu 3. Unlink a rich menu for all users linked the rich menu 

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
    public class RichMenuBatchExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuBatchRequest = new RichMenuBatchRequest(); // RichMenuBatchRequest | 

            try
            {
                apiInstance.RichMenuBatch(richMenuBatchRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.RichMenuBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RichMenuBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.RichMenuBatchWithHttpInfo(richMenuBatchRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.RichMenuBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuBatchRequest** | [**RichMenuBatchRequest**](RichMenuBatchRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setdefaultrichmenu"></a>
# **SetDefaultRichMenu**
> void SetDefaultRichMenu (string richMenuId)



Set default rich menu

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
    public class SetDefaultRichMenuExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuId = "richMenuId_example";  // string | ID of a rich menu

            try
            {
                apiInstance.SetDefaultRichMenu(richMenuId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.SetDefaultRichMenu: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetDefaultRichMenuWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetDefaultRichMenuWithHttpInfo(richMenuId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.SetDefaultRichMenuWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuId** | **string** | ID of a rich menu |  |

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

<a id="setwebhookendpoint"></a>
# **SetWebhookEndpoint**
> void SetWebhookEndpoint (SetWebhookEndpointRequest setWebhookEndpointRequest)



Set webhook endpoint URL

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
    public class SetWebhookEndpointExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var setWebhookEndpointRequest = new SetWebhookEndpointRequest(); // SetWebhookEndpointRequest | 

            try
            {
                apiInstance.SetWebhookEndpoint(setWebhookEndpointRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.SetWebhookEndpoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetWebhookEndpointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetWebhookEndpointWithHttpInfo(setWebhookEndpointRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.SetWebhookEndpointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setWebhookEndpointRequest** | [**SetWebhookEndpointRequest**](SetWebhookEndpointRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="showloadinganimation"></a>
# **ShowLoadingAnimation**
> Object ShowLoadingAnimation (ShowLoadingAnimationRequest showLoadingAnimationRequest)



Display a loading animation in one-on-one chats between users and LINE Official Accounts.

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
    public class ShowLoadingAnimationExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var showLoadingAnimationRequest = new ShowLoadingAnimationRequest(); // ShowLoadingAnimationRequest | 

            try
            {
                Object result = apiInstance.ShowLoadingAnimation(showLoadingAnimationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.ShowLoadingAnimation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShowLoadingAnimationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ShowLoadingAnimationWithHttpInfo(showLoadingAnimationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.ShowLoadingAnimationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **showLoadingAnimationRequest** | [**ShowLoadingAnimationRequest**](ShowLoadingAnimationRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | An invalid chat ID is specified, or the loadingSeconds value is invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="testwebhookendpoint"></a>
# **TestWebhookEndpoint**
> TestWebhookEndpointResponse TestWebhookEndpoint (TestWebhookEndpointRequest testWebhookEndpointRequest = null)



Test webhook endpoint

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
    public class TestWebhookEndpointExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var testWebhookEndpointRequest = new TestWebhookEndpointRequest(); // TestWebhookEndpointRequest |  (optional) 

            try
            {
                TestWebhookEndpointResponse result = apiInstance.TestWebhookEndpoint(testWebhookEndpointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.TestWebhookEndpoint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestWebhookEndpointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TestWebhookEndpointResponse> response = apiInstance.TestWebhookEndpointWithHttpInfo(testWebhookEndpointRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.TestWebhookEndpointWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **testWebhookEndpointRequest** | [**TestWebhookEndpointRequest**](TestWebhookEndpointRequest.md) |  | [optional]  |

### Return type

[**TestWebhookEndpointResponse**](TestWebhookEndpointResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unlinkrichmenuidfromuser"></a>
# **UnlinkRichMenuIdFromUser**
> void UnlinkRichMenuIdFromUser (string userId)



Unlink rich menu from user

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
    public class UnlinkRichMenuIdFromUserExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var userId = "userId_example";  // string | User ID. Found in the `source` object of webhook event objects. Do not use the LINE ID used in LINE.

            try
            {
                apiInstance.UnlinkRichMenuIdFromUser(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.UnlinkRichMenuIdFromUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnlinkRichMenuIdFromUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UnlinkRichMenuIdFromUserWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.UnlinkRichMenuIdFromUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** | User ID. Found in the &#x60;source&#x60; object of webhook event objects. Do not use the LINE ID used in LINE. |  |

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

<a id="unlinkrichmenuidfromusers"></a>
# **UnlinkRichMenuIdFromUsers**
> void UnlinkRichMenuIdFromUsers (RichMenuBulkUnlinkRequest richMenuBulkUnlinkRequest)



Unlink rich menus from multiple users

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
    public class UnlinkRichMenuIdFromUsersExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuBulkUnlinkRequest = new RichMenuBulkUnlinkRequest(); // RichMenuBulkUnlinkRequest | 

            try
            {
                apiInstance.UnlinkRichMenuIdFromUsers(richMenuBulkUnlinkRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.UnlinkRichMenuIdFromUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnlinkRichMenuIdFromUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UnlinkRichMenuIdFromUsersWithHttpInfo(richMenuBulkUnlinkRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.UnlinkRichMenuIdFromUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuBulkUnlinkRequest** | [**RichMenuBulkUnlinkRequest**](RichMenuBulkUnlinkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updaterichmenualias"></a>
# **UpdateRichMenuAlias**
> void UpdateRichMenuAlias (string richMenuAliasId, UpdateRichMenuAliasRequest updateRichMenuAliasRequest)



Update rich menu alias

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
    public class UpdateRichMenuAliasExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuAliasId = "richMenuAliasId_example";  // string | The rich menu alias ID you want to update.
            var updateRichMenuAliasRequest = new UpdateRichMenuAliasRequest(); // UpdateRichMenuAliasRequest | 

            try
            {
                apiInstance.UpdateRichMenuAlias(richMenuAliasId, updateRichMenuAliasRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.UpdateRichMenuAlias: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRichMenuAliasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UpdateRichMenuAliasWithHttpInfo(richMenuAliasId, updateRichMenuAliasRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.UpdateRichMenuAliasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuAliasId** | **string** | The rich menu alias ID you want to update. |  |
| **updateRichMenuAliasRequest** | [**UpdateRichMenuAliasRequest**](UpdateRichMenuAliasRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="validatebroadcast"></a>
# **ValidateBroadcast**
> void ValidateBroadcast (ValidateMessageRequest validateMessageRequest)



Validate message objects of a broadcast message

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
    public class ValidateBroadcastExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var validateMessageRequest = new ValidateMessageRequest(); // ValidateMessageRequest | 

            try
            {
                apiInstance.ValidateBroadcast(validateMessageRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.ValidateBroadcast: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateBroadcastWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ValidateBroadcastWithHttpInfo(validateMessageRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.ValidateBroadcastWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validateMessageRequest** | [**ValidateMessageRequest**](ValidateMessageRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="validatemulticast"></a>
# **ValidateMulticast**
> void ValidateMulticast (ValidateMessageRequest validateMessageRequest)



Validate message objects of a multicast message

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
    public class ValidateMulticastExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var validateMessageRequest = new ValidateMessageRequest(); // ValidateMessageRequest | 

            try
            {
                apiInstance.ValidateMulticast(validateMessageRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.ValidateMulticast: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateMulticastWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ValidateMulticastWithHttpInfo(validateMessageRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.ValidateMulticastWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validateMessageRequest** | [**ValidateMessageRequest**](ValidateMessageRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="validatenarrowcast"></a>
# **ValidateNarrowcast**
> void ValidateNarrowcast (ValidateMessageRequest validateMessageRequest)



Validate message objects of a narrowcast message

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
    public class ValidateNarrowcastExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var validateMessageRequest = new ValidateMessageRequest(); // ValidateMessageRequest | 

            try
            {
                apiInstance.ValidateNarrowcast(validateMessageRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.ValidateNarrowcast: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateNarrowcastWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ValidateNarrowcastWithHttpInfo(validateMessageRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.ValidateNarrowcastWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validateMessageRequest** | [**ValidateMessageRequest**](ValidateMessageRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="validatepush"></a>
# **ValidatePush**
> void ValidatePush (ValidateMessageRequest validateMessageRequest)



Validate message objects of a push message

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
    public class ValidatePushExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var validateMessageRequest = new ValidateMessageRequest(); // ValidateMessageRequest | 

            try
            {
                apiInstance.ValidatePush(validateMessageRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.ValidatePush: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidatePushWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ValidatePushWithHttpInfo(validateMessageRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.ValidatePushWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validateMessageRequest** | [**ValidateMessageRequest**](ValidateMessageRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="validatereply"></a>
# **ValidateReply**
> void ValidateReply (ValidateMessageRequest validateMessageRequest)



Validate message objects of a reply message

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
    public class ValidateReplyExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var validateMessageRequest = new ValidateMessageRequest(); // ValidateMessageRequest | 

            try
            {
                apiInstance.ValidateReply(validateMessageRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.ValidateReply: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateReplyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ValidateReplyWithHttpInfo(validateMessageRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.ValidateReplyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validateMessageRequest** | [**ValidateMessageRequest**](ValidateMessageRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="validaterichmenubatchrequest"></a>
# **ValidateRichMenuBatchRequest**
> void ValidateRichMenuBatchRequest (RichMenuBatchRequest richMenuBatchRequest)



Validate a request body of the Replace or unlink the linked rich menus in batches endpoint.

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
    public class ValidateRichMenuBatchRequestExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuBatchRequest = new RichMenuBatchRequest(); // RichMenuBatchRequest | 

            try
            {
                apiInstance.ValidateRichMenuBatchRequest(richMenuBatchRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.ValidateRichMenuBatchRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateRichMenuBatchRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ValidateRichMenuBatchRequestWithHttpInfo(richMenuBatchRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.ValidateRichMenuBatchRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuBatchRequest** | [**RichMenuBatchRequest**](RichMenuBatchRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="validaterichmenuobject"></a>
# **ValidateRichMenuObject**
> void ValidateRichMenuObject (RichMenuRequest richMenuRequest)



Validate rich menu object

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
    public class ValidateRichMenuObjectExample
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
            var apiInstance = new MessagingApiApi(httpClient, config, httpClientHandler);
            var richMenuRequest = new RichMenuRequest(); // RichMenuRequest | 

            try
            {
                apiInstance.ValidateRichMenuObject(richMenuRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApiApi.ValidateRichMenuObject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateRichMenuObjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ValidateRichMenuObjectWithHttpInfo(richMenuRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApiApi.ValidateRichMenuObjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **richMenuRequest** | [**RichMenuRequest**](RichMenuRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


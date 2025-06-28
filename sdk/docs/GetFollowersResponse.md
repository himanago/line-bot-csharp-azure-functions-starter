# LineOpenApi.MessagingApi.Model.GetFollowersResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserIds** | **List&lt;string&gt;** | An array of strings indicating user IDs of users that have added the LINE Official Account as a friend. Only users of LINE for iOS and LINE for Android are included in &#x60;userIds&#x60;.  | 
**Next** | **string** | A continuation token to get the next array of user IDs. Returned only when there are remaining user IDs that weren&#39;t returned in &#x60;userIds&#x60; in the original request. The number of user IDs in the &#x60;userIds&#x60; element doesn&#39;t have to reach the maximum number specified by &#x60;limit&#x60; for the &#x60;next&#x60; property to be included in the response.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


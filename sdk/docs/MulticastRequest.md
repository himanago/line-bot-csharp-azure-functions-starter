# LineOpenApi.MessagingApi.Model.MulticastRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Messages** | [**List&lt;Message&gt;**](Message.md) | Messages to send | 
**To** | **List&lt;string&gt;** | Array of user IDs. Use userId values which are returned in webhook event objects. Do not use LINE IDs found on LINE. | 
**NotificationDisabled** | **bool** | &#x60;true&#x60;: The user doesn’t receive a push notification when a message is sent. &#x60;false&#x60;: The user receives a push notification when the message is sent (unless they have disabled push notifications in LINE and/or their device). The default value is false.  | [optional] [default to false]
**CustomAggregationUnits** | **List&lt;string&gt;** | Name of aggregation unit. Case-sensitive. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


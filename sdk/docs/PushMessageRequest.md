# LineOpenApi.MessagingApi.Model.PushMessageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | **string** | ID of the receiver. | 
**Messages** | [**List&lt;Message&gt;**](Message.md) | List of Message objects. | 
**NotificationDisabled** | **bool** | &#x60;true&#x60;: The user doesn’t receive a push notification when a message is sent. &#x60;false&#x60;: The user receives a push notification when the message is sent (unless they have disabled push notifications in LINE and/or their device). The default value is false.  | [optional] [default to false]
**CustomAggregationUnits** | **List&lt;string&gt;** | List of aggregation unit name. Case-sensitive. This functions can only be used by corporate users who have submitted the required applications.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


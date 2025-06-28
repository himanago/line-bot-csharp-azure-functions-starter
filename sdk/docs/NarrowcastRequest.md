# LineOpenApi.MessagingApi.Model.NarrowcastRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Messages** | [**List&lt;Message&gt;**](Message.md) | List of Message objects. | 
**Recipient** | [**Recipient**](Recipient.md) |  | [optional] 
**Filter** | [**Filter**](Filter.md) |  | [optional] 
**Limit** | [**Limit**](Limit.md) |  | [optional] 
**NotificationDisabled** | **bool** | &#x60;true&#x60;: The user doesn’t receive a push notification when a message is sent. &#x60;false&#x60;: The user receives a push notification when the message is sent (unless they have disabled push notifications in LINE and/or their device). The default value is false.  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


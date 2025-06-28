# LineOpenApi.MessagingApi.Model.PnpMessagesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Messages** | [**List&lt;Message&gt;**](Message.md) | Message to be sent. | 
**To** | **string** | Message destination. Specify a phone number that has been normalized to E.164 format and hashed with SHA256. | 
**NotificationDisabled** | **bool** | &#x60;true&#x60;: The user doesn’t receive a push notification when a message is sent. &#x60;false&#x60;: The user receives a push notification when the message is sent (unless they have disabled push notifications in LINE and/or their device). The default value is false.  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


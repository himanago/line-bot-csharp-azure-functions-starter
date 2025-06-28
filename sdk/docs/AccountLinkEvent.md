# LineOpenApi.Webhook.Model.AccountLinkEvent
Event object for when a user has linked their LINE account with a provider's service account. You can reply to account link events.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the event | 
**Source** | [**Source**](Source.md) |  | [optional] 
**Timestamp** | **long** | Time of the event in milliseconds. | 
**Mode** | **EventMode** |  | 
**WebhookEventId** | **string** | Webhook Event ID. An ID that uniquely identifies a webhook event. This is a string in ULID format. | 
**DeliveryContext** | [**DeliveryContext**](DeliveryContext.md) |  | 
**ReplyToken** | **string** | Reply token used to send reply message to this event. This property won&#39;t be included if linking the account has failed. | [optional] 
**Link** | [**LinkContent**](LinkContent.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


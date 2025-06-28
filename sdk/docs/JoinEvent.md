# LineOpenApi.Webhook.Model.JoinEvent
Event object for when your LINE Official Account joins a group chat or multi-person chat. You can reply to join events.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the event | 
**Source** | [**Source**](Source.md) |  | [optional] 
**Timestamp** | **long** | Time of the event in milliseconds. | 
**Mode** | **EventMode** |  | 
**WebhookEventId** | **string** | Webhook Event ID. An ID that uniquely identifies a webhook event. This is a string in ULID format. | 
**DeliveryContext** | [**DeliveryContext**](DeliveryContext.md) |  | 
**ReplyToken** | **string** | Reply token used to send reply message to this event | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


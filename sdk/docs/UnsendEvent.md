# LineOpenApi.Webhook.Model.UnsendEvent
Event object for when the user unsends a message.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the event | 
**Source** | [**Source**](Source.md) |  | [optional] 
**Timestamp** | **long** | Time of the event in milliseconds. | 
**Mode** | **EventMode** |  | 
**WebhookEventId** | **string** | Webhook Event ID. An ID that uniquely identifies a webhook event. This is a string in ULID format. | 
**DeliveryContext** | [**DeliveryContext**](DeliveryContext.md) |  | 
**Unsend** | [**UnsendDetail**](UnsendDetail.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


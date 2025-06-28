# LineOpenApi.Webhook.Model.TextMessageContent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type | 
**Id** | **string** | Message ID | 
**Text** | **string** | Message text. | 
**Emojis** | [**List&lt;Emoji&gt;**](Emoji.md) | Array of one or more LINE emoji objects. Only included in the message event when the text property contains a LINE emoji. | [optional] 
**Mention** | [**Mention**](Mention.md) |  | [optional] 
**QuoteToken** | **string** | Quote token to quote this message.  | 
**QuotedMessageId** | **string** | Message ID of a quoted message. Only included when the received message quotes a past message. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# LineOpenApi.Webhook.Model.StickerMessageContent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type | 
**Id** | **string** | Message ID | 
**PackageId** | **string** | Package ID | 
**StickerId** | **string** | Sticker ID | 
**StickerResourceType** | **string** |  | 
**Keywords** | **List&lt;string&gt;** | Array of up to 15 keywords describing the sticker. If a sticker has 16 or more keywords, a random selection of 15 keywords will be returned. The keyword selection is random for each event, so different keywords may be returned for the same sticker.  | [optional] 
**Text** | **string** | Any text entered by the user. This property is only included for message stickers. Max character limit: 100  | [optional] 
**QuoteToken** | **string** | Quote token to quote this message.  | 
**QuotedMessageId** | **string** | Message ID of a quoted message. Only included when the received message quotes a past message.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


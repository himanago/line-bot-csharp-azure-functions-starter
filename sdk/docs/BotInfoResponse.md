# LineOpenApi.MessagingApi.Model.BotInfoResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | Bot&#39;s user ID | 
**BasicId** | **string** | Bot&#39;s basic ID | 
**PremiumId** | **string** | Bot&#39;s premium ID. Not included in the response if the premium ID isn&#39;t set. | [optional] 
**DisplayName** | **string** | Bot&#39;s display name | 
**PictureUrl** | **string** | Profile image URL. &#x60;https&#x60; image URL. Not included in the response if the bot doesn&#39;t have a profile image. | [optional] 
**ChatMode** | **string** | Chat settings set in the LINE Official Account Manager. One of:  &#x60;chat&#x60;: Chat is set to \&quot;On\&quot;. &#x60;bot&#x60;: Chat is set to \&quot;Off\&quot;.  | 
**MarkAsReadMode** | **string** | Automatic read setting for messages. If the chat is set to \&quot;Off\&quot;, auto is returned. If the chat is set to \&quot;On\&quot;, manual is returned.  &#x60;auto&#x60;: Auto read setting is enabled. &#x60;manual&#x60;: Auto read setting is disabled.   | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


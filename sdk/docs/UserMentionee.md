# LineOpenApi.Webhook.Model.UserMentionee
Mentioned target is user

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Mentioned target. | 
**Index** | **int** | Index position of the user mention for a character in text, with the first character being at position 0. | 
**Length** | **int** | The length of the text of the mentioned user. For a mention @example, 8 is the length. | 
**UserId** | **string** | User ID of the mentioned user. Only included if mention.mentions[].type is user and the user consents to the LINE Official Account obtaining their user profile information. | [optional] 
**IsSelf** | **bool** | Whether the mentioned user is the bot that receives the webhook. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


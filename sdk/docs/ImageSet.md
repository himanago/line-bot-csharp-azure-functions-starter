# LineOpenApi.Webhook.Model.ImageSet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Image set ID. Only included when multiple images are sent simultaneously. | 
**Index** | **int** | An index starting from 1, indicating the image number in a set of images sent simultaneously. Only included when multiple images are sent simultaneously. However, it won&#39;t be included if the sender is using LINE 11.15 or earlier for Android. | [optional] 
**Total** | **int** | The total number of images sent simultaneously. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


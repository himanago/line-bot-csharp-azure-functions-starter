# LineOpenApi.MessagingApi.Model.Limit
Limit of the Narrowcast

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Max** | **int** | The maximum number of narrowcast messages to send. Use this parameter to limit the number of narrowcast messages sent. The recipients will be chosen at random.  | [optional] 
**UpToRemainingQuota** | **bool** | If true, the message will be sent within the maximum number of deliverable messages. The default value is &#x60;false&#x60;.  Targets will be selected at random.  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


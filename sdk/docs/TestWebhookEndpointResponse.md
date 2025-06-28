# LineOpenApi.MessagingApi.Model.TestWebhookEndpointResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | Result of the communication from the LINE platform to the webhook URL. | [optional] 
**Timestamp** | **DateTime** | Time of the event in milliseconds. Even in the case of a redelivered webhook, it represents the time the event occurred, not the time it was redelivered.  | 
**StatusCode** | **int** | The HTTP status code. If the webhook response isn&#39;t received, the status code is set to zero or a negative number. | 
**Reason** | **string** | Reason for the response. | 
**Detail** | **string** | Details of the response. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


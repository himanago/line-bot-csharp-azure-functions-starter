# LineOpenApi.Webhook.Model.ScenarioResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenarioId** | **string** | Scenario ID executed | [optional] 
**Revision** | **int** | Revision number of the scenario set containing the executed scenario | [optional] 
**StartTime** | **long** | Timestamp for when execution of scenario action started (milliseconds, LINE app time) | 
**EndTime** | **long** | Timestamp for when execution of scenario was completed (milliseconds, LINE app time) | 
**ResultCode** | **string** | Scenario execution completion status | 
**ActionResults** | [**List&lt;ActionResult&gt;**](ActionResult.md) | Execution result of individual operations specified in action. Only included when things.result.resultCode is success. | [optional] 
**BleNotificationPayload** | **string** | Data contained in notification. | [optional] 
**ErrorReason** | **string** | Error reason. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


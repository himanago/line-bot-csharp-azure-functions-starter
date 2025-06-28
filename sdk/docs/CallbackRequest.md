# LineOpenApi.Webhook.Model.CallbackRequest
The request body contains a JSON object with the user ID of a bot that should receive webhook events and an array of webhook event objects. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Destination** | **string** | User ID of a bot that should receive webhook events. The user ID value is a string that matches the regular expression, &#x60;U[0-9a-f]{32}&#x60;.  | 
**Events** | [**List&lt;Event&gt;**](Event.md) | Array of webhook event objects. The LINE Platform may send an empty array that doesn&#39;t include a webhook event object to confirm communication.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


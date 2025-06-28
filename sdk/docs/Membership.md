# LineOpenApi.MessagingApi.Model.Membership

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MembershipId** | **int** | Membership plan ID. | 
**Title** | **string** | Membership plan name. | 
**Description** | **string** | Membership plan description. | 
**Benefits** | **List&lt;string&gt;** | List of membership plan perks. | 
**Price** | **double** | Monthly fee for membership plan. (e.g. 1500.00) | 
**Currency** | **string** | The currency of membership.price. | 
**MemberCount** | **int** | Number of members subscribed to the membership plan. | 
**MemberLimit** | **int?** | The upper limit of members who can subscribe. If no upper limit is set, it will be null. | 
**IsInAppPurchase** | **bool** | Payment method for users who subscribe to a membership plan. | 
**IsPublished** | **bool** | Membership plan status. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# LineOpenApi.MessagingApi.Model.SubscribedMembershipUser
Object containing user membership subscription information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MembershipNo** | **int** | The user&#39;s member number in the membership plan. | 
**JoinedTime** | **int** | UNIX timestamp at which the user subscribed to the membership. | 
**NextBillingDate** | **string** | Next payment date for membership plan. - Format: yyyy-MM-dd (e.g. 2024-02-08) - Timezone: UTC+9  | 
**TotalSubscriptionMonths** | **int** | The period of time in months that the user has been subscribed to a membership plan. If a user previously canceled and then re-subscribed to the same membership plan, only the period after the re-subscription will be counted. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


param name string
param location string = resourceGroup().location
param tags object = {}

param applicationInsightsName string = ''
param appServicePlanName string
param keyVaultName string
param storageAccountName string
param functionAppAdditionalAppSettings array = []
param lineChannelAccessToken string

var lineChannelAccessTokenSecretName = 'line-channel-access-token'

// User-assigned managed identity
resource userAssignedIdentity 'Microsoft.ManagedIdentity/userAssignedIdentities@2023-01-31' = {
  name: '${name}-identity'
  location: location
  tags: tags
}

var functionAppCoreAppSettings = [
  {
    name: 'AzureWebJobsStorage'
    value: 'DefaultEndpointsProtocol=https;AccountName=${storageAccountName};EndpointSuffix=${environment().suffixes.storage};AccountKey=${storageAccount.listKeys().keys[0].value}'
  }
  {
    name: 'WEBSITE_CONTENTAZUREFILECONNECTIONSTRING'
    value: 'DefaultEndpointsProtocol=https;AccountName=${storageAccountName};EndpointSuffix=${environment().suffixes.storage};AccountKey=${storageAccount.listKeys().keys[0].value}'
  }
  {
    name: 'FUNCTIONS_EXTENSION_VERSION'
    value: '~4'
  }
  {
    name: 'FUNCTIONS_WORKER_RUNTIME'
    value: 'dotnet-isolated'
  }
  {
    name: 'WEBSITE_USE_PLACEHOLDER_DOTNETISOLATED'
    value: '1'
  }
  {
    name: 'APPLICATIONINSIGHTS_CONNECTION_STRING'
    value: applicationInsights.properties.ConnectionString
  }
  {
    name: 'AZURE_KEY_VAULT_ENDPOINT'
    value: keyVault.properties.vaultUri
  }
  {
    name: 'CHANNEL_ACCESS_TOKEN'
    value: '@Microsoft.KeyVault(VaultName=${keyVaultName};SecretName=${lineChannelAccessTokenSecretName})'
  }
  {
    name: 'AZURE_CLIENT_ID'
    value: userAssignedIdentity.properties.clientId
  }
]
var functionAppAppSettings = length(functionAppAdditionalAppSettings) == 0 ? functionAppCoreAppSettings : concat(functionAppCoreAppSettings,functionAppAdditionalAppSettings)


// App Service Plan
resource appServicePlan 'Microsoft.Web/serverfarms@2022-03-01' = {
  name: appServicePlanName
  location: location
  tags: tags
  sku: {
    name: 'Y1'
    tier: 'Dynamic'
  }
  properties: {}
}

// Function App
resource functionApp 'Microsoft.Web/sites@2022-03-01' = {
  name: name
  location: location
  kind: 'functionapp'
  tags: union(tags, {
    'azd-service-name': 'api'
  })
  identity: {
    type: 'UserAssigned'
    userAssignedIdentities: {
      '${userAssignedIdentity.id}': {}
    }
  }
  properties: {
    serverFarmId: appServicePlan.id
    httpsOnly: true
    keyVaultReferenceIdentity: userAssignedIdentity.id
    siteConfig: {
      appSettings: functionAppAppSettings
      netFrameworkVersion: 'v6.0'
      ftpsState: 'FtpsOnly'
      minTlsVersion: '1.2'
      cors: {
        allowedOrigins: ['*']
        supportCredentials: false
      }
    }
  }
}

module lineKeyVaultSecret '../core/security/keyvault-secret.bicep' = if (!empty(keyVaultName)) {
  name: 'lineKeyVaultSecret'
  params: {
    keyVaultName: keyVaultName
    name: lineChannelAccessTokenSecretName
    secretValue: lineChannelAccessToken
  }
}

resource storageAccount 'Microsoft.Storage/storageAccounts@2022-05-01' existing = if (!(empty(storageAccountName))) {
  name: storageAccountName
}

resource applicationInsights 'Microsoft.Insights/components@2020-02-02' existing = if (!empty(applicationInsightsName)) {
  name: applicationInsightsName
}

resource keyVault 'Microsoft.KeyVault/vaults@2022-07-01' existing = if (!(empty(keyVaultName))) {
  name: keyVaultName
}

// Role assignments for storage access
resource storageBlobDataContributorRoleAssignment 'Microsoft.Authorization/roleAssignments@2022-04-01' = {
  scope: storageAccount
  name: guid(storageAccount.id, userAssignedIdentity.id, 'ba92f5b4-2d11-453d-a403-e96b0029c9fe')
  properties: {
    roleDefinitionId: subscriptionResourceId('Microsoft.Authorization/roleDefinitions', 'ba92f5b4-2d11-453d-a403-e96b0029c9fe')
    principalId: userAssignedIdentity.properties.principalId
    principalType: 'ServicePrincipal'
  }
}

resource storageBlobDataOwnerRoleAssignment 'Microsoft.Authorization/roleAssignments@2022-04-01' = {
  scope: storageAccount
  name: guid(storageAccount.id, userAssignedIdentity.id, 'b7e6dc6d-f1e8-4753-8033-0f276bb0955b')
  properties: {
    roleDefinitionId: subscriptionResourceId('Microsoft.Authorization/roleDefinitions', 'b7e6dc6d-f1e8-4753-8033-0f276bb0955b')
    principalId: userAssignedIdentity.properties.principalId
    principalType: 'ServicePrincipal'
  }
}

resource storageQueueDataContributorRoleAssignment 'Microsoft.Authorization/roleAssignments@2022-04-01' = {
  scope: storageAccount
  name: guid(storageAccount.id, userAssignedIdentity.id, '974c5e8b-45b9-4653-ba55-5f855dd0fb88')
  properties: {
    roleDefinitionId: subscriptionResourceId('Microsoft.Authorization/roleDefinitions', '974c5e8b-45b9-4653-ba55-5f855dd0fb88')
    principalId: userAssignedIdentity.properties.principalId
    principalType: 'ServicePrincipal'
  }
}

resource storageTableDataContributorRoleAssignment 'Microsoft.Authorization/roleAssignments@2022-04-01' = {
  scope: storageAccount
  name: guid(storageAccount.id, userAssignedIdentity.id, '0a9a7e1f-b9d0-4cc4-a60d-0319b160aaa3')
  properties: {
    roleDefinitionId: subscriptionResourceId('Microsoft.Authorization/roleDefinitions', '0a9a7e1f-b9d0-4cc4-a60d-0319b160aaa3')
    principalId: userAssignedIdentity.properties.principalId
    principalType: 'ServicePrincipal'
  }
}

// Monitoring metrics publisher role
resource monitoringMetricsPublisherRoleAssignment 'Microsoft.Authorization/roleAssignments@2022-04-01' = {
  scope: resourceGroup()
  name: guid(resourceGroup().id, userAssignedIdentity.id, '3913510d-42f4-4e42-8a64-420c390055eb')
  properties: {
    roleDefinitionId: subscriptionResourceId('Microsoft.Authorization/roleDefinitions', '3913510d-42f4-4e42-8a64-420c390055eb')
    principalId: userAssignedIdentity.properties.principalId
    principalType: 'ServicePrincipal'
  }
}

// Key Vault Secrets User role assignment for accessing secrets
resource keyVaultSecretsUserRoleAssignment 'Microsoft.Authorization/roleAssignments@2022-04-01' = if (!empty(keyVaultName)) {
  scope: keyVault
  name: guid(keyVault.id, userAssignedIdentity.id, '4633458b-17de-408a-b874-0445c86b69e6')
  properties: {
    roleDefinitionId: subscriptionResourceId('Microsoft.Authorization/roleDefinitions', '4633458b-17de-408a-b874-0445c86b69e6')
    principalId: userAssignedIdentity.properties.principalId
    principalType: 'ServicePrincipal'
  }
}

// Diagnostic settings for function app
resource functionAppDiagnosticSettings 'Microsoft.Insights/diagnosticSettings@2021-05-01-preview' = if (!empty(applicationInsightsName)) {
  scope: functionApp
  name: '${name}-diagnostics'
  properties: {
    workspaceId: applicationInsights.properties.WorkspaceResourceId
    logs: [
      {
        category: 'FunctionAppLogs'
        enabled: true
      }
    ]
    metrics: [
      {
        category: 'AllMetrics'
        enabled: true
      }
    ]
  }
}

output SERVICE_API_IDENTITY_PRINCIPAL_ID string = userAssignedIdentity.properties.principalId
output name string = functionApp.name

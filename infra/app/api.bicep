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
    value: 'dotnet'
  }
  {
    name: 'FUNCTIONS_INPROC_NET8_ENABLED'
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
    name: 'LineBotSettings:ChannelAccessToken'
    value: '@Microsoft.KeyVault(VaultName=${keyVaultName};SecretName=${lineChannelAccessTokenSecretName})'
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
  tags: {
    'azd-service-name': 'api'
  }
  identity: {
    type: 'SystemAssigned'
  }
  properties: {
    serverFarmId: appServicePlan.id
    httpsOnly: true
    siteConfig: {
      appSettings: functionAppAppSettings
      netFrameworkVersion: 'v6.0'
      ftpsState: 'FtpsOnly'
      minTlsVersion: '1.2'
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

output SERVICE_API_IDENTITY_PRINCIPAL_ID string = functionApp.identity.principalId

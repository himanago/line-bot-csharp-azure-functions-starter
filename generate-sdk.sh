if [ -d "./sdk" ]; then
    rm -rf ./sdk
fi

npx @openapitools/openapi-generator-cli generate -i https://raw.githubusercontent.com/line/line-openapi/main/messaging-api.yml -o sdk -g csharp --additional-properties=netCoreProjectFile=true,targetFramework=netstandard2.1,library=httpclient,packageName=LineOpenApi.MessagingApi

npx @openapitools/openapi-generator-cli generate -i https://raw.githubusercontent.com/line/line-openapi/main/webhook.yml -o sdk -g csharp --additional-properties=netCoreProjectFile=true,targetFramework=netstandard2.1,library=httpclient,packageName=LineOpenApi.Webhook

find ./sdk/src/LineOpenApi.Webhook/Model/ -type f | while read file; do
    if ! grep -q ": IEquatable<" "$file"; then
        sed -i '/\[JsonConverter(typeof(JsonSubtypes), "Type")\]/d' "$file"
    fi
done
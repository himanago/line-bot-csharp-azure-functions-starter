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

find ./sdk/src/LineOpenApi.MessagingApi/Model/ -type f | while read file; do
    if grep -q " : Message, IEquatable<" "$file"; then
        echo "Replacing message type: $file"
        sed -i 's/\(string type = @"\)\(.*\)Message"/\1\L\2"/' "$file"
    fi
done

# WebhookHandlerの生成
echo "Generating WebhookHandler..."
dotnet run --project ./tools/WebhookHandlerGenerator -- --webhook-spec https://raw.githubusercontent.com/line/line-openapi/main/webhook.yml --output ./sdk/src/LineOpenApi.Webhook/
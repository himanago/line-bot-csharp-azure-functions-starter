# LINE Bot C# Azure Functions Starter

GitHub Codespaces で開くだけで、最新の LINE OpenAPI に従った SDK をもとに LINE Bot 開発ができるテンプレートです。

## 使用技術

- C# (.NET 6 in-process)
- Azure Functions
- Azure Key Vault
- Azure Application Insights
- Azure Developer CLI (azd)
- LINE Messaging API
- OpenAPI Generator

## 使い方

### 1. GitHub Codespaces で開く

本リポジトリの Use this template > Open in a codespace から開けます。

### 2. 準備完了するまで待つ

Codespace の画面が表示されたあと、いくつかのコマンドが実行されます。

openapi-generator-cli により LINE OpenAPI の定義から SDK を `sdk` フォルダに生成するので、出来上がりを待ちます。

待っている間に、3 を進めます。

### 3. LINE Messagng API チャネルの作成

LINE Developers のドキュメント、[Messaging APIを始めよう](https://developers.line.biz/ja/docs/messaging-api/getting-started/) を参考に、Messaging API チャネルを作成します。

### 4. Azure Developer CLI のログイン

ターミナルで以下のコマンドを実行し、`azd` で Azure にログインします。

```bash
azd auth login --use-device-code
```

表示されるコードをコピーし、Enter 押下後に開くタブに貼り付け、使用する Azure アカウントでサインインしてください。

### 5. Azure Developer CLI によるリソースの作成とデプロイ

`azure.yaml` ファイルを右クリックし、Azure Developer CLI (azd) > Package, Provision and Deploy (up) を選択します。

または、ターミナルで以下のコマンドを実行します。

```bash
azd up
```

ターミナルでサブスクリプションとリージョンを選んでください。

LINE Messaging API との接続のために、チャネルアクセストークンを入力するように言われるので、先ほど作成した LINE Messaging API チャネルのチャネルアクセストークンをコピーしてきて、貼り付けてください。

リソースの作成とコードのデプロイが開始するので、完了するまで待ちます。

### 6. LINE Bot の Webhook URL の設定

デプロイが完了したら、Azure Functions の `WebhookEndpoint` 関数の URL をコピーして LINE Messaging API チャネルの Webhook URL に設定します。

### 7. オウム返しの動作確認と Bot の実装
​
Messaging API の管理画面の QR コードを読み取って Bot を LINE に友だち追加して、テキストメッセージを送ってください。

オウム返しで同じ内容を返信してくれたら成功です。

あとは、好きな機能を実装していきます。

## その他

SDK を最新化したい場合、以下のコマンドを実行してください。

```bash
./generate-sdk.sh
```


## 参考

azd のテンプレートは以下のリポジトリを参考にしています。
- [Azure Functions - Text Summarization using AI Cognitive Language Service (C#-Isolated)](https://github.com/Azure-Samples/function-csharp-ai-textsummarize)
- [C# Function Application with Azure Service Bus](https://github.com/Gordonby/servicebus-dotnet-functionapp)

# appwrite_functions_dotnet_example1

## 概要
* Appwrite の Functions で .NET 8 を使って hello world! を返すだけのサンプル  
* マニュアルデプロイ(手動でソースを tar.gz にしてアップする) 
* Appwrite はセルフホスト ※ Version 1.6.1-RC1

※.NET 8 は Appwrite の Version 1.6.1-RC1 が必要です。（.NET 7 までなら 1.6.0 で OK）  
※.NET の Open Runtimes の仕様については以下を参照  
[open-runtimes/runtimes/dotnet
/README.md](https://github.com/open-runtimes/open-runtimes/blob/main/runtimes/dotnet/README.md)

## 留意事項
* 名前空間は `DotNetRuntime` でなければならない

## メモ
* Appwrite は Open Runtimes を使用して Functions を実行している
  * [Open Runtimes](https://github.com/open-runtimes/open-runtimes)
* Appwrite で対象のランタイムが使用できるかは、上記 Open Runtimes と Appwrite の両方の対応状況に依存する
  * Open Runtimes で対応していても、Appwrite に指定できるランタイムのリストがあるため、これが更新されないとランタイムに指定できない（無視される）
  * 見た感じ Appwrite の app/config/specs の json を弄ればいけそうだが、実際にそれだけで済むかは不明

## 詳細

### src を tar.gz にアーカイブ

```
tar --exclude hello-world.tar.gz -czf hello-world.tar.gz -C src .
```

### Function の作成及びアップロード

#### 基本的な操作は以下を参照
appwrite_functions_node_example1  
https://github.com/Tobotobo/appwrite_functions_node_example1  

#### 差異
* Details の Runtime で `.NET-8.0` を指定
* Configuration の Entrypoint で `Index.cs` を指定
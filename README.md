# 20241205_GitHubUniverse_SDLC_AvanadeJapan
20241205_ソフトウェア開発ライフサイクルを進化させるGitHub Universe 2024の最新トピック

■GitHub Copilot Chat プログラム実装のデモ

# CopilotDemo.csproj
商品マスタからデータを取得して表示するプログラムを実装したいです。
ディレクトリ構造として、Models、Services、Repositoriesを保持します。
商品マスタのデータはitem.csvとしてプログラムのカレントディレクトリ配下に保持します。

まずは、商品マスタのモデルを作成してください。
カラムは、商品コード、商品名、金額としたいです。

# CopilotDemo.csproj
続いて、Repositoryクラスを作成したいです。
メソッドのパラメータ（検索条件）は商品コードとしてください。

# CopilotDemo.csproj
続いて、Serviceクラスを作成したいです。
・Program.cs Mainエントリポイントから呼び出される形とし、Consoleで入力された商品コードを元に呼び出される形としたいです。
・メソッドのパラメータ（検索条件）は商品コードとしてください。
・Repositoryクラスを呼び出してください。


■GitHub Copilotのデモ
ItemRepository.csの最下部で下記を入力
// 商品名であいまい検索

ItemService.csの最下部にフォーカス
予測変換される

Program.cs のMainメソッド最下部へ
// 商品名であいまい検索

# CopilotDemo.csproj
item.csv のサンプルデータを15件、ヘッダ付きで、Csvで作成してください。
データの中身は英語で果物にして、現実に近しい金額にしてください。


■GitHub Copilot Chat Unit Test作成のデモ
/tests ItemRepository.cs

■GitHub Copilot Chat 処理内容の説明
/explain ItemRepository.cs

■GitHub Copilot Chat 処理内容の図式化、Mermaid
/explain ItemRepository.cs Mermaidで処理内容を書いてください。
















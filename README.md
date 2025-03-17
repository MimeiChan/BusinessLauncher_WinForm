# BusinessLauncher_WinForm

## 概要
このプロジェクトは .NET Framework（4.8）とWinFormsを使用した汎用業務ランチャーアプリケーションです。MVPパターンを採用し、UIとビジネスロジックの分離を実現しています。

## 機能一覧
- グリッドレイアウトによるアプリケーションランチャー表示
- ドラッグ＆ドロップによる項目の並べ替え
- 編集モード／実行モードの切り替え
- アプリケーション項目の追加・編集・削除
- XML形式による設定の永続化
- エラーログ機能

## プロジェクト構成
プロジェクトは以下のレイヤー構造で構成されています：

### UI層（View）
- `LauncherApp.UI`: WinFormsのフォームとコントロール
  - メイン画面（LauncherForm）
  - 項目編集画面（EditItemForm）
  - カスタムコントロール（MenuItemControl）

### ビジネスロジック層（Presenter）
- `LauncherApp.Presenter`: UIとデータ層の仲介役
  - LauncherPresenter
  - EditItemPresenter

### データ層（Model）
- `LauncherApp.Model`: データモデル
  - MenuItem（アプリ項目）
  - Settings（全体設定）

### データアクセス層
- `LauncherApp.DataAccess`: データの永続化
  - SettingsManager（XML操作）

### ユーティリティ層
- `LauncherApp.Utility`: 共通機能
  - ApplicationLauncher（プロセス起動）
  - Logger（ログ機能）

## 開発環境
- Visual Studio 2022
- .NET Framework 4.8
- C#
- WinForms

## 使用方法
1. アプリケーションを起動する
2. 編集モードに切り替えて項目を追加する
3. 実行モードに戻り、追加した項目をクリックしてアプリケーションを起動する

## ライセンス
MIT

## 作者
[MimeiChan](https://github.com/MimeiChan)

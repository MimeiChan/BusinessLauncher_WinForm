using BusinessLauncher_WinForm.UI;
using BusinessLauncher_WinForm.Utility;
using System;
using System.Windows.Forms;

namespace BusinessLauncher_WinForm
{
    /// <summary>
    /// アプリケーションのエントリポイントを提供するクラス
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメインエントリポイント
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // アプリケーションの初期設定
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                
                // アプリケーション開始のログを記録
                Logger.Log(LogLevel.Info, "アプリケーション起動");

                // メインフォームを作成して開始
                Application.Run(new LauncherForm());
            }
            catch (Exception ex)
            {
                // 予期しない例外が発生した場合、ログに記録
                Logger.Log(LogLevel.Error, $"予期しない例外が発生しました: {ex.Message}");
                Logger.Log(LogLevel.Error, ex.StackTrace);
                
                // ユーザーに通知
                MessageBox.Show(
                    $"アプリケーションで予期しないエラーが発生しました。\n{ex.Message}",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

namespace Avalonia.WebView.MacCatalyst.Delegates;
internal class WebViewUIDelegate : WKUIDelegate
{

    public override void RunJavaScriptAlertPanel(WKWebView webView, string message, WKFrameInfo frame, Action completionHandler)
    {

    }

    public override void RunJavaScriptConfirmPanel(WKWebView webView, string message, WKFrameInfo frame, Action<bool> completionHandler)
    {

    }

    public override void RunJavaScriptTextInputPanel(WKWebView webView, string prompt, string? defaultText, WKFrameInfo frame, Action<string> completionHandler)
    {

    }

    private static string GetJsAlertTitle(WKWebView webView)
    {
        return string.Empty;
    }


}
using Avalonia.WebView.iOS.Handlers;

namespace Avalonia.WebView.iOS;

partial class WebViewHandler
{

    public override async Task<string?> ExecuteScriptAsync(string javaScript)
    {
        if (WebView is null)
            return default;

        if (string.IsNullOrWhiteSpace(javaScript))
            return default;

        var ret = await WebView.EvaluateJavaScriptAsync(javaScript);
        return CFString.FromHandle(ret.Handle) ?? string.Empty;
    }

    public override bool GoBack()
    {
        if (WebView is null)
            return false;

        if (!WebView.CanGoBack)
            return false;

        return WebView.GoBack() == null ? false : true;
    }

    public override bool GoForward()
    {
        if (WebView is null)
            return false;

        if (!WebView.CanGoForward)
            return false;

        return WebView.GoForward() == null ? false : true;
    }

    public override bool Navigate(Uri? uri)
    {
        if (uri is null)
            return false;

        Source = uri.AbsoluteUri;
        return true;
    }

    public override bool NavigateToString(string htmlContent)
    {
        if (string.IsNullOrWhiteSpace(htmlContent))
            return false;

        HtmlContent = htmlContent;
        return true;
    }

    public override bool OpenDevToolsWindow()
    {
        return true;
    }

    public override bool PostWebMessageAsJson(string webMessageAsJson)
    {
        //WebView.PostWeb
        throw new NotImplementedException();
    }

    public override bool PostWebMessageAsString(string webMessageAsString)
    {
        throw new NotImplementedException();
    }

    public override bool Reload()
    {
        if (WebView is null)
            return false;

        WebView.Reload();
        return true;
    }

    public override bool Resume()
    {
        if (WebView is null)
            return false;

        WebView.ReloadFromOrigin();
        return true;
    }

    public override bool Stop()
    {
        throw new NotImplementedException();
    }

    protected override bool Initializing()
    {
        return true;
    }

    protected override HandleRef CreatePlatformHandler(IPlatformHandle parent, Func<IPlatformHandle> createFromSystem)
    {
        var config = new WKWebViewConfiguration();
        config.Preferences.SetValueForKey(NSObject.FromObject(true), new NSString("developerExtrasEnabled"));
        config.UserContentController.AddScriptMessageHandler(new WebViewScriptMessageHandler(MessageReceived), "webwindowinterop");
        //config.UserContentController.AddUserScript(new WKUserScript( new NSString(BlazorInitScript), WKUserScriptInjectionTime.AtDocumentEnd, true));
        // iOS WKWebView doesn't allow handling 'http'/'https' schemes, so we use the fake 'app' scheme
        config.SetUrlSchemeHandler(new SchemeHandler(), urlScheme: "app");
        var webview = new WKWebView(CGRect.Empty, config)
        {
            BackgroundColor = UIColor.Clear,
            AutosizesSubviews = true
        };

        if (!_hwndTaskSource.Task.IsCompleted)
            _hwndTaskSource.SetResult(webview);

        return new HandleRef(webview, webview.Handle.Handle);
    }

    protected override void Disposing()
    {
        WebView?.Dispose();
    }
}

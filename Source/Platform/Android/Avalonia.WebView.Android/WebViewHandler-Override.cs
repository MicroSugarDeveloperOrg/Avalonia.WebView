using Avalonia.WebView.Android.Handlers;
using static Android.Views.ViewGroup;

namespace Avalonia.WebView.Android;
partial class WebViewHandler
{
    public override Task<string?> ExecuteScriptAsync(string javaScript)
    {
        if (AndroidWebView is null)
            return Task.FromResult<string?>(default);

        return Task.Run<string?>(() =>
        {
            using var resetEvent = new AutoResetEvent(false);
            string resultString = string.Empty;

            var valueCallBack = new JavaScriptValueCallback(result =>
            {
                if (result is not null)
                    resultString = result.ToString();
            
                resetEvent.Set();
            });

            AndroidWebView.EvaluateJavascript(javaScript, valueCallBack);
            resetEvent.WaitOne();

            return resultString;
        });
    }

    public override bool GoBack()
    {
        if (AndroidWebView is null)
            return false;

        if (!AndroidWebView.CanGoBack())
            return false;

        AndroidWebView.GoBack();
        return true;
    }

    public override bool GoForward()
    {
        if (AndroidWebView is null)
            return false;

        if (!AndroidWebView.CanGoForward())
            return false;

        AndroidWebView.GoForward();
        return true;
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

        //AndroidWebView.PostWebMessage
        throw new NotImplementedException();
    }

    public override bool PostWebMessageAsString(string webMessageAsString)
    {
        throw new NotImplementedException();
    }

    public override bool Reload()
    {
        if (AndroidWebView is null)
            return false;

        AndroidWebView.Reload();    
        return true;
    }

    public override bool Resume()
    {
        if (AndroidWebView is null)
            return false;

        AndroidWebView.OnResume();
        return true;
    }

    public override bool Stop()
    {
        if (AndroidWebView is null)
            return false;

        AndroidWebView.StopLoading();
        return true;
    }

    protected override bool Initializing()
    {
        AndroidWebView.SetWebContentsDebuggingEnabled(enabled: true);
        return true;
    }

    protected override HandleRef CreatePlatformHandler(IPlatformHandle parent, Func<IPlatformHandle> createFromSystem)
    {
        var parentContext = AndroidApplication.Context;
        //var parentContext = ((parent as AndroidViewControlHandle)?.View.Context) ?? AndroidApplication.Context;

        // Validate platform compatibility
        var webView = new AndroidWebView(parentContext)
        {
#pragma warning disable CS0618,CA1422  // Type or member is obsolete // Validate platform compatibility
            LayoutParameters = new AbsoluteLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent, 0, 0),
#pragma warning restore CS0618, CA1422 // Type or member is obsolete
        };

        if (!_hwndTaskSource.Task.IsCompleted)
            _hwndTaskSource.SetResult(webView);

        return new HandleRef(webView, webView.Handle);
    }

    protected override void Disposing()
    {
        _webViewClient?.Dispose();
        _webChromeClient?.Dispose();
        AndroidWebView?.Dispose();
        AndroidWebView = default;
    }
}

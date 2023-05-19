using Avalonia.WebView.Android.Clients;

namespace Avalonia.WebView.Android;
partial class WebViewHandler
{
    private void VerifyNotDisposed()
    {
        if (IsDisposed)
            throw new ObjectDisposedException(Name);
    }

    public Task EnsureAndroidWebViewAsync(bool isUri = true)
    {
        VerifyAccess();
        VerifyNotDisposed();

        if (SynchronizationContext.Current == null)
            throw new InvalidOperationException("EnsureAndroidWebViewAsync cannot be used before the application's event loop has started running.");

        if (_initTask == null || _initTask.IsFaulted)
            _initTask = Init();

        return _initTask;

        async Task Init()
        {
            try
            {
                VirtualView.OnPlatformViewCreating(this);

                var webview = await _hwndTaskSource.Task;
                AndroidWebView = webview;

                webview.Settings.SetSupportMultipleWindows(true);
                webview.Settings.JavaScriptEnabled = true;
                webview.Settings.DomStorageEnabled = true;

                _webViewClient?.Dispose();
                _webViewClient = new WebViewClient();
                webview.SetWebViewClient(_webViewClient);

                _webChromeClient?.Dispose();
                _webChromeClient = new AvaloniaWebChromeClient();
                //_webChromeClient = new WebChromeClient();
                webview.SetWebChromeClient(_webChromeClient);

                if (isUri)
                {
                    if (!string.IsNullOrWhiteSpace(Source))
                        webview.LoadUrl(Source);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(HtmlContent))
                        webview.LoadData(HtmlContent, default, default);
                }

                VirtualView.OnPlatformViewCreated(this);
            }
            catch (Exception ex2)
            {

            }
        }

    }

    private void WebViewHandler_SizeChanged(object? sender, SizeChangedEventArgs e)
    {
        //AndroidWebView.ResolveSize
    }
}

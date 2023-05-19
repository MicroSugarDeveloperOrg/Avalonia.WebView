namespace Avalonia.WebView.iOS;

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
                WebView = webview;

                if (isUri)
                {
                    if (!string.IsNullOrWhiteSpace(Source))
                    {
                        using var nsUrl = new NSUrl(Source);
                        using var request = new NSUrlRequest(nsUrl);
                        webview.LoadRequest(request);
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(HtmlContent))
                        webview.LoadHtmlString(HtmlContent, default!);
                }

                VirtualView.OnPlatformViewCreated(this);
            }
            catch (Exception ex2)
            {

            }
        }

    }

    void RegisterWebViewEvents()
    {

    }


    private void WebViewHandler_SizeChanged(object? sender, SizeChangedEventArgs e)
    {
        //AndroidWebView.ResolveSize
    }

    private void MessageReceived(Uri uri, string message)
    {
        //_webviewManager?.MessageReceivedInternal(uri, message);
    }









}

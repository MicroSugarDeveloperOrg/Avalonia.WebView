namespace AvaloniaBlazorWebView.Core;

internal class AvaloniaWebViewManager : WebViewManager, IVirtualBlazorWebViewProvider
{
    public AvaloniaWebViewManager(BlazorWebView webview,
                                  IServiceProvider provider,
                                  Dispatcher dispatcher,
                                  string appScheme,
                                  string appHostAddress,
                                  Uri appBaseUri,
                                  IFileProvider fileProvider,
                                  JSComponentConfigurationStore jsComponents,
                                  string contentRootDirToAppRoot,
                                  string hostPageRelativePath)
         : base(provider, dispatcher, appBaseUri, fileProvider, jsComponents, hostPageRelativePath)
    {
        _blazorWebView = webview;
        _webViewControl = _blazorWebView;
        _contentRootDirPath = contentRootDirToAppRoot;
        _hostPageRelativePath = hostPageRelativePath;
        _appScheme = appScheme;
        _appHostAddress = appHostAddress;
        _appBaseUri = appBaseUri;
        _messageQueue = Channel.CreateUnbounded<string>(new UnboundedChannelOptions() { SingleReader = true, SingleWriter = false, AllowSynchronousContinuations = false });
        _handleMessageTask = Task.Factory.StartNew(MessageReadProgress, TaskCreationOptions.LongRunning);
    }

    readonly string _contentRootDirPath;
    readonly BlazorWebView _blazorWebView;
    readonly IWebViewControl _webViewControl;
    readonly Channel<string> _messageQueue;
    readonly Task _handleMessageTask;
    readonly string _appScheme;
    readonly string _appHostAddress;
    readonly Uri _appBaseUri;
    readonly string _hostPageRelativePath;

    //string IVirtualBlazorWebViewProvider.AppHostAddress => _appHostAddress;

    Uri IVirtualBlazorWebViewProvider.BaseUri => _appBaseUri;

    protected override async void NavigateCore(Uri absoluteUri)
    {
        await Dispatcher.InvokeAsync(() => _webViewControl.Navigate(absoluteUri));
    }

    protected override void SendMessage(string message)
    {
        _messageQueue.Writer.TryWrite(message);
    }

    async Task MessageReadProgress()
    {
        var reader = _messageQueue.Reader;
        try
        {
            for (; ; )
            {
                var message = await reader.ReadAsync();
                await Dispatcher.InvokeAsync(() => _webViewControl.PostWebMessageAsString(message, _appBaseUri));
            }
        }
        catch (Exception)
        {

        }
    }

    protected override ValueTask DisposeAsyncCore()
    {
        try
        {
            _messageQueue.Writer.Complete();
        }
        catch (Exception)
        {

        }

        _handleMessageTask.Wait();
        _handleMessageTask.Dispose();

        return base.DisposeAsyncCore();
    }

    bool IVirtualBlazorWebViewProvider.ResourceRequestedFilterProvider(object? requester, out WebScheme filter)
    {
        filter = new(_appScheme, _appHostAddress, _appBaseUri);
        return true;
    }

    bool IVirtualBlazorWebViewProvider.PlatformWebViewResourceRequested(object? sender, WebResourceRequest request, out WebResourceResponse? response)
    {
        response = default;
        if (request is null)
            return false;

        var requestUri = QueryStringHelper.RemovePossibleQueryString(request.RequestUri);
        if (!TryGetResponseContent(requestUri, request.AllowFallbackOnHostPage, out var statusCode, out var statusMessage, out var content, out var headers))
            return false;

        //StaticContentHotReloadManager.TryReplaceResponseContent(_contentRootDirRelativePath, requestUri, ref statusCode, ref content, headers);
        var contentStream = new AutoCloseOnReadCompleteStream(content);   
        response = new WebResourceResponse
        {
            StatusCode = statusCode,
            StatusMessage = statusMessage,
            Content = contentStream,
            Headers = headers,
        };

        return true;
    }

    void IVirtualBlazorWebViewProvider.PlatformWebViewMessageReceived(object? sender, WebViewMessageReceivedEventArgs arg)
    {
        MessageReceived(arg.Source, arg.Message);
    }
}

using WebViewCore;
using WebViewCore.Helpers;
using WebViewCore.Models;

namespace AvaloniaBlazorWebView.Core;

internal class AvaloniaWebViewManager : WebViewManager, IVirtualWebViewProvider
{
    public AvaloniaWebViewManager(BlazorWebView webview,
                                  IServiceProvider provider,
                                  Dispatcher dispatcher,
                                  Uri appBaseUri,
                                  IFileProvider fileProvider,
                                  JSComponentConfigurationStore jsComponents,
                                  string contentRootRelativeToAppRoot,
                                  string hostPagePathWithinFileProvider)
         : base(provider, dispatcher, appBaseUri, fileProvider, jsComponents, hostPagePathWithinFileProvider)
    {
        _blazorWebView = webview;
        _webViewControl = _blazorWebView;
        _contentRootDirRelativePath = contentRootRelativeToAppRoot;
        _hostPageRelativePath = hostPagePathWithinFileProvider;
        _appBaseUri = appBaseUri;
        _messageQueue = Channel.CreateUnbounded<string>(new UnboundedChannelOptions() { SingleReader = true, SingleWriter = false, AllowSynchronousContinuations = false });
        _handleMessageTask = Task.Factory.StartNew(MessageReadProgress, TaskCreationOptions.LongRunning);
    }

    readonly string _contentRootDirRelativePath;
    readonly BlazorWebView _blazorWebView;
    readonly IWebViewControl _webViewControl;
    readonly Channel<string> _messageQueue;
    readonly Task _handleMessageTask;
    readonly Uri _appBaseUri;
    readonly string _hostPageRelativePath;


    protected override void NavigateCore(Uri absoluteUri)
    {
        _webViewControl.Navigate(absoluteUri);
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

                await  Dispatcher.InvokeAsync(() =>
                {
                    _webViewControl.PostWebMessageAsString(message);
                });
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

    private protected static string GetHeaderString(IDictionary<string, string> headers) => string.Join(Environment.NewLine, headers.Select(kvp => $"{kvp.Key}: {kvp.Value}"));

    bool IVirtualWebViewProvider.ResourceRequestedFilterProvider(object? requester, out string filter)
    {
        filter = $"{_appBaseUri.AbsoluteUri}*";
        return true;
    }

    bool IVirtualWebViewProvider.PlatformWebViewResourceRequested(object? sender, WebResourceRequest request, out WebResourceResponse? response)
    {
        response = default;
        if (request is null)
            return false;

        var requestUri = QueryStringHelper.RemovePossibleQueryString(request.RequestUri);
        if (!TryGetResponseContent(requestUri, request.AllowFallbackOnHostPage, out var statusCode, out var statusMessage, out var content, out var headers))
            return false;

        var headerstring = GetHeaderString(headers);
        //var headerstring = headers["Content-Type"];  //GetHeaderString(headers);
        var autoCloseStream = new AutoCloseOnReadCompleteStream(content);

        response = new WebResourceResponse
        {
            StatusCode = statusCode,
            StatusMessage = statusMessage,
            Content = autoCloseStream,
            Headers = headers,
            HeaderString = headerstring
        };
 
        return true;
    }

    void IVirtualWebViewProvider.PlatformWebViewMessageReceived(object? sender, WebViewMessageReceivedEventArgs arg)
    {
        MessageReceived(new Uri(arg.Source), arg.Message);
    }
}

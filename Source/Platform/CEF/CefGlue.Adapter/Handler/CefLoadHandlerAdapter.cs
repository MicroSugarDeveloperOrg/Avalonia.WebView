namespace CefGlue.Adapter.Handler;
internal sealed class CefLoadHandlerAdapter : CefLoadHandler
{
    public CefLoadHandlerAdapter(ILoadedHandler handler)
    {
        _handler = handler;
    }

    readonly ILoadedHandler _handler;

    protected override void OnLoadStart(CefBrowser browser, CefFrame frame, CefTransitionType transitionType)
    {
        _handler.OnLoadStart(browser, frame, transitionType);
    }

    protected override void OnLoadingStateChange(CefBrowser browser, bool isLoading, bool canGoBack, bool canGoForward)
    {
        _handler.OnLoadingStateChange(browser, isLoading, canGoBack, canGoForward);
    }

    protected override void OnLoadError(CefBrowser browser, CefFrame frame, CefErrorCode errorCode, string errorText, string failedUrl)
    {
        _handler.OnLoadError(browser, frame, errorCode, errorText, failedUrl);
    }

    protected override void OnLoadEnd(CefBrowser browser, CefFrame frame, int httpStatusCode)
    {
        _handler.OnLoadEnd(browser, frame, httpStatusCode);
    }
}

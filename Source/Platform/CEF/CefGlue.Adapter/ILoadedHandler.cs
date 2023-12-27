namespace CefGlue.Adapter;
public interface ILoadedHandler
{
    void OnLoadStart(CefBrowser browser, CefFrame frame, CefTransitionType transitionType);
    void OnLoadingStateChange(CefBrowser browser, bool isLoading, bool canGoBack, bool canGoForward);
    void OnLoadError(CefBrowser browser, CefFrame frame, CefErrorCode errorCode, string errorText, string failedUrl);
    void OnLoadEnd(CefBrowser browser, CefFrame frame, int httpStatusCode);
}

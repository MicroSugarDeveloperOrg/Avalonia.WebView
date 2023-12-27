namespace CefGlue.Adapter.Handler;
internal sealed class CefLifeSpanHandlerAdapter : CefLifeSpanHandler
{
    public CefLifeSpanHandlerAdapter(ILifeSpanHandler handler)
    {
        _handler = handler;
    }

    readonly ILifeSpanHandler _handler;

    protected override void OnAfterCreated(CefBrowser browser)
    {
        _handler.OnAfterCreated(browser);
    }

    protected override bool OnBeforePopup(CefBrowser browser, CefFrame frame, string targetUrl, string targetFrameName, CefWindowOpenDisposition targetDisposition, bool userGesture, CefPopupFeatures popupFeatures, CefWindowInfo windowInfo, ref CefClient client, CefBrowserSettings settings, ref CefDictionaryValue extraInfo, ref bool noJavascriptAccess)
    {
        return _handler.OnBeforePopup(browser, frame, targetUrl, targetFrameName, targetDisposition, userGesture, popupFeatures, windowInfo, ref client, settings, ref extraInfo, ref noJavascriptAccess);
    }

    protected override void OnBeforeClose(CefBrowser browser)
    {
        _handler.OnBeforeClose(browser);
    }
}

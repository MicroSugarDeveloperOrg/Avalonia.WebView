namespace CefGlue.Adapter.Handler;
internal sealed class CefDisplayHandlerAdapter : CefDisplayHandler
{
    public CefDisplayHandlerAdapter(IDisplayHandler handler)
    {
        _handler = handler;
    }

    readonly IDisplayHandler _handler;

    protected override void OnAddressChange(CefBrowser browser, CefFrame frame, string url)
    {
        _handler.OnAddressChange(browser, frame, url);
    }

    protected override void OnTitleChange(CefBrowser browser, string title)
    {
        _handler.OnTitleChange(browser, title);
    }

    protected override bool OnTooltip(CefBrowser browser, string text)
    {
         return _handler.OnTooltip(browser, text);
    }

    protected override void OnStatusMessage(CefBrowser browser, string value)
    {
        _handler.OnStatusMessage(browser, value);    
    }

    protected override bool OnConsoleMessage(CefBrowser browser, CefLogSeverity level, string message, string source, int line)
    {
        return _handler.OnConsoleMessage(browser, level, message, source, line);     
    }
}

namespace CefGlue.Adapter;
public interface IDisplayHandler
{
    void OnAddressChange(CefBrowser browser, CefFrame frame, string url);
    void OnTitleChange(CefBrowser browser, string title);
    bool OnTooltip(CefBrowser browser, string text);
    void OnStatusMessage(CefBrowser browser, string value);
    bool OnConsoleMessage(CefBrowser browser, CefLogSeverity level, string message, string source, int line);
}

namespace CefGlue.Adapter.Handler;
internal sealed class CefJSDialogHandlerAdapter : CefJSDialogHandler
{
    public CefJSDialogHandlerAdapter(IJSDialogHandler handler)
    {
        _handler = handler;
    }

    readonly IJSDialogHandler _handler;

    protected override bool OnBeforeUnloadDialog(CefBrowser browser, string messageText, bool isReload, CefJSDialogCallback callback)
    {
        return _handler.OnBeforeUnloadDialog(browser, messageText, isReload, callback);
    }

    protected override void OnDialogClosed(CefBrowser browser)
    {
        _handler.OnDialogClosed(browser);
    }

    protected override bool OnJSDialog(CefBrowser browser, string originUrl, CefJSDialogType dialogType, string message_text, string default_prompt_text, CefJSDialogCallback callback, out bool suppress_message)
    {
        return _handler.OnJSDialog(browser, originUrl, dialogType, message_text, default_prompt_text, callback, out suppress_message);
    }

    protected override void OnResetDialogState(CefBrowser browser)
    {
        _handler.OnResetDialogState(browser);   
    }
}

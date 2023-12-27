using System;
using System.Collections.Generic;
using System.Text;

namespace CefGlue.Adapter;
public interface IJSDialogHandler
{
    bool OnBeforeUnloadDialog(CefBrowser browser, string messageText, bool isReload, CefJSDialogCallback callback);
    void OnDialogClosed(CefBrowser browser);
    bool OnJSDialog(CefBrowser browser, string originUrl, CefJSDialogType dialogType, string message_text, string default_prompt_text, CefJSDialogCallback callback, out bool suppress_message);
    void OnResetDialogState(CefBrowser browser);
}

namespace WebKit;
public enum WKErrorCode : long
{
    None,
    Unknown,
    WebContentProcessTerminated,
    WebViewInvalidated,
    JavaScriptExceptionOccurred,
    JavaScriptResultTypeIsUnsupported,
    ContentRuleListStoreCompileFailed,
    ContentRuleListStoreLookUpFailed,
    ContentRuleListStoreRemoveFailed,
    ContentRuleListStoreVersionMismatch,
    AttributedStringContentFailedToLoad,
    AttributedStringContentLoadTimedOut
}

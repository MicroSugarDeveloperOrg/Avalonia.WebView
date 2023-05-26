using ObjCRuntime;

namespace WebKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Native]
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

using Foundation;
using ObjCRuntime;

namespace WebKit;

public delegate bool WebViewPerformAction(WebView webView, Selector action, NSObject sender);

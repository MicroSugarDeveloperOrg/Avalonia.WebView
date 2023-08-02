using AppKit;
using Foundation;

namespace WebKit;

public delegate NSMenuItem[] WebViewGetContextMenuItems(WebView sender, NSDictionary forElement, NSMenuItem[] defaultMenuItems);

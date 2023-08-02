using AppKit;

namespace WebKit;

public delegate NSEventModifierMask DragDestinationGetActionMask(WebView webView, NSDraggingInfo draggingInfo);

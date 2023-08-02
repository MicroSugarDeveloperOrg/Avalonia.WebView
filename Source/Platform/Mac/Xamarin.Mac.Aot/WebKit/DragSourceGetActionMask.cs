using AppKit;
using CoreGraphics;

namespace WebKit;

public delegate NSEventModifierMask DragSourceGetActionMask(WebView webView, CGPoint point);

using System;
using CoreGraphics;

namespace WebKit;

public class WebViewFooterEventArgs : EventArgs
{
	public CGRect Rect { get; set; }

	public WebViewFooterEventArgs(CGRect rect)
	{
		Rect = rect;
	}
}

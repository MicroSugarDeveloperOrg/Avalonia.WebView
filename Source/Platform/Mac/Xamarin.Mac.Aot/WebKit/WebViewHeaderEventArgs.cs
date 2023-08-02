using System;
using CoreGraphics;

namespace WebKit;

public class WebViewHeaderEventArgs : EventArgs
{
	public CGRect Rect { get; set; }

	public WebViewHeaderEventArgs(CGRect rect)
	{
		Rect = rect;
	}
}

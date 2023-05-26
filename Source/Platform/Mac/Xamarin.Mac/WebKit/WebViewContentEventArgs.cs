using System;
using CoreGraphics;

namespace WebKit;

public class WebViewContentEventArgs : EventArgs
{
	public CGRect Frame { get; set; }

	public WebViewContentEventArgs(CGRect frame)
	{
		Frame = frame;
	}
}

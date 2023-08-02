using System;
using CoreGraphics;

namespace WebKit;

public class WebViewFrameEventArgs : EventArgs
{
	public CGRect NewFrame { get; set; }

	public WebViewFrameEventArgs(CGRect newFrame)
	{
		NewFrame = newFrame;
	}
}

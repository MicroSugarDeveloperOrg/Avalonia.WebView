using System;

namespace WebKit;

public class WebViewPrintEventArgs : EventArgs
{
	public WebFrameView FrameView { get; set; }

	public WebViewPrintEventArgs(WebFrameView frameView)
	{
		FrameView = frameView;
	}
}

using System;
using AppKit;

namespace WebKit;

public class WebViewResponderEventArgs : EventArgs
{
	public NSResponder NewResponder { get; set; }

	public WebViewResponderEventArgs(NSResponder newResponder)
	{
		NewResponder = newResponder;
	}
}

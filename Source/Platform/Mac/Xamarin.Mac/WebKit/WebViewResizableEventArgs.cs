using System;

namespace WebKit;

public class WebViewResizableEventArgs : EventArgs
{
	public bool Resizable { get; set; }

	public WebViewResizableEventArgs(bool resizable)
	{
		Resizable = resizable;
	}
}

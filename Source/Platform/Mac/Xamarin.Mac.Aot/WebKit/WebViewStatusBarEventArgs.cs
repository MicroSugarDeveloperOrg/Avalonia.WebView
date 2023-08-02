using System;

namespace WebKit;

public class WebViewStatusBarEventArgs : EventArgs
{
	public bool Visible { get; set; }

	public WebViewStatusBarEventArgs(bool visible)
	{
		Visible = visible;
	}
}

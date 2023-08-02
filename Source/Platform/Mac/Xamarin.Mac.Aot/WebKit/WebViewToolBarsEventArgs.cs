using System;

namespace WebKit;

public class WebViewToolBarsEventArgs : EventArgs
{
	public bool Visible { get; set; }

	public WebViewToolBarsEventArgs(bool visible)
	{
		Visible = visible;
	}
}

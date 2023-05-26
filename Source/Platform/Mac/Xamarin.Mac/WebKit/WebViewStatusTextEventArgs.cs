using System;

namespace WebKit;

public class WebViewStatusTextEventArgs : EventArgs
{
	public string Text { get; set; }

	public WebViewStatusTextEventArgs(string text)
	{
		Text = text;
	}
}

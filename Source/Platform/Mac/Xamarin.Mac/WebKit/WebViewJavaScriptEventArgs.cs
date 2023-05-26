using System;

namespace WebKit;

public class WebViewJavaScriptEventArgs : EventArgs
{
	public string Message { get; set; }

	public WebViewJavaScriptEventArgs(string message)
	{
		Message = message;
	}
}

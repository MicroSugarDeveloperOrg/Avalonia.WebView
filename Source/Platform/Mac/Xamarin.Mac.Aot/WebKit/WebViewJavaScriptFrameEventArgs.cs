using System;

namespace WebKit;

public class WebViewJavaScriptFrameEventArgs : EventArgs
{
	public string WithMessage { get; set; }

	public WebFrame InitiatedByFrame { get; set; }

	public WebViewJavaScriptFrameEventArgs(string withMessage, WebFrame initiatedByFrame)
	{
		WithMessage = withMessage;
		InitiatedByFrame = initiatedByFrame;
	}
}

using System;

namespace WebKit;

public class WebViewJavaScriptFrameEventArgs : EventArgs
{
	public WebFrame InitiatedByFrame { get; set; }

	public string WithMessage { get; set; }

	public WebViewJavaScriptFrameEventArgs(string withMessage, WebFrame initiatedByFrame)
	{
		InitiatedByFrame = initiatedByFrame;
		WithMessage = withMessage;
	}
}

using System;
using JavaScriptCore;

namespace WebKit;

public class WebFrameJavaScriptContextEventArgs : EventArgs
{
	public JSContext Context { get; set; }

	public WebFrame Frame { get; set; }

	public WebFrameJavaScriptContextEventArgs(JSContext context, WebFrame frame)
	{
		Context = context;
		Frame = frame;
	}
}

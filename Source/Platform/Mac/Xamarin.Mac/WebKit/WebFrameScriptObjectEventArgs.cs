using System;

namespace WebKit;

public class WebFrameScriptObjectEventArgs : EventArgs
{
	public WebScriptObject WindowScriptObject { get; set; }

	public WebFrameScriptObjectEventArgs(WebScriptObject windowScriptObject)
	{
		WindowScriptObject = windowScriptObject;
	}
}

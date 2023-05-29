using System;

namespace WebKit;

public class WebFrameScriptFrameEventArgs : EventArgs
{
	public WebScriptObject WindowObject { get; set; }

	public WebFrame ForFrame { get; set; }

	public WebFrameScriptFrameEventArgs(WebScriptObject windowObject, WebFrame forFrame)
	{
		WindowObject = windowObject;
		ForFrame = forFrame;
	}
}

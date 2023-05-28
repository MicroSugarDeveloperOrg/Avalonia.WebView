using System;

namespace WebKit;

public class WebFrameScriptFrameEventArgs : EventArgs
{
	public WebFrame ForFrame { get; set; }

	public WebScriptObject WindowObject { get; set; }

	public WebFrameScriptFrameEventArgs(WebScriptObject windowObject, WebFrame forFrame)
	{
		ForFrame = forFrame;
		WindowObject = windowObject;
	}
}

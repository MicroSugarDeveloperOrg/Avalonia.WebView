using System;

namespace WebKit;

public class WebFrameEventArgs : EventArgs
{
	public WebFrame ForFrame { get; set; }

	public WebFrameEventArgs(WebFrame forFrame)
	{
		ForFrame = forFrame;
	}
}

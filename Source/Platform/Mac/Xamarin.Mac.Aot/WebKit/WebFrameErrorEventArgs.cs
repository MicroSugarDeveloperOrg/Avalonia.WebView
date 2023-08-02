using System;
using Foundation;

namespace WebKit;

public class WebFrameErrorEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public WebFrame ForFrame { get; set; }

	public WebFrameErrorEventArgs(NSError error, WebFrame forFrame)
	{
		Error = error;
		ForFrame = forFrame;
	}
}

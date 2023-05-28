using System;
using AppKit;

namespace WebKit;

public class WebFrameImageEventArgs : EventArgs
{
	public WebFrame ForFrame { get; set; }

	public NSImage Image { get; set; }

	public WebFrameImageEventArgs(NSImage image, WebFrame forFrame)
	{
		ForFrame = forFrame;
		Image = image;
	}
}

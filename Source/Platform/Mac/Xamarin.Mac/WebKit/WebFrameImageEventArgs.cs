using System;
using AppKit;

namespace WebKit;

public class WebFrameImageEventArgs : EventArgs
{
	public NSImage Image { get; set; }

	public WebFrame ForFrame { get; set; }

	public WebFrameImageEventArgs(NSImage image, WebFrame forFrame)
	{
		Image = image;
		ForFrame = forFrame;
	}
}

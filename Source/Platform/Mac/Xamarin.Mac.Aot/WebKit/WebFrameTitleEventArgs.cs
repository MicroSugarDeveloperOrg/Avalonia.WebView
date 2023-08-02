using System;

namespace WebKit;

public class WebFrameTitleEventArgs : EventArgs
{
	public string Title { get; set; }

	public WebFrame ForFrame { get; set; }

	public WebFrameTitleEventArgs(string title, WebFrame forFrame)
	{
		Title = title;
		ForFrame = forFrame;
	}
}

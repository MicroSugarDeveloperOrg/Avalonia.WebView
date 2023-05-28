using System;

namespace WebKit;

public class WebFrameTitleEventArgs : EventArgs
{
	public WebFrame ForFrame { get; set; }

	public string Title { get; set; }

	public WebFrameTitleEventArgs(string title, WebFrame forFrame)
	{
		ForFrame = forFrame;
		Title = title;
	}
}

using System;
using Foundation;

namespace AppKit;

public class NSApplicationOpenUrlsEventArgs : EventArgs
{
	public NSUrl[] Urls { get; set; }

	public NSApplicationOpenUrlsEventArgs(NSUrl[] urls)
	{
		Urls = urls;
	}
}

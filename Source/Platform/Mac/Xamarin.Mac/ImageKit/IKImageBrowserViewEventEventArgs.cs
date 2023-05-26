using System;
using AppKit;

namespace ImageKit;

public class IKImageBrowserViewEventEventArgs : EventArgs
{
	public NSEvent Nsevent { get; set; }

	public IKImageBrowserViewEventEventArgs(NSEvent nsevent)
	{
		Nsevent = nsevent;
	}
}

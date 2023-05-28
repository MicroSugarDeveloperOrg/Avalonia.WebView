using System;
using AppKit;

namespace ImageKit;

public class IKImageBrowserViewIndexEventEventArgs : EventArgs
{
	public nint Index { get; set; }

	public NSEvent Nsevent { get; set; }

	public IKImageBrowserViewIndexEventEventArgs(nint index, NSEvent nsevent)
	{
		Index = index;
		Nsevent = nsevent;
	}
}

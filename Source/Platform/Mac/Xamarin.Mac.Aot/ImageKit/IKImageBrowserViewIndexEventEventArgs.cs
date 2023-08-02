using System;
using AppKit;

namespace ImageKit;

public class IKImageBrowserViewIndexEventEventArgs : EventArgs
{
	public int Index { get; set; }

	public NSEvent Nsevent { get; set; }

	public IKImageBrowserViewIndexEventEventArgs(int index, NSEvent nsevent)
	{
		Index = index;
		Nsevent = nsevent;
	}
}

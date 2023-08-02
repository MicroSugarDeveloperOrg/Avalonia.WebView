using System;
using Foundation;

namespace AppKit;

public class NSSharingServiceItemsEventArgs : EventArgs
{
	public NSObject[] Items { get; set; }

	public NSSharingServiceItemsEventArgs(NSObject[] items)
	{
		Items = items;
	}
}

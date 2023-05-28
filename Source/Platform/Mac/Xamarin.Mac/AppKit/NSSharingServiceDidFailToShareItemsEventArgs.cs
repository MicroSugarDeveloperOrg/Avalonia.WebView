using System;
using Foundation;

namespace AppKit;

public class NSSharingServiceDidFailToShareItemsEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public NSObject[] Items { get; set; }

	public NSSharingServiceDidFailToShareItemsEventArgs(NSObject[] items, NSError error)
	{
		Error = error;
		Items = items;
	}
}

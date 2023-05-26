using System;
using Foundation;

namespace AppKit;

public class NSSharingServiceDidFailToShareItemsEventArgs : EventArgs
{
	public NSObject[] Items { get; set; }

	public NSError Error { get; set; }

	public NSSharingServiceDidFailToShareItemsEventArgs(NSObject[] items, NSError error)
	{
		Items = items;
		Error = error;
	}
}

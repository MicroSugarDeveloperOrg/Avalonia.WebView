using System;

namespace AppKit;

public class NSTabViewItemEventArgs : EventArgs
{
	public NSTabViewItem Item { get; set; }

	public NSTabViewItemEventArgs(NSTabViewItem item)
	{
		Item = item;
	}
}

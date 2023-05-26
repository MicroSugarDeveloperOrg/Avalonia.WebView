using System;

namespace AppKit;

public class NSPathCellMenuEventArgs : EventArgs
{
	public NSMenu Menu { get; set; }

	public NSPathCellMenuEventArgs(NSMenu menu)
	{
		Menu = menu;
	}
}

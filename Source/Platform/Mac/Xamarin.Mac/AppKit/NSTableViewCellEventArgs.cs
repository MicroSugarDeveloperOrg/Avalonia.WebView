using System;
using Foundation;

namespace AppKit;

public class NSTableViewCellEventArgs : EventArgs
{
	public NSObject Cell { get; set; }

	public NSTableColumn TableColumn { get; set; }

	public long Row { get; set; }

	public NSTableViewCellEventArgs(NSObject cell, NSTableColumn tableColumn, long row)
	{
		Cell = cell;
		TableColumn = tableColumn;
		Row = row;
	}
}

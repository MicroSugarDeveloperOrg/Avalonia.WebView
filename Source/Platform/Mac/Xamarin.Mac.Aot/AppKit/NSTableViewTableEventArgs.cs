using System;

namespace AppKit;

public class NSTableViewTableEventArgs : EventArgs
{
	public NSTableColumn TableColumn { get; set; }

	public NSTableViewTableEventArgs(NSTableColumn tableColumn)
	{
		TableColumn = tableColumn;
	}
}

using System;

namespace AppKit;

public class NSTableViewRowEventArgs : EventArgs
{
	public NSTableRowView RowView { get; set; }

	public long Row { get; set; }

	public NSTableViewRowEventArgs(NSTableRowView rowView, long row)
	{
		RowView = rowView;
		Row = row;
	}
}

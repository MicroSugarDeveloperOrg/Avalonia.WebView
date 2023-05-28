using Xamarin.Mac.System.Mac;

namespace AppKit;

public class NSTableViewRowEventArgs : EventArgs
{
	public nint Row { get; set; }

	public NSTableRowView RowView { get; set; }

	public NSTableViewRowEventArgs(NSTableRowView rowView, nint row)
	{
		Row = row;
		RowView = rowView;
	}
}

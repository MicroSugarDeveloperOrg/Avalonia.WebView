using Foundation;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public class NSTableViewCellEventArgs : EventArgs
{
	public NSObject Cell { get; set; }

	public nint Row { get; set; }

	public NSTableColumn TableColumn { get; set; }

	public NSTableViewCellEventArgs(NSObject cell, NSTableColumn tableColumn, nint row)
	{
		Cell = cell;
		Row = row;
		TableColumn = tableColumn;
	}
}

using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate bool NSTableReorder(NSTableView tableView, nint columnIndex, nint newColumnIndex);

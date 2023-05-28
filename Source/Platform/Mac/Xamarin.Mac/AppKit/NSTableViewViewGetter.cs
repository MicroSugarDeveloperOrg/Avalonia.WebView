using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate NSView NSTableViewViewGetter(NSTableView tableView, NSTableColumn tableColumn, nint row);

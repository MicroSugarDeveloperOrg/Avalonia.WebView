using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate NSTableViewRowAction[] NSTableViewRowActionsGetter(NSTableView tableView, nint row, NSTableRowActionEdge edge);

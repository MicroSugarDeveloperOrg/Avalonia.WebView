using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate bool NSTableViewColumnRowPredicate(NSTableView tableView, NSTableColumn tableColumn, nint row);

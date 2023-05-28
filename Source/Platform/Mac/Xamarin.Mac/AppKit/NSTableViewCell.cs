using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate bool NSTableViewCell(NSTableView tableView, NSCell cell, NSTableColumn tableColumn, nint row);

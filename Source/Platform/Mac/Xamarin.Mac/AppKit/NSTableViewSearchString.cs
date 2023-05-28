using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate nint NSTableViewSearchString(NSTableView tableView, nint startRow, nint endRow, string searchString);

using System;

namespace AppKit;

public delegate NSView NSTableViewViewGetter(NSTableView tableView, NSTableColumn tableColumn, nint row);

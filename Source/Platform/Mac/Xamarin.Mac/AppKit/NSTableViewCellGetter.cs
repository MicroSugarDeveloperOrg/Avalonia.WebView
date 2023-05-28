using System;

namespace AppKit;

public delegate NSCell NSTableViewCellGetter(NSTableView tableView, NSTableColumn tableColumn, nint row);

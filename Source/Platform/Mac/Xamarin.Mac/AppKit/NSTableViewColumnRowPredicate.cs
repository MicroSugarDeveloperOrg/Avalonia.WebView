using System;

namespace AppKit;

public delegate bool NSTableViewColumnRowPredicate(NSTableView tableView, NSTableColumn tableColumn, nint row);

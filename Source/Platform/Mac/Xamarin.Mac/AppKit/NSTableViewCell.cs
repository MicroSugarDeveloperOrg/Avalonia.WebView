using System;

namespace AppKit;

public delegate bool NSTableViewCell(NSTableView tableView, NSCell cell, NSTableColumn tableColumn, nint row);

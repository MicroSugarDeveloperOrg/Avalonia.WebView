using System;

namespace AppKit;

public delegate bool NSTableReorder(NSTableView tableView, nint columnIndex, nint newColumnIndex);

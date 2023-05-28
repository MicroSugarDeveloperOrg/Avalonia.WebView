using System;
using CoreGraphics;
using Foundation;

namespace AppKit;

public delegate NSString NSTableViewToolTip(NSTableView tableView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, nint row, CGPoint mouseLocation);

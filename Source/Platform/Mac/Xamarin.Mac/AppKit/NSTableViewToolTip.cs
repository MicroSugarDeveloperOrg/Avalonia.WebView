using CoreGraphics;
using Foundation;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate NSString NSTableViewToolTip(NSTableView tableView, NSCell cell, ref CGRect rect, NSTableColumn? tableColumn, nint row, CGPoint mouseLocation);

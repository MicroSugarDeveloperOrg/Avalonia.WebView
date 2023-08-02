using System;
using CoreGraphics;

namespace AppKit;

public class NSTextViewDraggedCellEventArgs : EventArgs
{
	public NSTextAttachmentCell Cell { get; set; }

	public CGRect Rect { get; set; }

	public NSEvent Theevent { get; set; }

	public NSTextViewDraggedCellEventArgs(NSTextAttachmentCell cell, CGRect rect, NSEvent theevent)
	{
		Cell = cell;
		Rect = rect;
		Theevent = theevent;
	}
}

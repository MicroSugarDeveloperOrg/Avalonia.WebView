using System;
using CoreGraphics;

namespace AppKit;

public class NSTextViewDoubleClickEventArgs : EventArgs
{
	public NSTextAttachmentCell Cell { get; set; }

	public CGRect CellFrame { get; set; }

	public ulong CharIndex { get; set; }

	public NSTextViewDoubleClickEventArgs(NSTextAttachmentCell cell, CGRect cellFrame, ulong charIndex)
	{
		Cell = cell;
		CellFrame = cellFrame;
		CharIndex = charIndex;
	}
}

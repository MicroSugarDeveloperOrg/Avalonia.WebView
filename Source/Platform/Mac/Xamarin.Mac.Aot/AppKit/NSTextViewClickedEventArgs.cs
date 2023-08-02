using System;
using CoreGraphics;

namespace AppKit;

public class NSTextViewClickedEventArgs : EventArgs
{
	public NSTextAttachmentCell Cell { get; set; }

	public CGRect CellFrame { get; set; }

	public ulong CharIndex { get; set; }

	public NSTextViewClickedEventArgs(NSTextAttachmentCell cell, CGRect cellFrame, ulong charIndex)
	{
		Cell = cell;
		CellFrame = cellFrame;
		CharIndex = charIndex;
	}
}

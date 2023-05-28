using CoreGraphics;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public class NSTextViewDoubleClickEventArgs : EventArgs
{
	public NSTextAttachmentCell Cell { get; set; }

	public CGRect CellFrame { get; set; }

	public nuint CharIndex { get; set; }

	public NSTextViewDoubleClickEventArgs(NSTextAttachmentCell cell, CGRect cellFrame, nuint charIndex)
	{
		Cell = cell;
		CellFrame = cellFrame;
		CharIndex = charIndex;
	}
}

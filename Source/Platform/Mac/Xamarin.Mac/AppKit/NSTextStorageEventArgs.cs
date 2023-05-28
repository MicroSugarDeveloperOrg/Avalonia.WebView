using Foundation;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public class NSTextStorageEventArgs : EventArgs
{
	public nint Delta { get; set; }

	public NSTextStorageEditActions EditedMask { get; set; }

	public NSRange EditedRange { get; set; }

	public NSTextStorageEventArgs(NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
	{
		Delta = delta;
		EditedMask = editedMask;
		EditedRange = editedRange;
	}
}

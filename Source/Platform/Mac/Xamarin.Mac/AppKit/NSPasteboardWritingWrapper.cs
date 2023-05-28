using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSPasteboardWritingWrapper : BaseWrapper, INSPasteboardWriting, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSPasteboardWritingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

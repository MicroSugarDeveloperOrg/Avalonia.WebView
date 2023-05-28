using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSFontChangingWrapper : BaseWrapper, INSFontChanging, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSFontChangingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

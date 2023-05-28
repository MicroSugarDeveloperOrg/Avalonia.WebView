using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSWindowRestorationWrapper : BaseWrapper, INSWindowRestoration, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSWindowRestorationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

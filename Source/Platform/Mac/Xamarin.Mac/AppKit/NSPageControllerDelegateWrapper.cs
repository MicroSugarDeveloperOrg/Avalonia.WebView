using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSPageControllerDelegateWrapper : BaseWrapper, INSPageControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSPageControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

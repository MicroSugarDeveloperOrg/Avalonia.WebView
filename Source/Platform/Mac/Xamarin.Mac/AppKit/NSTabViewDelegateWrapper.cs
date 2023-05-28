using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTabViewDelegateWrapper : BaseWrapper, INSTabViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTabViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSOutlineViewDelegateWrapper : BaseWrapper, INSOutlineViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSOutlineViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSLayoutManagerDelegateWrapper : BaseWrapper, INSLayoutManagerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSLayoutManagerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

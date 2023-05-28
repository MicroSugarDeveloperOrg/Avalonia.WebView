using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSGestureRecognizerDelegateWrapper : BaseWrapper, INSGestureRecognizerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSGestureRecognizerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

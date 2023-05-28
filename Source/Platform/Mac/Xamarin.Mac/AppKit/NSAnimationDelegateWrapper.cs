using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSAnimationDelegateWrapper : BaseWrapper, INSAnimationDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSAnimationDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

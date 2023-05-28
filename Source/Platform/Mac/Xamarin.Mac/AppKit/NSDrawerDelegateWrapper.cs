using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSDrawerDelegateWrapper : BaseWrapper, INSDrawerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSDrawerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

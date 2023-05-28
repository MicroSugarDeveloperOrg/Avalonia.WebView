using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSWindowDelegateWrapper : BaseWrapper, INSWindowDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSWindowDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

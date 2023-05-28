using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSImageDelegateWrapper : BaseWrapper, INSImageDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSImageDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

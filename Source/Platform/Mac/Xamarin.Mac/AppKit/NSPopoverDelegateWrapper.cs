using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSPopoverDelegateWrapper : BaseWrapper, INSPopoverDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSPopoverDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

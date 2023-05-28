using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTableViewDelegateWrapper : BaseWrapper, INSTableViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTableViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

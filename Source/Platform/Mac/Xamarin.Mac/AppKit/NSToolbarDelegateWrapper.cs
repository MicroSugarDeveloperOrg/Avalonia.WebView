using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSToolbarDelegateWrapper : BaseWrapper, INSToolbarDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSToolbarDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

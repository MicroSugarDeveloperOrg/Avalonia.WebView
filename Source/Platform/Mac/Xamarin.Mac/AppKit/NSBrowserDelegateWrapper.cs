using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSBrowserDelegateWrapper : BaseWrapper, INSBrowserDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSBrowserDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

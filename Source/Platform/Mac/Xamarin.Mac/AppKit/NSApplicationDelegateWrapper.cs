using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSApplicationDelegateWrapper : BaseWrapper, INSApplicationDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSApplicationDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

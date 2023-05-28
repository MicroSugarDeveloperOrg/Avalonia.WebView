using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSAlertDelegateWrapper : BaseWrapper, INSAlertDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSAlertDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

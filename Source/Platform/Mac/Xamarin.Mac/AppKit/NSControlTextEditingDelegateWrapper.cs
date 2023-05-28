using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSControlTextEditingDelegateWrapper : BaseWrapper, INSControlTextEditingDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSControlTextEditingDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSPathControlDelegateWrapper : BaseWrapper, INSPathControlDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSPathControlDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

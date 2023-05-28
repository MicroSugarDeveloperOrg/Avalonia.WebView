using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSSharingServiceDelegateWrapper : BaseWrapper, INSSharingServiceDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSSharingServiceDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

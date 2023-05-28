using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSServicesMenuRequestorWrapper : BaseWrapper, INSServicesMenuRequestor, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSServicesMenuRequestorWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

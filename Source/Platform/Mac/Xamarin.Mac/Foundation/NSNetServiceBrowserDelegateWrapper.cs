using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSNetServiceBrowserDelegateWrapper : BaseWrapper, INSNetServiceBrowserDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSNetServiceBrowserDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

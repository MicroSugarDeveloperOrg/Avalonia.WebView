using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSNetServiceDelegateWrapper : BaseWrapper, INSNetServiceDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSNetServiceDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

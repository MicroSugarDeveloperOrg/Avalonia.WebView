using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSPortDelegateWrapper : BaseWrapper, INSPortDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSPortDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

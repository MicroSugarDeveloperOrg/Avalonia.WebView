using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSConnectionDelegateWrapper : BaseWrapper, INSConnectionDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSConnectionDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

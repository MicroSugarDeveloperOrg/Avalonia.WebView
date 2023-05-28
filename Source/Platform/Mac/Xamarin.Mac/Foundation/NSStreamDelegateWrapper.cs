using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSStreamDelegateWrapper : BaseWrapper, INSStreamDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSStreamDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

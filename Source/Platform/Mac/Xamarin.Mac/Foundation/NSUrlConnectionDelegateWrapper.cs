using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUrlConnectionDelegateWrapper : BaseWrapper, INSUrlConnectionDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSUrlConnectionDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

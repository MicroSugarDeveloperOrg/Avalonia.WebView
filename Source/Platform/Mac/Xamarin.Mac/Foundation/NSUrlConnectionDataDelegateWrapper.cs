using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUrlConnectionDataDelegateWrapper : BaseWrapper, INSUrlConnectionDataDelegate, INativeObject, IDisposable, INSUrlConnectionDelegate
{
	[Preserve(Conditional = true)]
	public NSUrlConnectionDataDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

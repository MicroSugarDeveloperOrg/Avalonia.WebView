using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUrlSessionDelegateWrapper : BaseWrapper, INSUrlSessionDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSUrlSessionDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

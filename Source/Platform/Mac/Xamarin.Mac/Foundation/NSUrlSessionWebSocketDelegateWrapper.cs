using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUrlSessionWebSocketDelegateWrapper : BaseWrapper, INSUrlSessionWebSocketDelegate, INativeObject, IDisposable, INSUrlSessionTaskDelegate, INSUrlSessionDelegate
{
	[Preserve(Conditional = true)]
	public NSUrlSessionWebSocketDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

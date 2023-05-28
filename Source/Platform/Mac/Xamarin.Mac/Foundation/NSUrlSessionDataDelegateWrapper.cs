using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUrlSessionDataDelegateWrapper : BaseWrapper, INSUrlSessionDataDelegate, INativeObject, IDisposable, INSUrlSessionTaskDelegate, INSUrlSessionDelegate
{
	[Preserve(Conditional = true)]
	public NSUrlSessionDataDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

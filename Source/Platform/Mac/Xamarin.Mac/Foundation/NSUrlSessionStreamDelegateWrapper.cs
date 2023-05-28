using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUrlSessionStreamDelegateWrapper : BaseWrapper, INSUrlSessionStreamDelegate, INativeObject, IDisposable, INSUrlSessionTaskDelegate, INSUrlSessionDelegate
{
	[Preserve(Conditional = true)]
	public NSUrlSessionStreamDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

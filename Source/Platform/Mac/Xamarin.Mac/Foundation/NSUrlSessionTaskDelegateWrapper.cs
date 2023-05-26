using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUrlSessionTaskDelegateWrapper : BaseWrapper, INSUrlSessionTaskDelegate, INativeObject, IDisposable, INSUrlSessionDelegate
{
	[Preserve(Conditional = true)]
	public NSUrlSessionTaskDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

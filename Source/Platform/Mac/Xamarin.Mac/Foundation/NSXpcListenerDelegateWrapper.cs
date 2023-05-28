using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSXpcListenerDelegateWrapper : BaseWrapper, INSXpcListenerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSXpcListenerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

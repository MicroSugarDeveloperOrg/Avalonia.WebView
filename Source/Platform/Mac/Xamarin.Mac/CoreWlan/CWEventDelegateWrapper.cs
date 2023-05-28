using System;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

internal sealed class CWEventDelegateWrapper : BaseWrapper, ICWEventDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CWEventDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

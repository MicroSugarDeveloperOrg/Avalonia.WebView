using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSMachPortDelegateWrapper : BaseWrapper, INSMachPortDelegate, INativeObject, IDisposable, INSPortDelegate
{
	[Preserve(Conditional = true)]
	public NSMachPortDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

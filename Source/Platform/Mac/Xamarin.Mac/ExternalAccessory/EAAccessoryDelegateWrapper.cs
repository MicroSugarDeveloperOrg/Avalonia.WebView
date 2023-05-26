using System;
using Foundation;
using ObjCRuntime;

namespace ExternalAccessory;

internal sealed class EAAccessoryDelegateWrapper : BaseWrapper, IEAAccessoryDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public EAAccessoryDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

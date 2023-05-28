using System;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

internal sealed class CBPeripheralDelegateWrapper : BaseWrapper, ICBPeripheralDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CBPeripheralDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

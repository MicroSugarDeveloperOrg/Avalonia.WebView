using System;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

internal sealed class CBPeripheralManagerDelegateWrapper : BaseWrapper, ICBPeripheralManagerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CBPeripheralManagerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("peripheralManagerDidUpdateState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void StateUpdated(CBPeripheralManager peripheral)
	{
		if (peripheral == null)
		{
			throw new ArgumentNullException("peripheral");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("peripheralManagerDidUpdateState:"), peripheral.Handle);
	}
}

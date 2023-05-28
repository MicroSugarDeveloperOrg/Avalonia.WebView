using System;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

internal sealed class CBCentralManagerDelegateWrapper : BaseWrapper, ICBCentralManagerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CBCentralManagerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("centralManagerDidUpdateState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void UpdatedState(CBCentralManager central)
	{
		if (central == null)
		{
			throw new ArgumentNullException("central");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("centralManagerDidUpdateState:"), central.Handle);
	}
}

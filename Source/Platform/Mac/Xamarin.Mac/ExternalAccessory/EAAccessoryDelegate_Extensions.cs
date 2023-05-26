using System;
using ObjCRuntime;

namespace ExternalAccessory;

public static class EAAccessoryDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Disconnected(this IEAAccessoryDelegate This, EAAccessory accessory)
	{
		if (accessory == null)
		{
			throw new ArgumentNullException("accessory");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("accessoryDidDisconnect:"), accessory.Handle);
	}
}

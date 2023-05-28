using System;
using ObjCRuntime;

namespace Foundation;

public static class NSMachPortDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MachMessageReceived(this INSMachPortDelegate This, IntPtr msgHeader)
	{
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("handleMachMessage:"), msgHeader);
	}
}

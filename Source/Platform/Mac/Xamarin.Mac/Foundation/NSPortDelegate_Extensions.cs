using System;
using ObjCRuntime;

namespace Foundation;

public static class NSPortDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MessageReceived(this INSPortDelegate This, NSPortMessage message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("handlePortMessage:"), message.Handle);
	}
}

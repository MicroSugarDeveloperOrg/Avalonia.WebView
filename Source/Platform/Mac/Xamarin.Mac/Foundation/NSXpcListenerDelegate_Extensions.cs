using System;
using ObjCRuntime;

namespace Foundation;

public static class NSXpcListenerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldAcceptConnection(this INSXpcListenerDelegate This, NSXpcListener listener, NSXpcConnection newConnection)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		if (newConnection == null)
		{
			throw new ArgumentNullException("newConnection");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("listener:shouldAcceptNewConnection:"), listener.Handle, newConnection.Handle);
	}
}

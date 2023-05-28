using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrlSessionWebSocketDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidOpen(this INSUrlSessionWebSocketDelegate This, NSUrlSession session, NSUrlSessionWebSocketTask webSocketTask, string? protocol)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (webSocketTask == null)
		{
			throw new ArgumentNullException("webSocketTask");
		}
		IntPtr intPtr = NSString.CreateNative(protocol);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("URLSession:webSocketTask:didOpenWithProtocol:"), session.Handle, webSocketTask.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidClose(this INSUrlSessionWebSocketDelegate This, NSUrlSession session, NSUrlSessionWebSocketTask webSocketTask, NSUrlSessionWebSocketCloseCode closeCode, NSData? reason)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (webSocketTask == null)
		{
			throw new ArgumentNullException("webSocketTask");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr(This.Handle, Selector.GetHandle("URLSession:webSocketTask:didCloseWithCode:reason:"), session.Handle, webSocketTask.Handle, (long)closeCode, reason?.Handle ?? IntPtr.Zero);
	}
}

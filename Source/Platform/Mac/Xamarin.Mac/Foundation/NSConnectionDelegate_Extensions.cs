using System;
using ObjCRuntime;

namespace Foundation;

public static class NSConnectionDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AuthenticateComponents(this INSConnectionDelegate This, NSArray components, NSData authenticationData)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		if (authenticationData == null)
		{
			throw new ArgumentNullException("authenticationData");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("authenticateComponents:withData:"), components.Handle, authenticationData.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData GetAuthenticationData(this INSConnectionDelegate This, NSArray components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("authenticationDataForComponents:"), components.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldMakeNewConnection(this INSConnectionDelegate This, NSConnection parentConnection, NSConnection newConnection)
	{
		if (parentConnection == null)
		{
			throw new ArgumentNullException("parentConnection");
		}
		if (newConnection == null)
		{
			throw new ArgumentNullException("newConnection");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:shouldMakeNewConnection:"), parentConnection.Handle, newConnection.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool HandleRequest(this INSConnectionDelegate This, NSConnection connection, NSDistantObjectRequest request)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("connection:handleRequest:"), connection.Handle, request.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject CreateConversation(this INSConnectionDelegate This, NSConnection connection)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("createConversationForConnection:"), connection.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AllowNewConnection(this INSConnectionDelegate This, NSConnection newConnection, NSConnection parentConnection)
	{
		if (newConnection == null)
		{
			throw new ArgumentNullException("newConnection");
		}
		if (parentConnection == null)
		{
			throw new ArgumentNullException("parentConnection");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("makeNewConnection:sender:"), newConnection.Handle, parentConnection.Handle);
	}
}

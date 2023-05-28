using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

public static class GKGameSessionEventListener_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidAddPlayer(this IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("session:didAddPlayer:"), session.Handle, player.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidRemovePlayer(this IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("session:didRemovePlayer:"), session.Handle, player.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeConnectionState(this IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player, GKConnectionState newState)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64(This.Handle, Selector.GetHandle("session:player:didChangeConnectionState:"), session.Handle, player.Handle, (long)newState);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidSaveData(this IGKGameSessionEventListener This, GKGameSession session, GKCloudPlayer player, NSData data)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("session:player:didSaveData:"), session.Handle, player.Handle, data.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidReceiveData(this IGKGameSessionEventListener This, GKGameSession session, NSData data, GKCloudPlayer player)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("session:didReceiveData:fromPlayer:"), session.Handle, data.Handle, player.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidReceiveMessage(this IGKGameSessionEventListener This, GKGameSession session, string message, NSData data, GKCloudPlayer player)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		IntPtr intPtr = NSString.CreateNative(message);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("session:didReceiveMessage:withData:fromPlayer:"), session.Handle, intPtr, data.Handle, player.Handle);
		NSString.ReleaseNative(intPtr);
	}
}

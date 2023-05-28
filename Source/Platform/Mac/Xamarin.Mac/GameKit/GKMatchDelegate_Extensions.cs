using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

public static class GKMatchDelegate_Extensions
{
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'DataReceivedFromPlayer (GKMatch,NSData,GKPlayer)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'DataReceivedFromPlayer (GKMatch,NSData,GKPlayer)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DataReceived(this IGKMatchDelegate This, GKMatch match, NSData data, string playerId)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (playerId == null)
		{
			throw new ArgumentNullException("playerId");
		}
		IntPtr intPtr = NSString.CreateNative(playerId);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("match:didReceiveData:fromPlayer:"), match.Handle, data.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'StateChangedForPlayer (GKMatch,GKPlayer,GKPlayerConnectionState)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Use 'StateChangedForPlayer (GKMatch,GKPlayer,GKPlayerConnectionState)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void StateChanged(this IGKMatchDelegate This, GKMatch match, string playerId, GKPlayerConnectionState state)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		if (playerId == null)
		{
			throw new ArgumentNullException("playerId");
		}
		IntPtr intPtr = NSString.CreateNative(playerId);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64(This.Handle, Selector.GetHandle("match:player:didChangeState:"), match.Handle, intPtr, (long)state);
		NSString.ReleaseNative(intPtr);
	}

	[Obsolete("It will never be called.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ConnectionFailed(this IGKMatchDelegate This, GKMatch match, string playerId, NSError error)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		if (playerId == null)
		{
			throw new ArgumentNullException("playerId");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		IntPtr intPtr = NSString.CreateNative(playerId);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("xamarin:selector:removed:"), match.Handle, intPtr, error.Handle);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Failed(this IGKMatchDelegate This, GKMatch match, NSError? error)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("match:didFailWithError:"), match.Handle, error?.Handle ?? IntPtr.Zero);
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'ShouldReinviteDisconnectedPlayer' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'ShouldReinviteDisconnectedPlayer' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldReinvitePlayer(this IGKMatchDelegate This, GKMatch match, string playerId)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		if (playerId == null)
		{
			throw new ArgumentNullException("playerId");
		}
		IntPtr intPtr = NSString.CreateNative(playerId);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("match:shouldReinvitePlayer:"), match.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DataReceivedFromPlayer(this IGKMatchDelegate This, GKMatch match, NSData data, GKPlayer player)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("match:didReceiveData:fromRemotePlayer:"), match.Handle, data.Handle, player.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void StateChangedForPlayer(this IGKMatchDelegate This, GKMatch match, GKPlayer player, GKPlayerConnectionState state)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64(This.Handle, Selector.GetHandle("match:player:didChangeConnectionState:"), match.Handle, player.Handle, (long)state);
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldReinviteDisconnectedPlayer(this IGKMatchDelegate This, GKMatch match, GKPlayer player)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("match:shouldReinviteDisconnectedPlayer:"), match.Handle, player.Handle);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DataReceivedForRecipient(this IGKMatchDelegate This, GKMatch match, NSData data, GKPlayer recipient, GKPlayer player)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (recipient == null)
		{
			throw new ArgumentNullException("recipient");
		}
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("match:didReceiveData:forRecipient:fromRemotePlayer:"), match.Handle, data.Handle, recipient.Handle, player.Handle);
	}
}

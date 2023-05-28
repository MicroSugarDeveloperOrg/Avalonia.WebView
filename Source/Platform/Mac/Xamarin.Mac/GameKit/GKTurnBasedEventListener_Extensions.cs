using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

public static class GKTurnBasedEventListener_Extensions
{
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.All, "Use 'DidRequestMatchWithOtherPlayers' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidRequestMatchWithPlayers(this IGKTurnBasedEventListener This, GKPlayer player, string[] playerIDsToInvite)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (playerIDsToInvite == null)
		{
			throw new ArgumentNullException("playerIDsToInvite");
		}
		NSArray nSArray = NSArray.FromStrings(playerIDsToInvite);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:didRequestMatchWithPlayers:"), player.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedTurnEvent(this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedMatch match, bool becameActive)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(This.Handle, Selector.GetHandle("player:receivedTurnEventForMatch:didBecomeActive:"), player.Handle, match.Handle, becameActive);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MatchEnded(this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedMatch match)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:matchEnded:"), player.Handle, match.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedExchangeRequest(this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (exchange == null)
		{
			throw new ArgumentNullException("exchange");
		}
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:receivedExchangeRequest:forMatch:"), player.Handle, exchange.Handle, match.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedExchangeCancellation(this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (exchange == null)
		{
			throw new ArgumentNullException("exchange");
		}
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:receivedExchangeCancellation:forMatch:"), player.Handle, exchange.Handle, match.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedExchangeReplies(this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedExchangeReply[] replies, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (replies == null)
		{
			throw new ArgumentNullException("replies");
		}
		if (exchange == null)
		{
			throw new ArgumentNullException("exchange");
		}
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		NSArray nSArray = NSArray.FromNSObjects(replies);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:receivedExchangeReplies:forCompletedExchange:forMatch:"), player.Handle, nSArray.Handle, exchange.Handle, match.Handle);
		nSArray.Dispose();
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidRequestMatchWithOtherPlayers(this IGKTurnBasedEventListener This, GKPlayer player, GKPlayer[] playersToInvite)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (playersToInvite == null)
		{
			throw new ArgumentNullException("playersToInvite");
		}
		NSArray nSArray = NSArray.FromNSObjects(playersToInvite);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:didRequestMatchWithOtherPlayers:"), player.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WantsToQuitMatch(this IGKTurnBasedEventListener This, GKPlayer player, GKTurnBasedMatch match)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:wantsToQuitMatch:"), player.Handle, match.Handle);
	}
}

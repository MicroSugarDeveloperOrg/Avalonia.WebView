using System;
using ObjCRuntime;

namespace GameKit;

public static class GKChallengeListener_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WantsToPlayChallenge(this IGKChallengeListener This, GKPlayer player, GKChallenge challenge)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:wantsToPlayChallenge:"), player.Handle, challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidReceiveChallenge(this IGKChallengeListener This, GKPlayer player, GKChallenge challenge)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:didReceiveChallenge:"), player.Handle, challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCompleteChallenge(this IGKChallengeListener This, GKPlayer player, GKChallenge challenge, GKPlayer friendPlayer)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (friendPlayer == null)
		{
			throw new ArgumentNullException("friendPlayer");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:didCompleteChallenge:issuedByFriend:"), player.Handle, challenge.Handle, friendPlayer.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void IssuedChallengeWasCompleted(this IGKChallengeListener This, GKPlayer player, GKChallenge challenge, GKPlayer friendPlayer)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (friendPlayer == null)
		{
			throw new ArgumentNullException("friendPlayer");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:issuedChallengeWasCompleted:byFriend:"), player.Handle, challenge.Handle, friendPlayer.Handle);
	}
}

using System;
using ObjCRuntime;

namespace GameKit;

public static class GKChallengeEventHandlerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LocalPlayerSelectedChallenge(this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("localPlayerDidSelectChallenge:"), challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldShowBannerForLocallyReceivedChallenge(this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("shouldShowBannerForLocallyReceivedChallenge:"), challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LocalPlayerReceivedChallenge(this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("localPlayerDidReceiveChallenge:"), challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldShowBannerForLocallyCompletedChallenge(this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("shouldShowBannerForLocallyCompletedChallenge:"), challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LocalPlayerCompletedChallenge(this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("localPlayerDidCompleteChallenge:"), challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldShowBannerForRemotelyCompletedChallenge(this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("shouldShowBannerForRemotelyCompletedChallenge:"), challenge.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemotePlayerCompletedChallenge(this IGKChallengeEventHandlerDelegate This, GKChallenge challenge)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("remotePlayerDidCompleteChallenge:"), challenge.Handle);
	}
}

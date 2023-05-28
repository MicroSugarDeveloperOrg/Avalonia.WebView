using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Protocol]
[Register("GKTurnBasedEventListener", false)]
[Model]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class GKTurnBasedEventListener : NSObject, IGKTurnBasedEventListener, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKTurnBasedEventListener()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKTurnBasedEventListener(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKTurnBasedEventListener(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("player:didRequestMatchWithOtherPlayers:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRequestMatchWithOtherPlayers(GKPlayer player, GKPlayer[] playersToInvite)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:didRequestMatchWithPlayers:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.All, "Use 'DidRequestMatchWithOtherPlayers' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRequestMatchWithPlayers(GKPlayer player, string[] playerIDsToInvite)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:matchEnded:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MatchEnded(GKPlayer player, GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:receivedExchangeCancellation:forMatch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedExchangeCancellation(GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:receivedExchangeReplies:forCompletedExchange:forMatch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedExchangeReplies(GKPlayer player, GKTurnBasedExchangeReply[] replies, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:receivedExchangeRequest:forMatch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedExchangeRequest(GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:receivedTurnEventForMatch:didBecomeActive:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedTurnEvent(GKPlayer player, GKTurnBasedMatch match, bool becameActive)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:wantsToQuitMatch:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WantsToQuitMatch(GKPlayer player, GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

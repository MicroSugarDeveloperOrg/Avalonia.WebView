using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Protocol]
[Register("GKLocalPlayerListener", false)]
[Model]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class GKLocalPlayerListener : NSObject, IGKLocalPlayerListener, INativeObject, IDisposable, IGKChallengeListener, IGKInviteEventListener, IGKSavedGameListener, IGKTurnBasedEventListener
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKLocalPlayerListener()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKLocalPlayerListener(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKLocalPlayerListener(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("player:didAcceptInvite:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidAcceptInvite(GKPlayer player, GKInvite invite)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:didCompleteChallenge:issuedByFriend:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCompleteChallenge(GKPlayer player, GKChallenge challenge, GKPlayer friendPlayer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:didModifySavedGame:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidModifySavedGame(GKPlayer player, GKSavedGame savedGame)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:didReceiveChallenge:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveChallenge(GKPlayer player, GKChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:didRequestMatchWithRecipients:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRequestMatch(GKPlayer player, GKPlayer[] recipientPlayers)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:didRequestMatchWithOtherPlayers:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRequestMatchWithOtherPlayers(GKPlayer player, GKPlayer[] playersToInvite)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:didRequestMatchWithPlayers:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.All, "Use 'DidRequestMatchWithOtherPlayers' instead.")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRequestMatchWithPlayers(GKPlayer player, string[] playerIDsToInvite)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:hasConflictingSavedGames:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HasConflictingSavedGames(GKPlayer player, GKSavedGame[] savedGames)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:issuedChallengeWasCompleted:byFriend:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void IssuedChallengeWasCompleted(GKPlayer player, GKChallenge challenge, GKPlayer friendPlayer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:matchEnded:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MatchEnded(GKPlayer player, GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:receivedExchangeCancellation:forMatch:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedExchangeCancellation(GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:receivedExchangeReplies:forCompletedExchange:forMatch:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedExchangeReplies(GKPlayer player, GKTurnBasedExchangeReply[] replies, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:receivedExchangeRequest:forMatch:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedExchangeRequest(GKPlayer player, GKTurnBasedExchange exchange, GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:receivedTurnEventForMatch:didBecomeActive:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReceivedTurnEvent(GKPlayer player, GKTurnBasedMatch match, bool becameActive)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:wantsToPlayChallenge:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WantsToPlayChallenge(GKPlayer player, GKChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:wantsToQuitMatch:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WantsToQuitMatch(GKPlayer player, GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Protocol]
[Register("GKChallengeListener", false)]
[Model]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class GKChallengeListener : NSObject, IGKChallengeListener, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKChallengeListener()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKChallengeListener(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKChallengeListener(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("player:didCompleteChallenge:issuedByFriend:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCompleteChallenge(GKPlayer player, GKChallenge challenge, GKPlayer friendPlayer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:didReceiveChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveChallenge(GKPlayer player, GKChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:issuedChallengeWasCompleted:byFriend:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void IssuedChallengeWasCompleted(GKPlayer player, GKChallenge challenge, GKPlayer friendPlayer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("player:wantsToPlayChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WantsToPlayChallenge(GKPlayer player, GKChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

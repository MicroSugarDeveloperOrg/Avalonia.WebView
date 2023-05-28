using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Protocol]
[Register("GKChallengeEventHandlerDelegate", false)]
[Model]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class GKChallengeEventHandlerDelegate : NSObject, IGKChallengeEventHandlerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKChallengeEventHandlerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKChallengeEventHandlerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKChallengeEventHandlerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("localPlayerDidCompleteChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LocalPlayerCompletedChallenge(GKChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("localPlayerDidReceiveChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LocalPlayerReceivedChallenge(GKChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("localPlayerDidSelectChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LocalPlayerSelectedChallenge(GKChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("remotePlayerDidCompleteChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemotePlayerCompletedChallenge(GKChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("shouldShowBannerForLocallyCompletedChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldShowBannerForLocallyCompletedChallenge(GKChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("shouldShowBannerForLocallyReceivedChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldShowBannerForLocallyReceivedChallenge(GKChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("shouldShowBannerForRemotelyCompletedChallenge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldShowBannerForRemotelyCompletedChallenge(GKChallenge challenge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

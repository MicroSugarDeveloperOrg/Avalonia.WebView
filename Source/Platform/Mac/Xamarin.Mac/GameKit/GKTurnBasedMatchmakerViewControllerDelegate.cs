using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Protocol]
[Register("GKTurnBasedMatchmakerViewControllerDelegate", false)]
[Model]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public abstract class GKTurnBasedMatchmakerViewControllerDelegate : NSObject, IGKTurnBasedMatchmakerViewControllerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected GKTurnBasedMatchmakerViewControllerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKTurnBasedMatchmakerViewControllerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKTurnBasedMatchmakerViewControllerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("turnBasedMatchmakerViewController:didFailWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void FailedWithError(GKTurnBasedMatchmakerViewController viewController, NSError error);

	[Export("turnBasedMatchmakerViewController:didFindMatch:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.ReceivedTurnEvent' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void FoundMatch(GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match);

	[Export("turnBasedMatchmakerViewController:playerQuitForMatch:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'GKTurnBasedEventListener.WantsToQuitMatch' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void PlayerQuitForMatch(GKTurnBasedMatchmakerViewController viewController, GKTurnBasedMatch match);

	[Export("turnBasedMatchmakerViewControllerWasCancelled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void WasCancelled(GKTurnBasedMatchmakerViewController viewController);
}

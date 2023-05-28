using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Protocol]
[Register("GKTurnBasedEventHandlerDelegate", false)]
[Model]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKTurnBasedEventListener'.")]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKTurnBasedEventListener'.")]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public abstract class GKTurnBasedEventHandlerDelegate : NSObject, IGKTurnBasedEventHandlerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected GKTurnBasedEventHandlerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKTurnBasedEventHandlerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKTurnBasedEventHandlerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("handleInviteFromGameCenter:")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void HandleInviteFromGameCenter(NSString[] playersToInvite);

	[Export("handleMatchEnded:")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HandleMatchEnded(GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("handleTurnEventForMatch:didBecomeActive:")]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HandleTurnEvent(GKTurnBasedMatch match, bool activated)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("handleTurnEventForMatch:")]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'HandleTurnEvent' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'HandleTurnEvent' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HandleTurnEventForMatch(GKTurnBasedMatch match)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

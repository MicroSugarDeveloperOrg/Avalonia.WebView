using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Protocol]
[Register("GKMatchDelegate", false)]
[Model]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class GKMatchDelegate : NSObject, IGKMatchDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKMatchDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKMatchDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKMatchDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("xamarin:selector:removed:")]
	[Obsolete("It will never be called.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConnectionFailed(GKMatch match, string playerId, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("match:didReceiveData:fromPlayer:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'DataReceivedFromPlayer (GKMatch,NSData,GKPlayer)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'DataReceivedFromPlayer (GKMatch,NSData,GKPlayer)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DataReceived(GKMatch match, NSData data, string playerId)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("match:didReceiveData:forRecipient:fromRemotePlayer:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DataReceivedForRecipient(GKMatch match, NSData data, GKPlayer recipient, GKPlayer player)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("match:didReceiveData:fromRemotePlayer:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DataReceivedFromPlayer(GKMatch match, NSData data, GKPlayer player)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("match:didFailWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Failed(GKMatch match, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("match:shouldReinviteDisconnectedPlayer:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldReinviteDisconnectedPlayer(GKMatch match, GKPlayer player)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("match:shouldReinvitePlayer:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'ShouldReinviteDisconnectedPlayer' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'ShouldReinviteDisconnectedPlayer' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldReinvitePlayer(GKMatch match, string playerId)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("match:player:didChangeState:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'StateChangedForPlayer (GKMatch,GKPlayer,GKPlayerConnectionState)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Use 'StateChangedForPlayer (GKMatch,GKPlayer,GKPlayerConnectionState)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StateChanged(GKMatch match, string playerId, GKPlayerConnectionState state)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("match:player:didChangeConnectionState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StateChangedForPlayer(GKMatch match, GKPlayer player, GKPlayerConnectionState state)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

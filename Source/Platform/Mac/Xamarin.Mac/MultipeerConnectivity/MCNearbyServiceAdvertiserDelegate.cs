using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

[Protocol]
[Register("MCNearbyServiceAdvertiserDelegate", false)]
[Model]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public abstract class MCNearbyServiceAdvertiserDelegate : NSObject, IMCNearbyServiceAdvertiserDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected MCNearbyServiceAdvertiserDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MCNearbyServiceAdvertiserDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MCNearbyServiceAdvertiserDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("advertiser:didNotStartAdvertisingPeer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidNotStartAdvertisingPeer(MCNearbyServiceAdvertiser advertiser, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("advertiser:didReceiveInvitationFromPeer:withContext:invitationHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidReceiveInvitationFromPeer(MCNearbyServiceAdvertiser advertiser, MCPeerID peerID, NSData? context, [BlockProxy(typeof(Trampolines.NIDMCNearbyServiceAdvertiserInvitationHandler))] MCNearbyServiceAdvertiserInvitationHandler invitationHandler);
}

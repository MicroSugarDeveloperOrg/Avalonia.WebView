using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Security;

namespace MultipeerConnectivity;

[Protocol]
[Register("MCSessionDelegate", false)]
[Model]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public abstract class MCSessionDelegate : NSObject, IMCSessionDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected MCSessionDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MCSessionDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MCSessionDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("session:peer:didChangeState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidChangeState(MCSession session, MCPeerID peerID, MCSessionState state);

	[Export("session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidFinishReceivingResource(MCSession session, string resourceName, MCPeerID fromPeer, NSUrl? localUrl, NSError? error);

	[Export("session:didReceiveCertificate:fromPeer:certificateHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DidReceiveCertificate(MCSession session, SecCertificate[]? certificate, MCPeerID peerID, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> certificateHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("session:didReceiveData:fromPeer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidReceiveData(MCSession session, NSData data, MCPeerID peerID);

	[Export("session:didReceiveStream:withName:fromPeer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidReceiveStream(MCSession session, NSInputStream stream, string streamName, MCPeerID peerID);

	[Export("session:didStartReceivingResourceWithName:fromPeer:withProgress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidStartReceivingResource(MCSession session, string resourceName, MCPeerID fromPeer, NSProgress progress);
}

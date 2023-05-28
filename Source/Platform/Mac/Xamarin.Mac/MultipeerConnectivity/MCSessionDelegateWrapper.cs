using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

internal sealed class MCSessionDelegateWrapper : BaseWrapper, IMCSessionDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MCSessionDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("session:peer:didChangeState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidChangeState(MCSession session, MCPeerID peerID, MCSessionState state)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64(base.Handle, Selector.GetHandle("session:peer:didChangeState:"), session.Handle, peerID.Handle, (long)state);
	}

	[Export("session:didReceiveData:fromPeer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidReceiveData(MCSession session, NSData data, MCPeerID peerID)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("session:didReceiveData:fromPeer:"), session.Handle, data.Handle, peerID.Handle);
	}

	[Export("session:didStartReceivingResourceWithName:fromPeer:withProgress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidStartReceivingResource(MCSession session, string resourceName, MCPeerID fromPeer, NSProgress progress)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (resourceName == null)
		{
			throw new ArgumentNullException("resourceName");
		}
		if (fromPeer == null)
		{
			throw new ArgumentNullException("fromPeer");
		}
		if (progress == null)
		{
			throw new ArgumentNullException("progress");
		}
		IntPtr intPtr = NSString.CreateNative(resourceName);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("session:didStartReceivingResourceWithName:fromPeer:withProgress:"), session.Handle, intPtr, fromPeer.Handle, progress.Handle);
		NSString.ReleaseNative(intPtr);
	}

	[Export("session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFinishReceivingResource(MCSession session, string resourceName, MCPeerID fromPeer, NSUrl? localUrl, NSError? error)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (resourceName == null)
		{
			throw new ArgumentNullException("resourceName");
		}
		if (fromPeer == null)
		{
			throw new ArgumentNullException("fromPeer");
		}
		IntPtr intPtr = NSString.CreateNative(resourceName);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("session:didFinishReceivingResourceWithName:fromPeer:atURL:withError:"), session.Handle, intPtr, fromPeer.Handle, (localUrl == null) ? IntPtr.Zero : localUrl.Handle, error?.Handle ?? IntPtr.Zero);
		NSString.ReleaseNative(intPtr);
	}

	[Export("session:didReceiveStream:withName:fromPeer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidReceiveStream(MCSession session, NSInputStream stream, string streamName, MCPeerID peerID)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (streamName == null)
		{
			throw new ArgumentNullException("streamName");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		IntPtr intPtr = NSString.CreateNative(streamName);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("session:didReceiveStream:withName:fromPeer:"), session.Handle, stream.Handle, intPtr, peerID.Handle);
		NSString.ReleaseNative(intPtr);
	}
}

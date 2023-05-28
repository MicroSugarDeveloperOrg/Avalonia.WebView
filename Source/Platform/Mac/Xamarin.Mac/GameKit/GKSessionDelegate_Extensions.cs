using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

public static class GKSessionDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PeerChangedState(this IGKSessionDelegate This, GKSession session, string peerID, GKPeerConnectionState state)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		IntPtr intPtr = NSString.CreateNative(peerID);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_int(This.Handle, Selector.GetHandle("session:peer:didChangeState:"), session.Handle, intPtr, (int)state);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PeerConnectionRequest(this IGKSessionDelegate This, GKSession session, string peerID)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		IntPtr intPtr = NSString.CreateNative(peerID);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("session:didReceiveConnectionRequestFromPeer:"), session.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PeerConnectionFailed(this IGKSessionDelegate This, GKSession session, string peerID, NSError error)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		IntPtr intPtr = NSString.CreateNative(peerID);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("session:connectionWithPeerFailed:withError:"), session.Handle, intPtr, error.Handle);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FailedWithError(this IGKSessionDelegate This, GKSession session, NSError error)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("session:didFailWithError:"), session.Handle, error.Handle);
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

public static class MCNearbyServiceAdvertiserDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidNotStartAdvertisingPeer(this IMCNearbyServiceAdvertiserDelegate This, MCNearbyServiceAdvertiser advertiser, NSError error)
	{
		if (advertiser == null)
		{
			throw new ArgumentNullException("advertiser");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("advertiser:didNotStartAdvertisingPeer:"), advertiser.Handle, error.Handle);
	}
}

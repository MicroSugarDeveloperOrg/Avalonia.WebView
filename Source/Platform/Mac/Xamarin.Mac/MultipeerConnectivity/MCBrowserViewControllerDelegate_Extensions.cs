using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

public static class MCBrowserViewControllerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldPresentNearbyPeer(this IMCBrowserViewControllerDelegate This, MCBrowserViewController browserViewController, MCPeerID peerID, NSDictionary? info)
	{
		if (browserViewController == null)
		{
			throw new ArgumentNullException("browserViewController");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("browserViewController:shouldPresentNearbyPeer:withDiscoveryInfo:"), browserViewController.Handle, peerID.Handle, info?.Handle ?? IntPtr.Zero);
	}
}

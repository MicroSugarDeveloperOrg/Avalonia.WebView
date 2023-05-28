using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

internal sealed class MCNearbyServiceBrowserDelegateWrapper : BaseWrapper, IMCNearbyServiceBrowserDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MCNearbyServiceBrowserDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("browser:foundPeer:withDiscoveryInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FoundPeer(MCNearbyServiceBrowser browser, MCPeerID peerID, NSDictionary? info)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("browser:foundPeer:withDiscoveryInfo:"), browser.Handle, peerID.Handle, info?.Handle ?? IntPtr.Zero);
	}

	[Export("browser:lostPeer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void LostPeer(MCNearbyServiceBrowser browser, MCPeerID peerID)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (peerID == null)
		{
			throw new ArgumentNullException("peerID");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("browser:lostPeer:"), browser.Handle, peerID.Handle);
	}
}

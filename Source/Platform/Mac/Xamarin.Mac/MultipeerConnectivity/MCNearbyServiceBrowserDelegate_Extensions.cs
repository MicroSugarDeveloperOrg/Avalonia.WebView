using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

public static class MCNearbyServiceBrowserDelegate_Extensions
{
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidNotStartBrowsingForPeers(this IMCNearbyServiceBrowserDelegate This, MCNearbyServiceBrowser browser, NSError error)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("browser:didNotStartBrowsingForPeers:"), browser.Handle, error.Handle);
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

public static class GKMatchmakerViewControllerDelegate_Extensions
{
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'HostedPlayerDidAccept' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'HostedPlayerDidAccept' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ReceivedAcceptFromHostedPlayer(this IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController, string playerID)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (playerID == null)
		{
			throw new ArgumentNullException("playerID");
		}
		IntPtr intPtr = NSString.CreateNative(playerID);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("matchmakerViewController:didReceiveAcceptFromHostedPlayer:"), viewController.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void HostedPlayerDidAccept(this IGKMatchmakerViewControllerDelegate This, GKMatchmakerViewController viewController, GKPlayer playerID)
	{
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (playerID == null)
		{
			throw new ArgumentNullException("playerID");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("matchmakerViewController:hostedPlayerDidAccept:"), viewController.Handle, playerID.Handle);
	}
}

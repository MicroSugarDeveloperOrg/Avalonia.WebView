using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

public static class GKInviteEventListener_Extensions
{
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidAcceptInvite(this IGKInviteEventListener This, GKPlayer player, GKInvite invite)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (invite == null)
		{
			throw new ArgumentNullException("invite");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:didAcceptInvite:"), player.Handle, invite.Handle);
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidRequestMatch(this IGKInviteEventListener This, GKPlayer player, GKPlayer[] recipientPlayers)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (recipientPlayers == null)
		{
			throw new ArgumentNullException("recipientPlayers");
		}
		NSArray nSArray = NSArray.FromNSObjects(recipientPlayers);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:didRequestMatchWithRecipients:"), player.Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}

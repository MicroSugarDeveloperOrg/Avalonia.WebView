using System;
using ObjCRuntime;

namespace UserNotifications;

public static class UNUserNotificationCenterDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void WillPresentNotification(this IUNUserNotificationCenterDelegate This, UNUserNotificationCenter center, UNNotification notification, [BlockProxy(typeof(Trampolines.NIDActionArity1V92))] Action<UNNotificationPresentationOptions> completionHandler)
	{
		if (center == null)
		{
			throw new ArgumentNullException("center");
		}
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V92.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("userNotificationCenter:willPresentNotification:withCompletionHandler:"), center.Handle, notification.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DidReceiveNotificationResponse(this IUNUserNotificationCenterDelegate This, UNUserNotificationCenter center, UNNotificationResponse response, [BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		if (center == null)
		{
			throw new ArgumentNullException("center");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:"), center.Handle, response.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OpenSettings(this IUNUserNotificationCenterDelegate This, UNUserNotificationCenter center, UNNotification? notification)
	{
		if (center == null)
		{
			throw new ArgumentNullException("center");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("userNotificationCenter:openSettingsForNotification:"), center.Handle, notification?.Handle ?? IntPtr.Zero);
	}
}

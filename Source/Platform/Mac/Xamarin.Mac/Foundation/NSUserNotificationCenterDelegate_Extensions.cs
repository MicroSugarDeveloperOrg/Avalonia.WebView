using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUserNotificationCenterDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDeliverNotification(this INSUserNotificationCenterDelegate This, NSUserNotificationCenter center, NSUserNotification notification)
	{
		if (center == null)
		{
			throw new ArgumentNullException("center");
		}
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("userNotificationCenter:didDeliverNotification:"), center.Handle, notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidActivateNotification(this INSUserNotificationCenterDelegate This, NSUserNotificationCenter center, NSUserNotification notification)
	{
		if (center == null)
		{
			throw new ArgumentNullException("center");
		}
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("userNotificationCenter:didActivateNotification:"), center.Handle, notification.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldPresentNotification(this INSUserNotificationCenterDelegate This, NSUserNotificationCenter center, NSUserNotification notification)
	{
		if (center == null)
		{
			throw new ArgumentNullException("center");
		}
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("userNotificationCenter:shouldPresentNotification:"), center.Handle, notification.Handle);
	}
}

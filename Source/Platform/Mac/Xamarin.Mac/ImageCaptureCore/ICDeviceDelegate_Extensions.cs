using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

public static class ICDeviceDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidOpenSession(this IICDeviceDelegate This, ICDevice device, NSError? error)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("device:didOpenSessionWithError:"), device.Handle, error?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBecomeReady(this IICDeviceDelegate This, ICDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deviceDidBecomeReady:"), device.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCloseSession(this IICDeviceDelegate This, ICDevice device, NSError? error)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("device:didCloseSessionWithError:"), device.Handle, error?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeName(this IICDeviceDelegate This, ICDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deviceDidChangeName:"), device.Handle);
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeSharingState(this IICDeviceDelegate This, ICDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deviceDidChangeSharingState:"), device.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidReceiveStatusInformation(this IICDeviceDelegate This, ICDevice device, NSDictionary<NSString, NSObject> status)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (status == null)
		{
			throw new ArgumentNullException("status");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("device:didReceiveStatusInformation:"), device.Handle, status.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEncounterError(this IICDeviceDelegate This, ICDevice device, NSError? error)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("device:didEncounterError:"), device.Handle, error?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidReceiveButtonPress(this IICDeviceDelegate This, ICDevice device, NSString buttonType)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (buttonType == null)
		{
			throw new ArgumentNullException("buttonType");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("device:didReceiveButtonPress:"), device.Handle, buttonType.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidReceiveCustomNotification(this IICDeviceDelegate This, ICDevice device, NSDictionary<NSString, NSObject> notification, NSData data)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("device:didReceiveCustomNotification:data:"), device.Handle, notification.Handle, data.Handle);
	}
}

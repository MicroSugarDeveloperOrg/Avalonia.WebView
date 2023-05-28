using System;
using ObjCRuntime;

namespace ImageCaptureCore;

public static class ICDeviceBrowserDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeviceDidChangeName(this IICDeviceBrowserDelegate This, ICDeviceBrowser browser, ICDevice device)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("deviceBrowser:deviceDidChangeName:"), browser.Handle, device.Handle);
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeviceDidChangeSharingState(this IICDeviceBrowserDelegate This, ICDeviceBrowser browser, ICDevice device)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("deviceBrowser:deviceDidChangeSharingState:"), browser.Handle, device.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RequestsSelectDevice(this IICDeviceBrowserDelegate This, ICDeviceBrowser browser, ICDevice device)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("deviceBrowser:requestsSelectDevice:"), browser.Handle, device.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEnumerateLocalDevices(this IICDeviceBrowserDelegate This, ICDeviceBrowser browser)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("deviceBrowserDidEnumerateLocalDevices:"), browser.Handle);
	}
}

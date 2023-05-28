using System;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

public static class CWEventDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ClientConnectionInterrupted(this ICWEventDelegate This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("clientConnectionInterrupted"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ClientConnectionInvalidated(this ICWEventDelegate This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("clientConnectionInvalidated"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PowerStateDidChangeForWiFi(this ICWEventDelegate This, string interfaceName)
	{
		if (interfaceName == null)
		{
			throw new ArgumentNullException("interfaceName");
		}
		IntPtr intPtr = NSString.CreateNative(interfaceName);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("powerStateDidChangeForWiFiInterfaceWithName:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SsidDidChangeForWiFi(this ICWEventDelegate This, string interfaceName)
	{
		if (interfaceName == null)
		{
			throw new ArgumentNullException("interfaceName");
		}
		IntPtr intPtr = NSString.CreateNative(interfaceName);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("ssidDidChangeForWiFiInterfaceWithName:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void BssidDidChangeForWiFi(this ICWEventDelegate This, string interfaceName)
	{
		if (interfaceName == null)
		{
			throw new ArgumentNullException("interfaceName");
		}
		IntPtr intPtr = NSString.CreateNative(interfaceName);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("bssidDidChangeForWiFiInterfaceWithName:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CountryCodeDidChangeForWiFi(this ICWEventDelegate This, string interfaceName)
	{
		if (interfaceName == null)
		{
			throw new ArgumentNullException("interfaceName");
		}
		IntPtr intPtr = NSString.CreateNative(interfaceName);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("countryCodeDidChangeForWiFiInterfaceWithName:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LinkDidChangeForWiFi(this ICWEventDelegate This, string interfaceName)
	{
		if (interfaceName == null)
		{
			throw new ArgumentNullException("interfaceName");
		}
		IntPtr intPtr = NSString.CreateNative(interfaceName);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("linkDidChangeForWiFiInterfaceWithName:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LinkQualityDidChangeForWiFi(this ICWEventDelegate This, string interfaceName, int rssi, double transmitRate)
	{
		if (interfaceName == null)
		{
			throw new ArgumentNullException("interfaceName");
		}
		IntPtr intPtr = NSString.CreateNative(interfaceName);
		Messaging.void_objc_msgSend_IntPtr_int_Double(This.Handle, Selector.GetHandle("linkQualityDidChangeForWiFiInterfaceWithName:rssi:transmitRate:"), intPtr, rssi, transmitRate);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ModeDidChangeForWiFi(this ICWEventDelegate This, string interfaceName)
	{
		if (interfaceName == null)
		{
			throw new ArgumentNullException("interfaceName");
		}
		IntPtr intPtr = NSString.CreateNative(interfaceName);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("modeDidChangeForWiFiInterfaceWithName:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ScanCacheUpdatedForWiFi(this ICWEventDelegate This, string interfaceName)
	{
		if (interfaceName == null)
		{
			throw new ArgumentNullException("interfaceName");
		}
		IntPtr intPtr = NSString.CreateNative(interfaceName);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("scanCacheUpdatedForWiFiInterfaceWithName:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}
}

using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;

namespace SystemConfiguration;

public static class CaptiveNetwork
{
	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern IntPtr CNCopySupportedInterfaces();

	public static StatusCode TryGetSupportedInterfaces(out string[] supportedInterfaces)
	{
		IntPtr intPtr = CNCopySupportedInterfaces();
		if (intPtr == IntPtr.Zero)
		{
			supportedInterfaces = null;
			return StatusCodeError.SCError();
		}
		supportedInterfaces = NSArray.StringArrayFromHandle(intPtr);
		CFObject.CFRelease(intPtr);
		return StatusCode.OK;
	}

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern bool CNMarkPortalOffline(IntPtr interfaceName);

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern bool CNMarkPortalOnline(IntPtr interfaceName);

	public static bool MarkPortalOnline(string iface)
	{
		using NSString nSString = new NSString(iface);
		return CNMarkPortalOnline(nSString.Handle);
	}

	public static bool MarkPortalOffline(string iface)
	{
		using NSString nSString = new NSString(iface);
		return CNMarkPortalOffline(nSString.Handle);
	}

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern bool CNSetSupportedSSIDs(IntPtr ssidArray);

	public static bool SetSupportedSSIDs(string[] ssids)
	{
		using NSArray nSArray = NSArray.FromStrings(ssids);
		return CNSetSupportedSSIDs(nSArray.Handle);
	}
}

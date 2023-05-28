using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

public static class ICScannerDeviceDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidBecomeAvailable(this IICScannerDeviceDelegate This, ICScannerDevice scanner)
	{
		if (scanner == null)
		{
			throw new ArgumentNullException("scanner");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("scannerDeviceDidBecomeAvailable:"), scanner.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidSelectFunctionalUnit(this IICScannerDeviceDelegate This, ICScannerDevice scanner, ICScannerFunctionalUnit functionalUnit, NSError? error)
	{
		if (scanner == null)
		{
			throw new ArgumentNullException("scanner");
		}
		if (functionalUnit == null)
		{
			throw new ArgumentNullException("functionalUnit");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("scannerDevice:didSelectFunctionalUnit:error:"), scanner.Handle, functionalUnit.Handle, error?.Handle ?? IntPtr.Zero);
	}

	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidScanToUrl(this IICScannerDeviceDelegate This, ICScannerDevice scanner, NSUrl url, NSData data)
	{
		if (scanner == null)
		{
			throw new ArgumentNullException("scanner");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("scannerDevice:didScanToURL:data:"), scanner.Handle, url.Handle, data.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidScanToUrl(this IICScannerDeviceDelegate This, ICScannerDevice scanner, NSUrl url)
	{
		if (scanner == null)
		{
			throw new ArgumentNullException("scanner");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("scannerDevice:didScanToURL:"), scanner.Handle, url.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidScanToBandData(this IICScannerDeviceDelegate This, ICScannerDevice scanner, ICScannerBandData data)
	{
		if (scanner == null)
		{
			throw new ArgumentNullException("scanner");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("scannerDevice:didScanToBandData:"), scanner.Handle, data.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCompleteOverviewScan(this IICScannerDeviceDelegate This, ICScannerDevice scanner, NSError? error)
	{
		if (scanner == null)
		{
			throw new ArgumentNullException("scanner");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("scannerDevice:didCompleteOverviewScanWithError:"), scanner.Handle, error?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCompleteScan(this IICScannerDeviceDelegate This, ICScannerDevice scanner, NSError? error)
	{
		if (scanner == null)
		{
			throw new ArgumentNullException("scanner");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("scannerDevice:didCompleteScanWithError:"), scanner.Handle, error?.Handle ?? IntPtr.Zero);
	}
}

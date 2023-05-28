using System;
using Foundation;
using ImageCaptureCore;
using ObjCRuntime;

namespace ImageKit;

public static class IKScannerDeviceViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidScan(this IIKScannerDeviceViewDelegate This, IKScannerDeviceView scannerDeviceView, NSUrl url, NSData data, NSError error)
	{
		if (scannerDeviceView == null)
		{
			throw new ArgumentNullException("scannerDeviceView");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("scannerDeviceView:didScanToURL:fileData:error:"), scannerDeviceView.Handle, url.Handle, data.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEncounterError(this IIKScannerDeviceViewDelegate This, IKScannerDeviceView scannerDeviceView, NSError error)
	{
		if (scannerDeviceView == null)
		{
			throw new ArgumentNullException("scannerDeviceView");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("scannerDeviceView:didEncounterError:"), scannerDeviceView.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidScanToUrl(this IIKScannerDeviceViewDelegate This, IKScannerDeviceView scannerDeviceView, NSUrl url, NSError error)
	{
		if (scannerDeviceView == null)
		{
			throw new ArgumentNullException("scannerDeviceView");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("scannerDeviceView:didScanToURL:error:"), scannerDeviceView.Handle, url.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidScanToBandData(this IIKScannerDeviceViewDelegate This, IKScannerDeviceView scannerDeviceView, ICScannerBandData data, NSDictionary scanInfo, NSError error)
	{
		if (scannerDeviceView == null)
		{
			throw new ArgumentNullException("scannerDeviceView");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (scanInfo == null)
		{
			throw new ArgumentNullException("scanInfo");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("scannerDeviceView:didScanToBandData:scanInfo:error:"), scannerDeviceView.Handle, data.Handle, scanInfo.Handle, error.Handle);
	}
}

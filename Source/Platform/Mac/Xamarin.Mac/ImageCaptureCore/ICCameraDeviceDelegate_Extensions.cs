using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

public static class ICCameraDeviceDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidAddItems(this IICCameraDeviceDelegate This, ICCameraDevice camera, ICCameraItem[] items)
	{
		if (camera == null)
		{
			throw new ArgumentNullException("camera");
		}
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("cameraDevice:didAddItems:"), camera.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidRemoveItems(this IICCameraDeviceDelegate This, ICCameraDevice camera, ICCameraItem[] items)
	{
		if (camera == null)
		{
			throw new ArgumentNullException("camera");
		}
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("cameraDevice:didRemoveItems:"), camera.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldGetThumbnail(this IICCameraDeviceDelegate This, ICCameraDevice cameraDevice, ICCameraItem ofItem)
	{
		if (cameraDevice == null)
		{
			throw new ArgumentNullException("cameraDevice");
		}
		if (ofItem == null)
		{
			throw new ArgumentNullException("ofItem");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("cameraDevice:shouldGetThumbnailOfItem:"), cameraDevice.Handle, ofItem.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldGetMetadata(this IICCameraDeviceDelegate This, ICCameraDevice cameraDevice, ICCameraItem ofItem)
	{
		if (cameraDevice == null)
		{
			throw new ArgumentNullException("cameraDevice");
		}
		if (ofItem == null)
		{
			throw new ArgumentNullException("ofItem");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("cameraDevice:shouldGetMetadataOfItem:"), cameraDevice.Handle, ofItem.Handle);
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

internal sealed class ICCameraDeviceDelegateWrapper : BaseWrapper, IICCameraDeviceDelegate, INativeObject, IDisposable, IICDeviceDelegate
{
	[Preserve(Conditional = true)]
	public ICCameraDeviceDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("cameraDevice:didAddItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidAddItem(ICCameraDevice camera, ICCameraItem item)
	{
		if (camera == null)
		{
			throw new ArgumentNullException("camera");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("cameraDevice:didAddItem:"), camera.Handle, item.Handle);
	}

	[Export("cameraDevice:didRemoveItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidRemoveItem(ICCameraDevice camera, ICCameraItem item)
	{
		if (camera == null)
		{
			throw new ArgumentNullException("camera");
		}
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("cameraDevice:didRemoveItem:"), camera.Handle, item.Handle);
	}

	[Export("cameraDevice:didRenameItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidRenameItems(ICCameraDevice camera, ICCameraItem[] items)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("cameraDevice:didRenameItems:"), camera.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("cameraDevice:didCompleteDeleteFilesWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidCompleteDeleteFiles(ICCameraDevice scanner, NSError? error)
	{
		if (scanner == null)
		{
			throw new ArgumentNullException("scanner");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("cameraDevice:didCompleteDeleteFilesWithError:"), scanner.Handle, error?.Handle ?? IntPtr.Zero);
	}

	[Export("cameraDeviceDidChangeCapability:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidChangeCapability(ICCameraDevice camera)
	{
		if (camera == null)
		{
			throw new ArgumentNullException("camera");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("cameraDeviceDidChangeCapability:"), camera.Handle);
	}

	[Export("cameraDevice:didReceiveThumbnailForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidReceiveThumbnail(ICCameraDevice camera, ICCameraItem forItem)
	{
		if (camera == null)
		{
			throw new ArgumentNullException("camera");
		}
		if (forItem == null)
		{
			throw new ArgumentNullException("forItem");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("cameraDevice:didReceiveThumbnailForItem:"), camera.Handle, forItem.Handle);
	}

	[Export("cameraDevice:didReceiveMetadataForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidReceiveMetadata(ICCameraDevice camera, ICCameraItem forItem)
	{
		if (camera == null)
		{
			throw new ArgumentNullException("camera");
		}
		if (forItem == null)
		{
			throw new ArgumentNullException("forItem");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("cameraDevice:didReceiveMetadataForItem:"), camera.Handle, forItem.Handle);
	}

	[Export("cameraDevice:didReceivePTPEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidReceivePtpEvent(ICCameraDevice camera, NSData eventData)
	{
		if (camera == null)
		{
			throw new ArgumentNullException("camera");
		}
		if (eventData == null)
		{
			throw new ArgumentNullException("eventData");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("cameraDevice:didReceivePTPEvent:"), camera.Handle, eventData.Handle);
	}

	[Export("deviceDidBecomeReadyWithCompleteContentCatalog:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidBecomeReadyWithCompleteContentCatalog(ICDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("deviceDidBecomeReadyWithCompleteContentCatalog:"), device.Handle);
	}

	[Export("didRemoveDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidRemoveDevice(ICDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("didRemoveDevice:"), device.Handle);
	}
}

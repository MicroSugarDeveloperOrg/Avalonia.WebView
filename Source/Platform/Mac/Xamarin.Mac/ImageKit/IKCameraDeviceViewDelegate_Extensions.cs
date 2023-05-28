using System;
using Foundation;
using ImageCaptureCore;
using ObjCRuntime;

namespace ImageKit;

public static class IKCameraDeviceViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectionDidChange(this IIKCameraDeviceViewDelegate This, IKCameraDeviceView cameraDeviceView)
	{
		if (cameraDeviceView == null)
		{
			throw new ArgumentNullException("cameraDeviceView");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("cameraDeviceViewSelectionDidChange:"), cameraDeviceView.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDownloadFile(this IIKCameraDeviceViewDelegate This, IKCameraDeviceView cameraDeviceView, ICCameraFile file, NSUrl url, NSData data, NSError error)
	{
		if (cameraDeviceView == null)
		{
			throw new ArgumentNullException("cameraDeviceView");
		}
		if (file == null)
		{
			throw new ArgumentNullException("file");
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("cameraDeviceView:didDownloadFile:location:fileData:error:"), cameraDeviceView.Handle, file.Handle, url.Handle, data.Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEncounterError(this IIKCameraDeviceViewDelegate This, IKCameraDeviceView cameraDeviceView, NSError error)
	{
		if (cameraDeviceView == null)
		{
			throw new ArgumentNullException("cameraDeviceView");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("cameraDeviceView:didEncounterError:"), cameraDeviceView.Handle, error.Handle);
	}
}

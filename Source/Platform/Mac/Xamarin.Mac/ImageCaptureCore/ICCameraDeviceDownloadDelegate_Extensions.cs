using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

public static class ICCameraDeviceDownloadDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDownloadFile(this IICCameraDeviceDownloadDelegate This, ICCameraFile file, NSError? error, NSDictionary<NSString, NSObject>? options, IntPtr contextInfo)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("didDownloadFile:error:options:contextInfo:"), file.Handle, error?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, contextInfo);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidReceiveDownloadProgress(this IICCameraDeviceDownloadDelegate This, ICCameraFile file, long downloadedBytes, long maxBytes)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		Messaging.void_objc_msgSend_IntPtr_Int64_Int64(This.Handle, Selector.GetHandle("didReceiveDownloadProgressForFile:downloadedBytes:maxBytes:"), file.Handle, downloadedBytes, maxBytes);
	}
}

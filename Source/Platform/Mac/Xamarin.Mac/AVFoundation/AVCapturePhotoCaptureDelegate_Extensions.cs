using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVCapturePhotoCaptureDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillBeginCapture(this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (resolvedSettings == null)
		{
			throw new ArgumentNullException("resolvedSettings");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:willBeginCaptureForResolvedSettings:"), captureOutput.Handle, resolvedSettings.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillCapturePhoto(this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (resolvedSettings == null)
		{
			throw new ArgumentNullException("resolvedSettings");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:willCapturePhotoForResolvedSettings:"), captureOutput.Handle, resolvedSettings.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidCapturePhoto(this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (resolvedSettings == null)
		{
			throw new ArgumentNullException("resolvedSettings");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didCapturePhotoForResolvedSettings:"), captureOutput.Handle, resolvedSettings.Handle);
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishProcessingPhoto(this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput output, AVCapturePhoto photo, NSError? error)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (photo == null)
		{
			throw new ArgumentNullException("photo");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didFinishProcessingPhoto:error:"), output.Handle, photo.Handle, error?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishCapture(this IAVCapturePhotoCaptureDelegate This, AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings, NSError? error)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (resolvedSettings == null)
		{
			throw new ArgumentNullException("resolvedSettings");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didFinishCaptureForResolvedSettings:error:"), captureOutput.Handle, resolvedSettings.Handle, error?.Handle ?? IntPtr.Zero);
	}
}

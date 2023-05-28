using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVCapturePhotoCaptureDelegate", false)]
[Model]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class AVCapturePhotoCaptureDelegate : NSObject, IAVCapturePhotoCaptureDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCapturePhotoCaptureDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCapturePhotoCaptureDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCapturePhotoCaptureDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("captureOutput:didCapturePhotoForResolvedSettings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCapturePhoto(AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didFinishCaptureForResolvedSettings:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishCapture(AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didFinishProcessingPhoto:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishProcessingPhoto(AVCapturePhotoOutput output, AVCapturePhoto photo, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:willBeginCaptureForResolvedSettings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillBeginCapture(AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:willCapturePhotoForResolvedSettings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillCapturePhoto(AVCapturePhotoOutput captureOutput, AVCaptureResolvedPhotoSettings resolvedSettings)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVCaptureFileOutputRecordingDelegate", false)]
[Model]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public abstract class AVCaptureFileOutputRecordingDelegate : NSObject, IAVCaptureFileOutputRecordingDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected AVCaptureFileOutputRecordingDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureFileOutputRecordingDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureFileOutputRecordingDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("captureOutput:didPauseRecordingToOutputFileAtURL:fromConnections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidPauseRecording(AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didResumeRecordingToOutputFileAtURL:fromConnections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidResumeRecording(AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didStartRecordingToOutputFileAtURL:fromConnections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidStartRecording(AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didFinishRecordingToOutputFileAtURL:fromConnections:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void FinishedRecording(AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections, NSError? error);

	[Export("captureOutput:willFinishRecordingToOutputFileAtURL:fromConnections:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillFinishRecording(AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

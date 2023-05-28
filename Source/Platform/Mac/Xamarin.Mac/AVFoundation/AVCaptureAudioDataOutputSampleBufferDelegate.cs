using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVCaptureAudioDataOutputSampleBufferDelegate", false)]
[Model]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVCaptureAudioDataOutputSampleBufferDelegate : NSObject, IAVCaptureAudioDataOutputSampleBufferDelegate, INativeObject, IDisposable
{
	[Obsolete("This member only exists for 'AVCaptureVideoDataOutputSampleBufferDelegate'.")]
	public virtual void DidDropSampleBuffer(AVCaptureOutput captureOutput, CMSampleBuffer sampleBuffer, AVCaptureConnection connection)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureAudioDataOutputSampleBufferDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureAudioDataOutputSampleBufferDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureAudioDataOutputSampleBufferDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("captureOutput:didOutputSampleBuffer:fromConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidOutputSampleBuffer(AVCaptureOutput captureOutput, CMSampleBuffer sampleBuffer, AVCaptureConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

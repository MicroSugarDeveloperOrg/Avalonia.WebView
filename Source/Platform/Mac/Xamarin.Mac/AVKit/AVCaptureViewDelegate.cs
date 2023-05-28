using System;
using System.ComponentModel;
using AVFoundation;
using Foundation;
using ObjCRuntime;

namespace AVKit;

[Protocol]
[Register("AVCaptureViewDelegate", false)]
[Model]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public abstract class AVCaptureViewDelegate : NSObject, IAVCaptureViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected AVCaptureViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("captureView:startRecordingToFileOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void StartRecording(AVCaptureView captureView, AVCaptureFileOutput fileOutput);
}

using System;
using AVFoundation;
using Foundation;
using ObjCRuntime;

namespace AVKit;

internal sealed class AVCaptureViewDelegateWrapper : BaseWrapper, IAVCaptureViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVCaptureViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("captureView:startRecordingToFileOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void StartRecording(AVCaptureView captureView, AVCaptureFileOutput fileOutput)
	{
		if (captureView == null)
		{
			throw new ArgumentNullException("captureView");
		}
		if (fileOutput == null)
		{
			throw new ArgumentNullException("fileOutput");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("captureView:startRecordingToFileOutput:"), captureView.Handle, fileOutput.Handle);
	}
}

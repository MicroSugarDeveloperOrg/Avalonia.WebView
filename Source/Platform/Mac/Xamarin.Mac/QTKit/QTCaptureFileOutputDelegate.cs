using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Protocol(IsInformal = true)]
[Register("QTCaptureFileOutput_Delegate", false)]
[Model]
public class QTCaptureFileOutputDelegate : NSObject, IQTCaptureFileOutputDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureFileOutputDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QTCaptureFileOutputDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCaptureFileOutputDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("captureOutput:didFinishRecordingToOutputFileAtURL:forConnections:dueToError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishRecording(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didOutputSampleBuffer:fromConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidOutputSampleBuffer(QTCaptureFileOutput captureOutput, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didPauseRecordingToOutputFileAtURL:forConnections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidPauseRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didResumeRecordingToOutputFileAtURL:forConnections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidResumeRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didStartRecordingToOutputFileAtURL:forConnections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidStartRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:mustChangeOutputFileAtURL:forConnections:dueToError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MustChangeOutputFile(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:shouldChangeOutputFileAtURL:forConnections:dueToError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldChangeOutputFile(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:willFinishRecordingToOutputFileAtURL:forConnections:dueToError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillFinishRecording(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:willStartRecordingToOutputFileAtURL:forConnections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillStartRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureFileOutput_Delegate", true)]
[Model]
public class QTCaptureFileOutputDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureFileOutputDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QTCaptureFileOutputDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureFileOutputDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureFileOutputDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("captureOutput:didOutputSampleBuffer:fromConnection:")]
	public virtual void DidOutputSampleBuffer(QTCaptureFileOutput captureOutput, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:willStartRecordingToOutputFileAtURL:forConnections:")]
	public virtual void WillStartRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didStartRecordingToOutputFileAtURL:forConnections:")]
	public virtual void DidStartRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:shouldChangeOutputFileAtURL:forConnections:dueToError:")]
	public virtual bool ShouldChangeOutputFile(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:mustChangeOutputFileAtURL:forConnections:dueToError:")]
	public virtual void MustChangeOutputFile(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:willFinishRecordingToOutputFileAtURL:forConnections:dueToError:")]
	public virtual void WillFinishRecording(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didFinishRecordingToOutputFileAtURL:forConnections:dueToError:")]
	public virtual void DidFinishRecording(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didPauseRecordingToOutputFileAtURL:forConnections:")]
	public virtual void DidPauseRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didResumeRecordingToOutputFileAtURL:forConnections:")]
	public virtual void DidResumeRecording(QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

using System;
using System.ComponentModel;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTCaptureDecompressedVideoOutput_Delegate", true)]
[Model]
public class QTCaptureDecompressedVideoOutputDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureDecompressedVideoOutputDelegate()
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
	public QTCaptureDecompressedVideoOutputDelegate(NSCoder coder)
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
	public QTCaptureDecompressedVideoOutputDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTCaptureDecompressedVideoOutputDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("captureOutput:didOutputVideoFrame:withSampleBuffer:fromConnection:")]
	public virtual void DidOutputVideoFrame(QTCaptureOutput captureOutput, CVImageBuffer videoFrame, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didDropVideoFrameWithSampleBuffer:fromConnection:")]
	public virtual void DidDropVideoFrame(QTCaptureOutput captureOutput, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

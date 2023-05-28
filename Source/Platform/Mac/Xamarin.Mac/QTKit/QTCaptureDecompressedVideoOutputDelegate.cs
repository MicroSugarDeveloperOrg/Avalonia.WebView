using System;
using System.ComponentModel;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Protocol(IsInformal = true)]
[Register("QTCaptureDecompressedVideoOutput_Delegate", false)]
[Model]
public class QTCaptureDecompressedVideoOutputDelegate : NSObject, IQTCaptureDecompressedVideoOutputDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureDecompressedVideoOutputDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QTCaptureDecompressedVideoOutputDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCaptureDecompressedVideoOutputDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("captureOutput:didDropVideoFrameWithSampleBuffer:fromConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDropVideoFrame(QTCaptureOutput captureOutput, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("captureOutput:didOutputVideoFrame:withSampleBuffer:fromConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidOutputVideoFrame(QTCaptureOutput captureOutput, CVImageBuffer videoFrame, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

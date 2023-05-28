using System;
using CoreVideo;
using ObjCRuntime;

namespace QTKit;

public static class QTCaptureDecompressedVideoOutputDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidOutputVideoFrame(this IQTCaptureDecompressedVideoOutputDelegate This, QTCaptureOutput captureOutput, CVImageBuffer videoFrame, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (videoFrame == null)
		{
			throw new ArgumentNullException("videoFrame");
		}
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didOutputVideoFrame:withSampleBuffer:fromConnection:"), captureOutput.Handle, videoFrame.Handle, sampleBuffer.Handle, connection.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDropVideoFrame(this IQTCaptureDecompressedVideoOutputDelegate This, QTCaptureOutput captureOutput, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didDropVideoFrameWithSampleBuffer:fromConnection:"), captureOutput.Handle, sampleBuffer.Handle, connection.Handle);
	}
}

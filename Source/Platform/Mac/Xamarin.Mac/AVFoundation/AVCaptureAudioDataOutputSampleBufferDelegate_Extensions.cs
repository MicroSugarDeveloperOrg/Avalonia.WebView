using System;
using CoreMedia;
using ObjCRuntime;

namespace AVFoundation;

public static class AVCaptureAudioDataOutputSampleBufferDelegate_Extensions
{
	[Obsolete("This member only exists for 'AVCaptureVideoDataOutputSampleBufferDelegate'.")]
	public static void DidDropSampleBuffer(IAVCaptureAudioDataOutputSampleBufferDelegate This, AVCaptureOutput captureOutput, CMSampleBuffer sampleBuffer, AVCaptureConnection connection)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidOutputSampleBuffer(this IAVCaptureAudioDataOutputSampleBufferDelegate This, AVCaptureOutput captureOutput, CMSampleBuffer sampleBuffer, AVCaptureConnection connection)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didOutputSampleBuffer:fromConnection:"), captureOutput.Handle, sampleBuffer.Handle, connection.Handle);
	}
}

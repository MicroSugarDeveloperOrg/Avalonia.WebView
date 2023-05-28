using System;
using CoreMedia;
using ObjCRuntime;

namespace AVFoundation;

public static class AVCaptureVideoDataOutputSampleBufferDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidOutputSampleBuffer(this IAVCaptureVideoDataOutputSampleBufferDelegate This, AVCaptureOutput captureOutput, CMSampleBuffer sampleBuffer, AVCaptureConnection connection)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidDropSampleBuffer(this IAVCaptureVideoDataOutputSampleBufferDelegate This, AVCaptureOutput captureOutput, CMSampleBuffer sampleBuffer, AVCaptureConnection connection)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didDropSampleBuffer:fromConnection:"), captureOutput.Handle, sampleBuffer.Handle, connection.Handle);
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVCaptureFileOutputRecordingDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidStartRecording(this IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (outputFileUrl == null)
		{
			throw new ArgumentNullException("outputFileUrl");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didStartRecordingToOutputFileAtURL:fromConnections:"), captureOutput.Handle, outputFileUrl.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidPauseRecording(this IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (outputFileUrl == null)
		{
			throw new ArgumentNullException("outputFileUrl");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didPauseRecordingToOutputFileAtURL:fromConnections:"), captureOutput.Handle, outputFileUrl.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidResumeRecording(this IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (outputFileUrl == null)
		{
			throw new ArgumentNullException("outputFileUrl");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didResumeRecordingToOutputFileAtURL:fromConnections:"), captureOutput.Handle, outputFileUrl.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillFinishRecording(this IAVCaptureFileOutputRecordingDelegate This, AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, AVCaptureConnection[] connections, NSError? error)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (outputFileUrl == null)
		{
			throw new ArgumentNullException("outputFileUrl");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:willFinishRecordingToOutputFileAtURL:fromConnections:error:"), captureOutput.Handle, outputFileUrl.Handle, nSArray.Handle, error?.Handle ?? IntPtr.Zero);
		nSArray.Dispose();
	}
}

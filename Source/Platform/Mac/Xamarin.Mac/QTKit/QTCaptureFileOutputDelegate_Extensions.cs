using System;
using Foundation;
using ObjCRuntime;

namespace QTKit;

public static class QTCaptureFileOutputDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidOutputSampleBuffer(this IQTCaptureFileOutputDelegate This, QTCaptureFileOutput captureOutput, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
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
	public static void WillStartRecording(this IQTCaptureFileOutputDelegate This, QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:willStartRecordingToOutputFileAtURL:forConnections:"), captureOutput.Handle, fileUrl.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidStartRecording(this IQTCaptureFileOutputDelegate This, QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didStartRecordingToOutputFileAtURL:forConnections:"), captureOutput.Handle, fileUrl.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldChangeOutputFile(this IQTCaptureFileOutputDelegate This, QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (outputFileURL == null)
		{
			throw new ArgumentNullException("outputFileURL");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:shouldChangeOutputFileAtURL:forConnections:dueToError:"), captureOutput.Handle, outputFileURL.Handle, nSArray.Handle, reason.Handle);
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void MustChangeOutputFile(this IQTCaptureFileOutputDelegate This, QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (outputFileURL == null)
		{
			throw new ArgumentNullException("outputFileURL");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:mustChangeOutputFileAtURL:forConnections:dueToError:"), captureOutput.Handle, outputFileURL.Handle, nSArray.Handle, reason.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillFinishRecording(this IQTCaptureFileOutputDelegate This, QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (outputFileURL == null)
		{
			throw new ArgumentNullException("outputFileURL");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:willFinishRecordingToOutputFileAtURL:forConnections:dueToError:"), captureOutput.Handle, outputFileURL.Handle, nSArray.Handle, reason.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFinishRecording(this IQTCaptureFileOutputDelegate This, QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (outputFileURL == null)
		{
			throw new ArgumentNullException("outputFileURL");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didFinishRecordingToOutputFileAtURL:forConnections:dueToError:"), captureOutput.Handle, outputFileURL.Handle, nSArray.Handle, reason.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidPauseRecording(this IQTCaptureFileOutputDelegate This, QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didPauseRecordingToOutputFileAtURL:forConnections:"), captureOutput.Handle, fileUrl.Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidResumeRecording(this IQTCaptureFileOutputDelegate This, QTCaptureFileOutput captureOutput, NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (connections == null)
		{
			throw new ArgumentNullException("connections");
		}
		NSArray nSArray = NSArray.FromNSObjects(connections);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("captureOutput:didResumeRecordingToOutputFileAtURL:forConnections:"), captureOutput.Handle, fileUrl.Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}

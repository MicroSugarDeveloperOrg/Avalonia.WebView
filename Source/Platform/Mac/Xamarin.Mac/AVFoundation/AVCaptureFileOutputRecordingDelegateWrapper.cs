using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVCaptureFileOutputRecordingDelegateWrapper : BaseWrapper, IAVCaptureFileOutputRecordingDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVCaptureFileOutputRecordingDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("captureOutput:didFinishRecordingToOutputFileAtURL:fromConnections:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FinishedRecording(AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections, NSError? error)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("captureOutput:didFinishRecordingToOutputFileAtURL:fromConnections:error:"), captureOutput.Handle, outputFileUrl.Handle, nSArray.Handle, error?.Handle ?? IntPtr.Zero);
		nSArray.Dispose();
	}
}

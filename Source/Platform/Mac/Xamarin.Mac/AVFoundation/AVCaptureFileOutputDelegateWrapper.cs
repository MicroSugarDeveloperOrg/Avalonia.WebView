using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVCaptureFileOutputDelegateWrapper : BaseWrapper, IAVCaptureFileOutputDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVCaptureFileOutputDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("captureOutputShouldProvideSampleAccurateRecordingStart:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ShouldProvideSampleAccurateRecordingStart(AVCaptureOutput captureOutput)
	{
		if (captureOutput == null)
		{
			throw new ArgumentNullException("captureOutput");
		}
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("captureOutputShouldProvideSampleAccurateRecordingStart:"), captureOutput.Handle);
	}
}

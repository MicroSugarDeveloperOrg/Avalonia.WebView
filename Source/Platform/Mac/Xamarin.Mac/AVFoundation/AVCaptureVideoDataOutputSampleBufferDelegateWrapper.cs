using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVCaptureVideoDataOutputSampleBufferDelegateWrapper : BaseWrapper, IAVCaptureVideoDataOutputSampleBufferDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVCaptureVideoDataOutputSampleBufferDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

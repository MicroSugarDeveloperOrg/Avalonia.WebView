using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVCaptureAudioDataOutputSampleBufferDelegateWrapper : BaseWrapper, IAVCaptureAudioDataOutputSampleBufferDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVCaptureAudioDataOutputSampleBufferDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

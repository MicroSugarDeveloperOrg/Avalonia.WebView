using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVCapturePhotoCaptureDelegateWrapper : BaseWrapper, IAVCapturePhotoCaptureDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVCapturePhotoCaptureDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

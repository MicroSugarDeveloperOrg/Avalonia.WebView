using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

internal sealed class ICCameraDeviceDownloadDelegateWrapper : BaseWrapper, IICCameraDeviceDownloadDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public ICCameraDeviceDownloadDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

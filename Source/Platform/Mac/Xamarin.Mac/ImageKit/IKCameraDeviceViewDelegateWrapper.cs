using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

internal sealed class IKCameraDeviceViewDelegateWrapper : BaseWrapper, IIKCameraDeviceViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public IKCameraDeviceViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

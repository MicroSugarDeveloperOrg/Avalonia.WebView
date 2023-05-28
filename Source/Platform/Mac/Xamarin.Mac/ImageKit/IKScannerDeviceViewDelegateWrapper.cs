using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

internal sealed class IKScannerDeviceViewDelegateWrapper : BaseWrapper, IIKScannerDeviceViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public IKScannerDeviceViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

internal sealed class ICScannerDeviceDelegateWrapper : BaseWrapper, IICScannerDeviceDelegate, INativeObject, IDisposable, IICDeviceDelegate
{
	[Preserve(Conditional = true)]
	public ICScannerDeviceDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("didRemoveDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidRemoveDevice(ICDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("didRemoveDevice:"), device.Handle);
	}
}

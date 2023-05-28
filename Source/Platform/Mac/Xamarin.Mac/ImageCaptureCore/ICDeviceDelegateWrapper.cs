using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

internal sealed class ICDeviceDelegateWrapper : BaseWrapper, IICDeviceDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public ICDeviceDelegateWrapper(IntPtr handle, bool owns)
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

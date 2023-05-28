using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

internal sealed class ICDeviceBrowserDelegateWrapper : BaseWrapper, IICDeviceBrowserDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public ICDeviceBrowserDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("deviceBrowser:didAddDevice:moreComing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidAddDevice(ICDeviceBrowser browser, ICDevice device, bool moreComing)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, Selector.GetHandle("deviceBrowser:didAddDevice:moreComing:"), browser.Handle, device.Handle, moreComing);
	}

	[Export("deviceBrowser:didRemoveDevice:moreGoing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidRemoveDevice(ICDeviceBrowser browser, ICDevice device, bool moreGoing)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, Selector.GetHandle("deviceBrowser:didRemoveDevice:moreGoing:"), browser.Handle, device.Handle, moreGoing);
	}
}

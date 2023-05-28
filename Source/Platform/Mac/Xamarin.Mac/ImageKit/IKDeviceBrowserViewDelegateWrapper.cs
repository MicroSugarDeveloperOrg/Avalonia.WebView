using System;
using Foundation;
using ImageCaptureCore;
using ObjCRuntime;

namespace ImageKit;

internal sealed class IKDeviceBrowserViewDelegateWrapper : BaseWrapper, IIKDeviceBrowserViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public IKDeviceBrowserViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("deviceBrowserView:selectionDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SelectionDidChange(IKDeviceBrowserView deviceBrowserView, ICDevice device)
	{
		if (deviceBrowserView == null)
		{
			throw new ArgumentNullException("deviceBrowserView");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("deviceBrowserView:selectionDidChange:"), deviceBrowserView.Handle, device.Handle);
	}
}

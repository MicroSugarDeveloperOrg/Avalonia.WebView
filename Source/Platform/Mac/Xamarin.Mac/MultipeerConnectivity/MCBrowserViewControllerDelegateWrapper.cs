using System;
using Foundation;
using ObjCRuntime;

namespace MultipeerConnectivity;

internal sealed class MCBrowserViewControllerDelegateWrapper : BaseWrapper, IMCBrowserViewControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MCBrowserViewControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("browserViewControllerWasCancelled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void WasCancelled(MCBrowserViewController browserViewController)
	{
		if (browserViewController == null)
		{
			throw new ArgumentNullException("browserViewController");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("browserViewControllerWasCancelled:"), browserViewController.Handle);
	}

	[Export("browserViewControllerDidFinish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFinish(MCBrowserViewController browserViewController)
	{
		if (browserViewController == null)
		{
			throw new ArgumentNullException("browserViewController");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("browserViewControllerDidFinish:"), browserViewController.Handle);
	}
}

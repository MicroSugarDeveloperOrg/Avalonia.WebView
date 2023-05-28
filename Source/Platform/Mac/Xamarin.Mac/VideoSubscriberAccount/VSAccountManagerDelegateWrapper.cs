using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

internal sealed class VSAccountManagerDelegateWrapper : BaseWrapper, IVSAccountManagerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public VSAccountManagerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("accountManager:presentViewController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PresentViewController(VSAccountManager accountManager, NSViewController viewController)
	{
		if (accountManager == null)
		{
			throw new ArgumentNullException("accountManager");
		}
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("accountManager:presentViewController:"), accountManager.Handle, viewController.Handle);
	}

	[Export("accountManager:dismissViewController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DismissViewController(VSAccountManager accountManager, NSViewController viewController)
	{
		if (accountManager == null)
		{
			throw new ArgumentNullException("accountManager");
		}
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("accountManager:dismissViewController:"), accountManager.Handle, viewController.Handle);
	}
}

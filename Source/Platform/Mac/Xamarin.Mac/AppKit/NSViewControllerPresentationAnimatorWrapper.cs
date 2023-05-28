using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSViewControllerPresentationAnimatorWrapper : BaseWrapper, INSViewControllerPresentationAnimator, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSViewControllerPresentationAnimatorWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("animatePresentationOfViewController:fromViewController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AnimatePresentation(NSViewController viewController, NSViewController fromViewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (fromViewController == null)
		{
			throw new ArgumentNullException("fromViewController");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("animatePresentationOfViewController:fromViewController:"), viewController.Handle, fromViewController.Handle);
	}

	[Export("animateDismissalOfViewController:fromViewController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AnimateDismissal(NSViewController viewController, NSViewController fromViewController)
	{
		NSApplication.EnsureUIThread();
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (fromViewController == null)
		{
			throw new ArgumentNullException("fromViewController");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("animateDismissalOfViewController:fromViewController:"), viewController.Handle, fromViewController.Handle);
	}
}

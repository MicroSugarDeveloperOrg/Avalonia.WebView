using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSViewControllerPresentationAnimator", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public abstract class NSViewControllerPresentationAnimator : NSObject, INSViewControllerPresentationAnimator, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSViewControllerPresentationAnimator()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSViewControllerPresentationAnimator(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSViewControllerPresentationAnimator(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("animateDismissalOfViewController:fromViewController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void AnimateDismissal(NSViewController viewController, NSViewController fromViewController);

	[Export("animatePresentationOfViewController:fromViewController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void AnimatePresentation(NSViewController viewController, NSViewController fromViewController);
}

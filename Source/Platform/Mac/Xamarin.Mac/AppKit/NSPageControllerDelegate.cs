using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSPageControllerDelegate", false)]
[Model]
public class NSPageControllerDelegate : NSObject, INSPageControllerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPageControllerDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPageControllerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPageControllerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("pageControllerDidEndLiveTransition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEndLiveTransition(NSPageController pageController)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pageController:didTransitionToObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidTransition(NSPageController pageController, NSObject targetObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pageController:frameForObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetFrame(NSPageController pageController, NSObject targetObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pageController:identifierForObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetIdentifier(NSPageController pageController, NSObject targetObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pageController:viewControllerForIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewController GetViewController(NSPageController pageController, string identifier)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pageController:prepareViewController:withObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareViewController(NSPageController pageController, NSViewController viewController, NSObject targetObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pageControllerWillStartLiveTransition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillStartLiveTransition(NSPageController pageController)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

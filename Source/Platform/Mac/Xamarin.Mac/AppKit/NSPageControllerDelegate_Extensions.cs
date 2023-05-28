using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSPageControllerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetIdentifier(this INSPageControllerDelegate This, NSPageController pageController, NSObject targetObject)
	{
		NSApplication.EnsureUIThread();
		if (pageController == null)
		{
			throw new ArgumentNullException("pageController");
		}
		if (targetObject == null)
		{
			throw new ArgumentNullException("targetObject");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pageController:identifierForObject:"), pageController.Handle, targetObject.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSViewController GetViewController(this INSPageControllerDelegate This, NSPageController pageController, string identifier)
	{
		NSApplication.EnsureUIThread();
		if (pageController == null)
		{
			throw new ArgumentNullException("pageController");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr intPtr = NSString.CreateNative(identifier);
		NSViewController nSObject = Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pageController:viewControllerForIdentifier:"), pageController.Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect GetFrame(this INSPageControllerDelegate This, NSPageController pageController, NSObject targetObject)
	{
		NSApplication.EnsureUIThread();
		if (pageController == null)
		{
			throw new ArgumentNullException("pageController");
		}
		if (targetObject == null)
		{
			throw new ArgumentNullException("targetObject");
		}
		Messaging.CGRect_objc_msgSend_stret_IntPtr_IntPtr(out var retval, This.Handle, Selector.GetHandle("pageController:frameForObject:"), pageController.Handle, targetObject.Handle);
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PrepareViewController(this INSPageControllerDelegate This, NSPageController pageController, NSViewController viewController, NSObject targetObject)
	{
		NSApplication.EnsureUIThread();
		if (pageController == null)
		{
			throw new ArgumentNullException("pageController");
		}
		if (viewController == null)
		{
			throw new ArgumentNullException("viewController");
		}
		if (targetObject == null)
		{
			throw new ArgumentNullException("targetObject");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pageController:prepareViewController:withObject:"), pageController.Handle, viewController.Handle, targetObject.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidTransition(this INSPageControllerDelegate This, NSPageController pageController, NSObject targetObject)
	{
		NSApplication.EnsureUIThread();
		if (pageController == null)
		{
			throw new ArgumentNullException("pageController");
		}
		if (targetObject == null)
		{
			throw new ArgumentNullException("targetObject");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("pageController:didTransitionToObject:"), pageController.Handle, targetObject.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillStartLiveTransition(this INSPageControllerDelegate This, NSPageController pageController)
	{
		NSApplication.EnsureUIThread();
		if (pageController == null)
		{
			throw new ArgumentNullException("pageController");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pageControllerWillStartLiveTransition:"), pageController.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidEndLiveTransition(this INSPageControllerDelegate This, NSPageController pageController)
	{
		NSApplication.EnsureUIThread();
		if (pageController == null)
		{
			throw new ArgumentNullException("pageController");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pageControllerDidEndLiveTransition:"), pageController.Handle);
	}
}

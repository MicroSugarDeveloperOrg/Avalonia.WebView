using System;
using ObjCRuntime;

namespace AppKit;

public static class NSAnimationDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AnimationShouldStart(this INSAnimationDelegate This, NSAnimation animation)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("animationShouldStart:"), animation.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AnimationDidStop(this INSAnimationDelegate This, NSAnimation animation)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("animationDidStop:"), animation.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AnimationDidEnd(this INSAnimationDelegate This, NSAnimation animation)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("animationDidEnd:"), animation.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static float ComputeAnimationCurve(this INSAnimationDelegate This, NSAnimation animation, float progress)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		return Messaging.float_objc_msgSend_IntPtr_float(This.Handle, Selector.GetHandle("animation:valueForProgress:"), animation.Handle, progress);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AnimationDidReachProgressMark(this INSAnimationDelegate This, NSAnimation animation, float progress)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		Messaging.void_objc_msgSend_IntPtr_float(This.Handle, Selector.GetHandle("animation:didReachProgressMark:"), animation.Handle, progress);
	}
}

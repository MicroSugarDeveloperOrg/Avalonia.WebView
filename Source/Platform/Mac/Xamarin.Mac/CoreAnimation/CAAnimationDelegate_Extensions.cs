using System;
using ObjCRuntime;

namespace CoreAnimation;

public static class CAAnimationDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AnimationStarted(this ICAAnimationDelegate This, CAAnimation? anim)
	{
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("animationDidStart:"), anim?.Handle ?? IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AnimationStopped(this ICAAnimationDelegate This, CAAnimation? anim, bool finished)
	{
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("animationDidStop:finished:"), anim?.Handle ?? IntPtr.Zero, finished);
	}
}

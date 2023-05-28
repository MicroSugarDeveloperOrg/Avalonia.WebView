using System;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNAnimatableWrapper : BaseWrapper, ISCNAnimatable, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNAnimatableWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("addAnimation:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AddAnimation(CAAnimation animation, NSString? key)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("addAnimation:forKey:"), animation.Handle, (key == null) ? IntPtr.Zero : key.Handle);
	}

	[Export("removeAllAnimations")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RemoveAllAnimations()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("removeAllAnimations"));
	}

	[Export("removeAnimationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RemoveAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("removeAnimationForKey:"), key.Handle);
	}

	[Export("animationKeys")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSString[] GetAnimationKeys()
	{
		return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("animationKeys")));
	}

	[Export("animationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CAAnimation GetAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject<CAAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("animationForKey:"), key.Handle));
	}

	[Export("pauseAnimationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PauseAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("pauseAnimationForKey:"), key.Handle);
	}

	[Export("resumeAnimationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ResumeAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("resumeAnimationForKey:"), key.Handle);
	}

	[Export("isAnimationForKeyPaused:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool IsAnimationPaused(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("isAnimationForKeyPaused:"), key.Handle);
	}

	[Export("removeAnimationForKey:fadeOutDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RemoveAnimation(NSString key, nfloat duration)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, Selector.GetHandle("removeAnimationForKey:fadeOutDuration:"), key.Handle, duration);
	}
}

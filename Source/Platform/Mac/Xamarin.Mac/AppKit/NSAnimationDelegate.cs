using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSAnimationDelegate", false)]
[Model]
public class NSAnimationDelegate : NSObject, INSAnimationDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAnimationDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSAnimationDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAnimationDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("animationDidEnd:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AnimationDidEnd(NSAnimation animation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("animation:didReachProgressMark:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AnimationDidReachProgressMark(NSAnimation animation, float progress)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("animationDidStop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AnimationDidStop(NSAnimation animation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("animationShouldStart:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AnimationShouldStart(NSAnimation animation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("animation:valueForProgress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ComputeAnimationCurve(NSAnimation animation, float progress)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

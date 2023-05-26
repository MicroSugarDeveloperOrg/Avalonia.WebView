using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAnimationDelegate", true)]
[Model]
public class NSAnimationDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAnimationDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSAnimationDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAnimationDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAnimationDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animationShouldStart:")]
	public virtual bool AnimationShouldStart(NSAnimation animation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("animationDidStop:")]
	public virtual void AnimationDidStop(NSAnimation animation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("animationDidEnd:")]
	public virtual void AnimationDidEnd(NSAnimation animation)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("animation:valueForProgress:")]
	public virtual double ComputeAnimationCurve(NSAnimation animation, double progress)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("animation:didReachProgressMark:")]
	public virtual void AnimationDidReachProgressMark(NSAnimation animation, double progress)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

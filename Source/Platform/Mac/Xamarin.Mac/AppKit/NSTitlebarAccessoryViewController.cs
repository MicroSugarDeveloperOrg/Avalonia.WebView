using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTitlebarAccessoryViewController", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSTitlebarAccessoryViewController : NSViewController, INSAnimationDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimation_DidReachProgressMark_ = "animation:didReachProgressMark:";

	private static readonly IntPtr selAnimation_DidReachProgressMark_Handle = Selector.GetHandle("animation:didReachProgressMark:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimation_ValueForProgress_ = "animation:valueForProgress:";

	private static readonly IntPtr selAnimation_ValueForProgress_Handle = Selector.GetHandle("animation:valueForProgress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationDidEnd_ = "animationDidEnd:";

	private static readonly IntPtr selAnimationDidEnd_Handle = Selector.GetHandle("animationDidEnd:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationDidStop_ = "animationDidStop:";

	private static readonly IntPtr selAnimationDidStop_Handle = Selector.GetHandle("animationDidStop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationForKey_ = "animationForKey:";

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationShouldStart_ = "animationShouldStart:";

	private static readonly IntPtr selAnimationShouldStart_Handle = Selector.GetHandle("animationShouldStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimations = "animations";

	private static readonly IntPtr selAnimationsHandle = Selector.GetHandle("animations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimator = "animator";

	private static readonly IntPtr selAnimatorHandle = Selector.GetHandle("animator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultAnimationForKey_ = "defaultAnimationForKey:";

	private static readonly IntPtr selDefaultAnimationForKey_Handle = Selector.GetHandle("defaultAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFullScreenMinHeight = "fullScreenMinHeight";

	private static readonly IntPtr selFullScreenMinHeightHandle = Selector.GetHandle("fullScreenMinHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHidden = "isHidden";

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttribute = "layoutAttribute";

	private static readonly IntPtr selLayoutAttributeHandle = Selector.GetHandle("layoutAttribute");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimations_ = "setAnimations:";

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFullScreenMinHeight_ = "setFullScreenMinHeight:";

	private static readonly IntPtr selSetFullScreenMinHeight_Handle = Selector.GetHandle("setFullScreenMinHeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHidden_ = "setHidden:";

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayoutAttribute_ = "setLayoutAttribute:";

	private static readonly IntPtr selSetLayoutAttribute_Handle = Selector.GetHandle("setLayoutAttribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidAppear = "viewDidAppear";

	private static readonly IntPtr selViewDidAppearHandle = Selector.GetHandle("viewDidAppear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidDisappear = "viewDidDisappear";

	private static readonly IntPtr selViewDidDisappearHandle = Selector.GetHandle("viewDidDisappear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWillAppear = "viewWillAppear";

	private static readonly IntPtr selViewWillAppearHandle = Selector.GetHandle("viewWillAppear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTitlebarAccessoryViewController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Animations
	{
		[Export("animations")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationsHandle));
		}
		[Export("setAnimations:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimations_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimations_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Animator
	{
		[Export("animator")]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimatorHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimatorHandle)));
			nSObject.SetAsProxy();
			return nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat FullScreenMinHeight
	{
		[Export("fullScreenMinHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFullScreenMinHeightHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFullScreenMinHeightHandle);
		}
		[Export("setFullScreenMinHeight:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFullScreenMinHeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFullScreenMinHeight_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool IsHidden
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("isHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidden_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutAttribute LayoutAttribute
	{
		[Export("layoutAttribute")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSLayoutAttribute)Messaging.Int64_objc_msgSend(base.Handle, selLayoutAttributeHandle);
			}
			return (NSLayoutAttribute)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLayoutAttributeHandle);
		}
		[Export("setLayoutAttribute:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetLayoutAttribute_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLayoutAttribute_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTitlebarAccessoryViewController()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTitlebarAccessoryViewController(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTitlebarAccessoryViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTitlebarAccessoryViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTitlebarAccessoryViewController(string? nibNameOrNull, NSBundle? nibBundleOrNull)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(nibNameOrNull);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("animationDidEnd:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AnimationDidEnd(NSAnimation animation)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAnimationDidEnd_Handle, animation.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationDidEnd_Handle, animation.Handle);
		}
	}

	[Export("animation:didReachProgressMark:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AnimationDidReachProgressMark(NSAnimation animation, float progress)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_float(base.Handle, selAnimation_DidReachProgressMark_Handle, animation.Handle, progress);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selAnimation_DidReachProgressMark_Handle, animation.Handle, progress);
		}
	}

	[Export("animationDidStop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AnimationDidStop(NSAnimation animation)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAnimationDidStop_Handle, animation.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationDidStop_Handle, animation.Handle);
		}
	}

	[Export("animationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject AnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, key.Handle));
	}

	[Export("animationShouldStart:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AnimationShouldStart(NSAnimation animation)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAnimationShouldStart_Handle, animation.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationShouldStart_Handle, animation.Handle);
	}

	[Export("animation:valueForProgress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ComputeAnimationCurve(NSAnimation animation, float progress)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_IntPtr_float(base.Handle, selAnimation_ValueForProgress_Handle, animation.Handle, progress);
		}
		return Messaging.float_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selAnimation_ValueForProgress_Handle, animation.Handle, progress);
	}

	[Export("defaultAnimationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject DefaultAnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultAnimationForKey_Handle, key.Handle));
	}

	[Export("viewDidAppear")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public new virtual void ViewDidAppear()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidAppearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidAppearHandle);
		}
	}

	[Export("viewDidDisappear")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public new virtual void ViewDidDisappear()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidDisappearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidDisappearHandle);
		}
	}

	[Export("viewWillAppear")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public new virtual void ViewWillAppear()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewWillAppearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewWillAppearHandle);
		}
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSViewAnimation", true)]
public class NSViewAnimation : NSAnimation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationForKey_ = "animationForKey:";

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

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
	private const string selInitWithViewAnimations_ = "initWithViewAnimations:";

	private static readonly IntPtr selInitWithViewAnimations_Handle = Selector.GetHandle("initWithViewAnimations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimations_ = "setAnimations:";

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetViewAnimations_ = "setViewAnimations:";

	private static readonly IntPtr selSetViewAnimations_Handle = Selector.GetHandle("setViewAnimations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewAnimations = "viewAnimations";

	private static readonly IntPtr selViewAnimationsHandle = Selector.GetHandle("viewAnimations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSViewAnimation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EffectKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EndFrameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FadeInEffect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FadeOutEffect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StartFrameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TargetKey;

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
	public virtual NSDictionary[] ViewAnimations
	{
		[Export("viewAnimations", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewAnimationsHandle));
			}
			return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewAnimationsHandle));
		}
		[Export("setViewAnimations:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetViewAnimations_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetViewAnimations_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[Field("NSViewAnimationEffectKey", "AppKit")]
	public static NSString EffectKey
	{
		get
		{
			if (_EffectKey == null)
			{
				_EffectKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewAnimationEffectKey");
			}
			return _EffectKey;
		}
	}

	[Field("NSViewAnimationEndFrameKey", "AppKit")]
	public static NSString EndFrameKey
	{
		get
		{
			if (_EndFrameKey == null)
			{
				_EndFrameKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewAnimationEndFrameKey");
			}
			return _EndFrameKey;
		}
	}

	[Field("NSViewAnimationFadeInEffect", "AppKit")]
	public static NSString FadeInEffect
	{
		get
		{
			if (_FadeInEffect == null)
			{
				_FadeInEffect = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewAnimationFadeInEffect");
			}
			return _FadeInEffect;
		}
	}

	[Field("NSViewAnimationFadeOutEffect", "AppKit")]
	public static NSString FadeOutEffect
	{
		get
		{
			if (_FadeOutEffect == null)
			{
				_FadeOutEffect = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewAnimationFadeOutEffect");
			}
			return _FadeOutEffect;
		}
	}

	[Field("NSViewAnimationStartFrameKey", "AppKit")]
	public static NSString StartFrameKey
	{
		get
		{
			if (_StartFrameKey == null)
			{
				_StartFrameKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewAnimationStartFrameKey");
			}
			return _StartFrameKey;
		}
	}

	[Field("NSViewAnimationTargetKey", "AppKit")]
	public static NSString TargetKey
	{
		get
		{
			if (_TargetKey == null)
			{
				_TargetKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSViewAnimationTargetKey");
			}
			return _TargetKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSViewAnimation()
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
	public NSViewAnimation(NSCoder coder)
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
	protected NSViewAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSViewAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithViewAnimations:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSViewAnimation(NSDictionary[] viewAnimations)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (viewAnimations == null)
		{
			throw new ArgumentNullException("viewAnimations");
		}
		NSArray nSArray = NSArray.FromNSObjects(viewAnimations);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithViewAnimations_Handle, nSArray.Handle), "initWithViewAnimations:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithViewAnimations_Handle, nSArray.Handle), "initWithViewAnimations:");
		}
		nSArray.Dispose();
	}

	[Export("animationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject AnimationForKey(string key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("defaultAnimationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject DefaultAnimationForKey(string key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultAnimationForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}

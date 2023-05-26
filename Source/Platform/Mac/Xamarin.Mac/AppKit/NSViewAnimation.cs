using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSViewAnimation", true)]
public class NSViewAnimation : NSAnimation
{
	private static readonly IntPtr selViewAnimationsHandle = Selector.GetHandle("viewAnimations");

	private static readonly IntPtr selSetViewAnimations_Handle = Selector.GetHandle("setViewAnimations:");

	private static readonly IntPtr selAnimatorHandle = Selector.GetHandle("animator");

	private static readonly IntPtr selAnimationsHandle = Selector.GetHandle("animations");

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	private static readonly IntPtr selInitWithViewAnimations_Handle = Selector.GetHandle("initWithViewAnimations:");

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	private static readonly IntPtr selDefaultAnimationForKey_Handle = Selector.GetHandle("defaultAnimationForKey:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSViewAnimation");

	private object __mt_ViewAnimations_var;

	private object __mt_Animator_var;

	private object __mt_Animations_var;

	private static NSString _TargetKey;

	private static NSString _StartFrameKey;

	private static NSString _EndFrameKey;

	private static NSString _EffectKey;

	private static NSString _FadeInEffect;

	private static NSString _FadeOutEffect;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSDictionary[] ViewAnimations
	{
		[Export("viewAnimations")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary[])(__mt_ViewAnimations_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewAnimationsHandle)) : NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewAnimationsHandle))));
		}
		[Export("setViewAnimations:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetViewAnimations_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetViewAnimations_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_ViewAnimations_var = value;
		}
	}

	public virtual NSObject Animator
	{
		[Export("animator")]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = (NSObject)(__mt_Animator_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimatorHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimatorHandle))));
			nSObject.SetAsProxy();
			return nSObject;
		}
	}

	public virtual NSDictionary Animations
	{
		[Export("animations")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_Animations_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationsHandle)))));
		}
		[Export("setAnimations:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimations_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimations_Handle, value.Handle);
			}
			__mt_Animations_var = value;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSViewAnimation()
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
	public NSViewAnimation(NSCoder coder)
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
	public NSViewAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSViewAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithViewAnimations:")]
	public NSViewAnimation(NSDictionary[] viewAnimations)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (viewAnimations == null)
		{
			throw new ArgumentNullException("viewAnimations");
		}
		NSArray nSArray = NSArray.FromNSObjects(viewAnimations);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithViewAnimations_Handle, nSArray.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithViewAnimations_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("animationForKey:")]
	public virtual NSObject AnimationForKey(string key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("defaultAnimationForKey:")]
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

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ViewAnimations_var = null;
			__mt_Animator_var = null;
			__mt_Animations_var = null;
		}
	}
}

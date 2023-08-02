using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAAnimation", true)]
public class CAAnimation : NSObject
{
	[Register]
	private sealed class _CAAnimationDelegate : CAAnimationDelegate
	{
		internal EventHandler animationStarted;

		internal EventHandler<CAAnimationStateEventArgs> animationStopped;

		[Preserve(Conditional = true)]
		public override void AnimationStarted(CAAnimation anim)
		{
			animationStarted?.Invoke(anim, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void AnimationStopped(CAAnimation anim, bool finished)
		{
			EventHandler<CAAnimationStateEventArgs> eventHandler = animationStopped;
			if (eventHandler != null)
			{
				CAAnimationStateEventArgs e = new CAAnimationStateEventArgs(finished);
				eventHandler(anim, e);
			}
		}
	}

	private const string Linear = "linear";

	private const string Discrete = "discrete";

	private const string Paced = "paced";

	private const string Cubic = "cubic";

	private const string RotateAuto = "auto";

	private const string RotateAutoReverse = "autoReverse";

	private static readonly IntPtr selTimingFunctionHandle = Selector.GetHandle("timingFunction");

	private static readonly IntPtr selSetTimingFunction_Handle = Selector.GetHandle("setTimingFunction:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selIsRemovedOnCompletionHandle = Selector.GetHandle("isRemovedOnCompletion");

	private static readonly IntPtr selSetRemovedOnCompletion_Handle = Selector.GetHandle("setRemovedOnCompletion:");

	private static readonly IntPtr selBeginTimeHandle = Selector.GetHandle("beginTime");

	private static readonly IntPtr selSetBeginTime_Handle = Selector.GetHandle("setBeginTime:");

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	private static readonly IntPtr selSpeedHandle = Selector.GetHandle("speed");

	private static readonly IntPtr selSetSpeed_Handle = Selector.GetHandle("setSpeed:");

	private static readonly IntPtr selTimeOffsetHandle = Selector.GetHandle("timeOffset");

	private static readonly IntPtr selSetTimeOffset_Handle = Selector.GetHandle("setTimeOffset:");

	private static readonly IntPtr selRepeatCountHandle = Selector.GetHandle("repeatCount");

	private static readonly IntPtr selSetRepeatCount_Handle = Selector.GetHandle("setRepeatCount:");

	private static readonly IntPtr selRepeatDurationHandle = Selector.GetHandle("repeatDuration");

	private static readonly IntPtr selSetRepeatDuration_Handle = Selector.GetHandle("setRepeatDuration:");

	private static readonly IntPtr selAutoreversesHandle = Selector.GetHandle("autoreverses");

	private static readonly IntPtr selSetAutoreverses_Handle = Selector.GetHandle("setAutoreverses:");

	private static readonly IntPtr selFillModeHandle = Selector.GetHandle("fillMode");

	private static readonly IntPtr selSetFillMode_Handle = Selector.GetHandle("setFillMode:");

	private static readonly IntPtr selUsesSceneTimeBaseHandle = Selector.GetHandle("usesSceneTimeBase");

	private static readonly IntPtr selSetUsesSceneTimeBase_Handle = Selector.GetHandle("setUsesSceneTimeBase:");

	private static readonly IntPtr selAnimationHandle = Selector.GetHandle("animation");

	private static readonly IntPtr selDefaultValueForKey_Handle = Selector.GetHandle("defaultValueForKey:");

	private static readonly IntPtr selWillChangeValueForKey_Handle = Selector.GetHandle("willChangeValueForKey:");

	private static readonly IntPtr selDidChangeValueForKey_Handle = Selector.GetHandle("didChangeValueForKey:");

	private static readonly IntPtr selShouldArchiveValueForKey_Handle = Selector.GetHandle("shouldArchiveValueForKey:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAAnimation");

	private object __mt_TimingFunction_var;

	private object __mt_WeakDelegate_var;

	private static NSString _TransitionFade;

	private static NSString _TransitionMoveIn;

	private static NSString _TransitionPush;

	private static NSString _TransitionReveal;

	private static NSString _TransitionFromRight;

	private static NSString _TransitionFromLeft;

	private static NSString _TransitionFromTop;

	private static NSString _TransitionFromBottom;

	private static NSString _AnimationLinear;

	private static NSString _AnimationDescrete;

	private static NSString _AnimationPaced;

	private static NSString _RotateModeAuto;

	private static NSString _RotateModeAutoReverse;

	[Obsolete("Use BeginTime instead")]
	public double CFTimeInterval
	{
		get
		{
			return BeginTime;
		}
		set
		{
			BeginTime = value;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual CAMediaTimingFunction TimingFunction
	{
		[Export("timingFunction", ArgumentSemantic.Retain)]
		get
		{
			return (CAMediaTimingFunction)(__mt_TimingFunction_var = ((!IsDirectBinding) ? ((CAMediaTimingFunction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimingFunctionHandle))) : ((CAMediaTimingFunction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTimingFunctionHandle)))));
		}
		[Export("setTimingFunction:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimingFunction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimingFunction_Handle, value.Handle);
			}
			__mt_TimingFunction_var = value;
		}
	}

	public CAAnimationDelegate Delegate
	{
		get
		{
			return WeakDelegate as CAAnimationDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Retain)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Retain)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public virtual bool RemovedOnCompletion
	{
		[Export("isRemovedOnCompletion")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRemovedOnCompletionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRemovedOnCompletionHandle);
		}
		[Export("setRemovedOnCompletion:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRemovedOnCompletion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRemovedOnCompletion_Handle, value);
			}
		}
	}

	public virtual double BeginTime
	{
		[Export("beginTime")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBeginTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBeginTimeHandle);
		}
		[Export("setBeginTime:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetBeginTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetBeginTime_Handle, value);
			}
		}
	}

	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
		[Export("setDuration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDuration_Handle, value);
			}
		}
	}

	public virtual float Speed
	{
		[Export("speed")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSpeedHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSpeedHandle);
		}
		[Export("setSpeed:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSpeed_Handle, value);
			}
		}
	}

	public virtual double TimeOffset
	{
		[Export("timeOffset")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeOffsetHandle);
		}
		[Export("setTimeOffset:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeOffset_Handle, value);
			}
		}
	}

	public virtual float RepeatCount
	{
		[Export("repeatCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRepeatCountHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRepeatCountHandle);
		}
		[Export("setRepeatCount:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRepeatCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRepeatCount_Handle, value);
			}
		}
	}

	public virtual double RepeatDuration
	{
		[Export("repeatDuration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRepeatDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRepeatDurationHandle);
		}
		[Export("setRepeatDuration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRepeatDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRepeatDuration_Handle, value);
			}
		}
	}

	public virtual bool AutoReverses
	{
		[Export("autoreverses")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoreversesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoreversesHandle);
		}
		[Export("setAutoreverses:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoreverses_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoreverses_Handle, value);
			}
		}
	}

	public virtual string FillMode
	{
		[Export("fillMode")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFillModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillModeHandle));
		}
		[Export("setFillMode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillMode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillMode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[MountainLion]
	public virtual bool UsesSceneTimeBase
	{
		[MountainLion]
		[Export("usesSceneTimeBase")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesSceneTimeBaseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesSceneTimeBaseHandle);
		}
		[MountainLion]
		[Export("setUsesSceneTimeBase:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesSceneTimeBase_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesSceneTimeBase_Handle, value);
			}
		}
	}

	[Field("kCATransitionFade", "CoreAnimation")]
	public static NSString TransitionFade
	{
		get
		{
			if (_TransitionFade == null)
			{
				_TransitionFade = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransitionFade");
			}
			return _TransitionFade;
		}
	}

	[Field("kCATransitionMoveIn", "CoreAnimation")]
	public static NSString TransitionMoveIn
	{
		get
		{
			if (_TransitionMoveIn == null)
			{
				_TransitionMoveIn = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransitionMoveIn");
			}
			return _TransitionMoveIn;
		}
	}

	[Field("kCATransitionPush", "CoreAnimation")]
	public static NSString TransitionPush
	{
		get
		{
			if (_TransitionPush == null)
			{
				_TransitionPush = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransitionPush");
			}
			return _TransitionPush;
		}
	}

	[Field("kCATransitionReveal", "CoreAnimation")]
	public static NSString TransitionReveal
	{
		get
		{
			if (_TransitionReveal == null)
			{
				_TransitionReveal = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransitionReveal");
			}
			return _TransitionReveal;
		}
	}

	[Field("kCATransitionFromRight", "CoreAnimation")]
	public static NSString TransitionFromRight
	{
		get
		{
			if (_TransitionFromRight == null)
			{
				_TransitionFromRight = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransitionFromRight");
			}
			return _TransitionFromRight;
		}
	}

	[Field("kCATransitionFromLeft", "CoreAnimation")]
	public static NSString TransitionFromLeft
	{
		get
		{
			if (_TransitionFromLeft == null)
			{
				_TransitionFromLeft = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransitionFromLeft");
			}
			return _TransitionFromLeft;
		}
	}

	[Field("kCATransitionFromTop", "CoreAnimation")]
	public static NSString TransitionFromTop
	{
		get
		{
			if (_TransitionFromTop == null)
			{
				_TransitionFromTop = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransitionFromTop");
			}
			return _TransitionFromTop;
		}
	}

	[Field("kCATransitionFromBottom", "CoreAnimation")]
	public static NSString TransitionFromBottom
	{
		get
		{
			if (_TransitionFromBottom == null)
			{
				_TransitionFromBottom = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATransitionFromBottom");
			}
			return _TransitionFromBottom;
		}
	}

	[Field("kCAAnimationLinear", "CoreAnimation")]
	public static NSString AnimationLinear
	{
		get
		{
			if (_AnimationLinear == null)
			{
				_AnimationLinear = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAnimationLinear");
			}
			return _AnimationLinear;
		}
	}

	[Field("kCAAnimationDiscrete", "CoreAnimation")]
	public static NSString AnimationDescrete
	{
		get
		{
			if (_AnimationDescrete == null)
			{
				_AnimationDescrete = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAnimationDiscrete");
			}
			return _AnimationDescrete;
		}
	}

	[Field("kCAAnimationPaced", "CoreAnimation")]
	public static NSString AnimationPaced
	{
		get
		{
			if (_AnimationPaced == null)
			{
				_AnimationPaced = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAnimationPaced");
			}
			return _AnimationPaced;
		}
	}

	[Field("kCAAnimationRotateAuto", "CoreAnimation")]
	public static NSString RotateModeAuto
	{
		get
		{
			if (_RotateModeAuto == null)
			{
				_RotateModeAuto = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAnimationRotateAuto");
			}
			return _RotateModeAuto;
		}
	}

	[Field("kCAAnimationRotateAutoReverse", "CoreAnimation")]
	public static NSString RotateModeAutoReverse
	{
		get
		{
			if (_RotateModeAutoReverse == null)
			{
				_RotateModeAutoReverse = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAnimationRotateAutoReverse");
			}
			return _RotateModeAutoReverse;
		}
	}

	public event EventHandler AnimationStarted
	{
		add
		{
			_CAAnimationDelegate cAAnimationDelegate = EnsureCAAnimationDelegate();
			cAAnimationDelegate.animationStarted = (EventHandler)System.Delegate.Combine(cAAnimationDelegate.animationStarted, value);
		}
		remove
		{
			_CAAnimationDelegate cAAnimationDelegate = EnsureCAAnimationDelegate();
			cAAnimationDelegate.animationStarted = (EventHandler)System.Delegate.Remove(cAAnimationDelegate.animationStarted, value);
		}
	}

	public event EventHandler<CAAnimationStateEventArgs> AnimationStopped
	{
		add
		{
			_CAAnimationDelegate cAAnimationDelegate = EnsureCAAnimationDelegate();
			cAAnimationDelegate.animationStopped = (EventHandler<CAAnimationStateEventArgs>)System.Delegate.Combine(cAAnimationDelegate.animationStopped, value);
		}
		remove
		{
			_CAAnimationDelegate cAAnimationDelegate = EnsureCAAnimationDelegate();
			cAAnimationDelegate.animationStopped = (EventHandler<CAAnimationStateEventArgs>)System.Delegate.Remove(cAAnimationDelegate.animationStopped, value);
		}
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", EntryPoint = "CACurrentMediaTime")]
	public static extern double CurrentMediaTime();

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAAnimation()
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
	public CAAnimation(NSCoder coder)
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
	public CAAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animation")]
	public static CAAnimation CreateAnimation()
	{
		return (CAAnimation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selAnimationHandle));
	}

	[Export("defaultValueForKey:")]
	public static NSObject DefaultValue(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("willChangeValueForKey:")]
	public virtual void WillChangeValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillChangeValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillChangeValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("didChangeValueForKey:")]
	public virtual void DidChangeValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidChangeValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidChangeValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("shouldArchiveValueForKey:")]
	public virtual bool ShouldArchiveValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldArchiveValueForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldArchiveValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	private _CAAnimationDelegate EnsureCAAnimationDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _CAAnimationDelegate))
		{
			nSObject = (WeakDelegate = new _CAAnimationDelegate());
		}
		return (_CAAnimationDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TimingFunction_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}

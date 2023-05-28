using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using SceneKit;

namespace CoreAnimation;

[Register("CAAnimation", true)]
public class CAAnimation : NSObject, ICAAction, INativeObject, IDisposable, ICAMediaTiming, INSCoding, INSCopying, INSMutableCopying, INSSecureCoding, ISCNAnimationProtocol
{
	[Register]
	private sealed class _CAAnimationDelegate : CAAnimationDelegate
	{
		internal EventHandler animationStarted;

		internal EventHandler<CAAnimationStateEventArgs> animationStopped;

		public _CAAnimationDelegate()
		{
			base.IsDirectBinding = false;
		}

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimation = "animation";

	private static readonly IntPtr selAnimationHandle = Selector.GetHandle("animation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationEvents = "animationEvents";

	private static readonly IntPtr selAnimationEventsHandle = Selector.GetHandle("animationEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationWithSCNAnimation_ = "animationWithSCNAnimation:";

	private static readonly IntPtr selAnimationWithSCNAnimation_Handle = Selector.GetHandle("animationWithSCNAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoreverses = "autoreverses";

	private static readonly IntPtr selAutoreversesHandle = Selector.GetHandle("autoreverses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginTime = "beginTime";

	private static readonly IntPtr selBeginTimeHandle = Selector.GetHandle("beginTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultValueForKey_ = "defaultValueForKey:";

	private static readonly IntPtr selDefaultValueForKey_Handle = Selector.GetHandle("defaultValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidChangeValueForKey_ = "didChangeValueForKey:";

	private static readonly IntPtr selDidChangeValueForKey_Handle = Selector.GetHandle("didChangeValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeInDuration = "fadeInDuration";

	private static readonly IntPtr selFadeInDurationHandle = Selector.GetHandle("fadeInDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeOutDuration = "fadeOutDuration";

	private static readonly IntPtr selFadeOutDurationHandle = Selector.GetHandle("fadeOutDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillMode = "fillMode";

	private static readonly IntPtr selFillModeHandle = Selector.GetHandle("fillMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRemovedOnCompletion = "isRemovedOnCompletion";

	private static readonly IntPtr selIsRemovedOnCompletionHandle = Selector.GetHandle("isRemovedOnCompletion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepeatCount = "repeatCount";

	private static readonly IntPtr selRepeatCountHandle = Selector.GetHandle("repeatCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepeatDuration = "repeatDuration";

	private static readonly IntPtr selRepeatDurationHandle = Selector.GetHandle("repeatDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunActionForKey_Object_Arguments_ = "runActionForKey:object:arguments:";

	private static readonly IntPtr selRunActionForKey_Object_Arguments_Handle = Selector.GetHandle("runActionForKey:object:arguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimationEvents_ = "setAnimationEvents:";

	private static readonly IntPtr selSetAnimationEvents_Handle = Selector.GetHandle("setAnimationEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoreverses_ = "setAutoreverses:";

	private static readonly IntPtr selSetAutoreverses_Handle = Selector.GetHandle("setAutoreverses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBeginTime_ = "setBeginTime:";

	private static readonly IntPtr selSetBeginTime_Handle = Selector.GetHandle("setBeginTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDuration_ = "setDuration:";

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFadeInDuration_ = "setFadeInDuration:";

	private static readonly IntPtr selSetFadeInDuration_Handle = Selector.GetHandle("setFadeInDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFadeOutDuration_ = "setFadeOutDuration:";

	private static readonly IntPtr selSetFadeOutDuration_Handle = Selector.GetHandle("setFadeOutDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillMode_ = "setFillMode:";

	private static readonly IntPtr selSetFillMode_Handle = Selector.GetHandle("setFillMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRemovedOnCompletion_ = "setRemovedOnCompletion:";

	private static readonly IntPtr selSetRemovedOnCompletion_Handle = Selector.GetHandle("setRemovedOnCompletion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRepeatCount_ = "setRepeatCount:";

	private static readonly IntPtr selSetRepeatCount_Handle = Selector.GetHandle("setRepeatCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRepeatDuration_ = "setRepeatDuration:";

	private static readonly IntPtr selSetRepeatDuration_Handle = Selector.GetHandle("setRepeatDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpeed_ = "setSpeed:";

	private static readonly IntPtr selSetSpeed_Handle = Selector.GetHandle("setSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeOffset_ = "setTimeOffset:";

	private static readonly IntPtr selSetTimeOffset_Handle = Selector.GetHandle("setTimeOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimingFunction_ = "setTimingFunction:";

	private static readonly IntPtr selSetTimingFunction_Handle = Selector.GetHandle("setTimingFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesSceneTimeBase_ = "setUsesSceneTimeBase:";

	private static readonly IntPtr selSetUsesSceneTimeBase_Handle = Selector.GetHandle("setUsesSceneTimeBase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldArchiveValueForKey_ = "shouldArchiveValueForKey:";

	private static readonly IntPtr selShouldArchiveValueForKey_Handle = Selector.GetHandle("shouldArchiveValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeed = "speed";

	private static readonly IntPtr selSpeedHandle = Selector.GetHandle("speed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeOffset = "timeOffset";

	private static readonly IntPtr selTimeOffsetHandle = Selector.GetHandle("timeOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimingFunction = "timingFunction";

	private static readonly IntPtr selTimingFunctionHandle = Selector.GetHandle("timingFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesSceneTimeBase = "usesSceneTimeBase";

	private static readonly IntPtr selUsesSceneTimeBaseHandle = Selector.GetHandle("usesSceneTimeBase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillChangeValueForKey_ = "willChangeValueForKey:";

	private static readonly IntPtr selWillChangeValueForKey_Handle = Selector.GetHandle("willChangeValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAAnimation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationCubic;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationCubicPaced;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationDescrete;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationDiscrete;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationLinear;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AnimationPaced;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RotateModeAuto;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RotateModeAutoReverse;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TransitionFade;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TransitionFromBottom;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TransitionFromLeft;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TransitionFromRight;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TransitionFromTop;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TransitionMoveIn;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TransitionPush;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TransitionReveal;

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

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	public virtual SCNAnimationEvent[]? AnimationEvents
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("animationEvents", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SCNAnimationEvent>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationEventsHandle));
			}
			return NSArray.ArrayFromHandle<SCNAnimationEvent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationEventsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Export("setAnimationEvents:", ArgumentSemantic.Retain)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimationEvents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimationEvents_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutoReverses
	{
		[Export("autoreverses")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutoreversesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutoreversesHandle);
		}
		[Export("setAutoreverses:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutoreverses_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutoreverses_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double BeginTime
	{
		[Export("beginTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBeginTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBeginTimeHandle);
		}
		[Export("setBeginTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetBeginTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetBeginTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
		[Export("setDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual nfloat FadeInDuration
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("fadeInDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFadeInDurationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFadeInDurationHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setFadeInDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFadeInDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFadeInDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual nfloat FadeOutDuration
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("fadeOutDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFadeOutDurationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFadeOutDurationHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setFadeOutDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFadeOutDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFadeOutDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FillMode
	{
		[Export("fillMode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFillModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillModeHandle));
		}
		[Export("setFillMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemovedOnCompletion
	{
		[Export("isRemovedOnCompletion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRemovedOnCompletionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRemovedOnCompletionHandle);
		}
		[Export("setRemovedOnCompletion:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRemovedOnCompletion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRemovedOnCompletion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float RepeatCount
	{
		[Export("repeatCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRepeatCountHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRepeatCountHandle);
		}
		[Export("setRepeatCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRepeatCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRepeatCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double RepeatDuration
	{
		[Export("repeatDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRepeatDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRepeatDurationHandle);
		}
		[Export("setRepeatDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRepeatDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRepeatDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Speed
	{
		[Export("speed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSpeedHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSpeedHandle);
		}
		[Export("setSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TimeOffset
	{
		[Export("timeOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeOffsetHandle);
		}
		[Export("setTimeOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAMediaTimingFunction? TimingFunction
	{
		[Export("timingFunction", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimingFunctionHandle));
			}
			return Runtime.GetNSObject<CAMediaTimingFunction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimingFunctionHandle));
		}
		[Export("setTimingFunction:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimingFunction_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimingFunction_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool UsesSceneTimeBase
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("usesSceneTimeBase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesSceneTimeBaseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesSceneTimeBaseHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setUsesSceneTimeBase:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesSceneTimeBase_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesSceneTimeBase_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle));
		}
		[Export("setDelegate:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[Field("kCAAnimationCubic", "CoreAnimation")]
	public static NSString AnimationCubic
	{
		get
		{
			if (_AnimationCubic == null)
			{
				_AnimationCubic = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAnimationCubic");
			}
			return _AnimationCubic;
		}
	}

	[Field("kCAAnimationCubicPaced", "CoreAnimation")]
	public static NSString AnimationCubicPaced
	{
		get
		{
			if (_AnimationCubicPaced == null)
			{
				_AnimationCubicPaced = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAnimationCubicPaced");
			}
			return _AnimationCubicPaced;
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

	[Field("kCAAnimationDiscrete", "CoreAnimation")]
	public static NSString AnimationDiscrete
	{
		get
		{
			if (_AnimationDiscrete == null)
			{
				_AnimationDiscrete = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAnimationDiscrete");
			}
			return _AnimationDiscrete;
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

	private _CAAnimationDelegate EnsureCAAnimationDelegate()
	{
		CAAnimationDelegate cAAnimationDelegate = Delegate;
		if (cAAnimationDelegate == null || !(cAAnimationDelegate is _CAAnimationDelegate))
		{
			cAAnimationDelegate = (Delegate = new _CAAnimationDelegate());
		}
		return (_CAAnimationDelegate)cAAnimationDelegate;
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", EntryPoint = "CACurrentMediaTime")]
	public static extern double CurrentMediaTime();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAAnimation()
		: base(NSObjectFlag.Empty)
	{
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
	public CAAnimation(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected CAAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("animation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAAnimation CreateAnimation()
	{
		return Runtime.GetNSObject<CAAnimation>(Messaging.IntPtr_objc_msgSend(class_ptr, selAnimationHandle));
	}

	[Export("defaultValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject DefaultValue(string? key)
	{
		IntPtr arg = NSString.CreateNative(key);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("didChangeValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidChangeValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidChangeValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("animationWithSCNAnimation:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAAnimation FromSCNAnimation(SCNAnimation animation)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		return Runtime.GetNSObject<CAAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAnimationWithSCNAnimation_Handle, animation.Handle));
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("runActionForKey:object:arguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunAction(string eventKey, NSObject obj, NSDictionary? arguments)
	{
		if (eventKey == null)
		{
			throw new ArgumentNullException("eventKey");
		}
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		IntPtr arg = NSString.CreateNative(eventKey);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRunActionForKey_Object_Arguments_Handle, arg, obj.Handle, arguments?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunActionForKey_Object_Arguments_Handle, arg, obj.Handle, arguments?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("shouldArchiveValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldArchiveValueForKey(string? key)
	{
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldArchiveValueForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldArchiveValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("willChangeValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillChangeValueForKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillChangeValueForKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillChangeValueForKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}
}

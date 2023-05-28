using System;
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNAction", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNAction : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomActionWithDuration_ActionBlock_ = "customActionWithDuration:actionBlock:";

	private static readonly IntPtr selCustomActionWithDuration_ActionBlock_Handle = Selector.GetHandle("customActionWithDuration:actionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeInWithDuration_ = "fadeInWithDuration:";

	private static readonly IntPtr selFadeInWithDuration_Handle = Selector.GetHandle("fadeInWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeOpacityBy_Duration_ = "fadeOpacityBy:duration:";

	private static readonly IntPtr selFadeOpacityBy_Duration_Handle = Selector.GetHandle("fadeOpacityBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeOpacityTo_Duration_ = "fadeOpacityTo:duration:";

	private static readonly IntPtr selFadeOpacityTo_Duration_Handle = Selector.GetHandle("fadeOpacityTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFadeOutWithDuration_ = "fadeOutWithDuration:";

	private static readonly IntPtr selFadeOutWithDuration_Handle = Selector.GetHandle("fadeOutWithDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroup_ = "group:";

	private static readonly IntPtr selGroup_Handle = Selector.GetHandle("group:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHide = "hide";

	private static readonly IntPtr selHideHandle = Selector.GetHandle("hide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJavaScriptActionWithScript_Duration_ = "javaScriptActionWithScript:duration:";

	private static readonly IntPtr selJavaScriptActionWithScript_Duration_Handle = Selector.GetHandle("javaScriptActionWithScript:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveBy_Duration_ = "moveBy:duration:";

	private static readonly IntPtr selMoveBy_Duration_Handle = Selector.GetHandle("moveBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveByX_Y_Z_Duration_ = "moveByX:y:z:duration:";

	private static readonly IntPtr selMoveByX_Y_Z_Duration_Handle = Selector.GetHandle("moveByX:y:z:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveTo_Duration_ = "moveTo:duration:";

	private static readonly IntPtr selMoveTo_Duration_Handle = Selector.GetHandle("moveTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayAudioSource_WaitForCompletion_ = "playAudioSource:waitForCompletion:";

	private static readonly IntPtr selPlayAudioSource_WaitForCompletion_Handle = Selector.GetHandle("playAudioSource:waitForCompletion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromParentNode = "removeFromParentNode";

	private static readonly IntPtr selRemoveFromParentNodeHandle = Selector.GetHandle("removeFromParentNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepeatAction_Count_ = "repeatAction:count:";

	private static readonly IntPtr selRepeatAction_Count_Handle = Selector.GetHandle("repeatAction:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepeatActionForever_ = "repeatActionForever:";

	private static readonly IntPtr selRepeatActionForever_Handle = Selector.GetHandle("repeatActionForever:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReversedAction = "reversedAction";

	private static readonly IntPtr selReversedActionHandle = Selector.GetHandle("reversedAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateByAngle_AroundAxis_Duration_ = "rotateByAngle:aroundAxis:duration:";

	private static readonly IntPtr selRotateByAngle_AroundAxis_Duration_Handle = Selector.GetHandle("rotateByAngle:aroundAxis:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateByX_Y_Z_Duration_ = "rotateByX:y:z:duration:";

	private static readonly IntPtr selRotateByX_Y_Z_Duration_Handle = Selector.GetHandle("rotateByX:y:z:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateToAxisAngle_Duration_ = "rotateToAxisAngle:duration:";

	private static readonly IntPtr selRotateToAxisAngle_Duration_Handle = Selector.GetHandle("rotateToAxisAngle:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateToX_Y_Z_Duration_ = "rotateToX:y:z:duration:";

	private static readonly IntPtr selRotateToX_Y_Z_Duration_Handle = Selector.GetHandle("rotateToX:y:z:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateToX_Y_Z_Duration_ShortestUnitArc_ = "rotateToX:y:z:duration:shortestUnitArc:";

	private static readonly IntPtr selRotateToX_Y_Z_Duration_ShortestUnitArc_Handle = Selector.GetHandle("rotateToX:y:z:duration:shortestUnitArc:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunBlock_ = "runBlock:";

	private static readonly IntPtr selRunBlock_Handle = Selector.GetHandle("runBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunBlock_Queue_ = "runBlock:queue:";

	private static readonly IntPtr selRunBlock_Queue_Handle = Selector.GetHandle("runBlock:queue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleBy_Duration_ = "scaleBy:duration:";

	private static readonly IntPtr selScaleBy_Duration_Handle = Selector.GetHandle("scaleBy:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleTo_Duration_ = "scaleTo:duration:";

	private static readonly IntPtr selScaleTo_Duration_Handle = Selector.GetHandle("scaleTo:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSequence_ = "sequence:";

	private static readonly IntPtr selSequence_Handle = Selector.GetHandle("sequence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDuration_ = "setDuration:";

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpeed_ = "setSpeed:";

	private static readonly IntPtr selSetSpeed_Handle = Selector.GetHandle("setSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimingFunction_ = "setTimingFunction:";

	private static readonly IntPtr selSetTimingFunction_Handle = Selector.GetHandle("setTimingFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimingMode_ = "setTimingMode:";

	private static readonly IntPtr selSetTimingMode_Handle = Selector.GetHandle("setTimingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeed = "speed";

	private static readonly IntPtr selSpeedHandle = Selector.GetHandle("speed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimingFunction = "timingFunction";

	private static readonly IntPtr selTimingFunctionHandle = Selector.GetHandle("timingFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimingMode = "timingMode";

	private static readonly IntPtr selTimingModeHandle = Selector.GetHandle("timingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnhide = "unhide";

	private static readonly IntPtr selUnhideHandle = Selector.GetHandle("unhide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitForDuration_ = "waitForDuration:";

	private static readonly IntPtr selWaitForDuration_Handle = Selector.GetHandle("waitForDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitForDuration_WithRange_ = "waitForDuration:withRange:";

	private static readonly IntPtr selWaitForDuration_WithRange_Handle = Selector.GetHandle("waitForDuration:withRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNAction");

	[Obsolete("Use 'TimingFunction2' property.")]
	public virtual Action<float> TimingFunction
	{
		get
		{
			if (TimingFunction2 == null)
			{
				return null;
			}
			return delegate(float f)
			{
				TimingFunction2(f);
			};
		}
		set
		{
			if (value == null)
			{
				TimingFunction2 = null;
				return;
			}
			TimingFunction2 = delegate(float f)
			{
				value(f);
				return float.NaN;
			};
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DurationInSeconds
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
	public virtual nfloat Speed
	{
		[Export("speed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selSpeedHandle);
		}
		[Export("setSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Func<float, float>? TimingFunction2
	{
		[Export("timingFunction", ArgumentSemantic.Assign)]
		[return: DelegateProxy(typeof(Trampolines.SDFuncArity2V6))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimingFunctionHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selTimingFunctionHandle));
			return Trampolines.NIDFuncArity2V6.Create(block);
		}
		[Export("setTimingFunction:", ArgumentSemantic.Assign)]
		[param: BlockProxy(typeof(Trampolines.NIDFuncArity2V6))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity2V6.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimingFunction_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimingFunction_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNActionTimingMode TimingMode
	{
		[Export("timingMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNActionTimingMode)Messaging.Int64_objc_msgSend(base.Handle, selTimingModeHandle);
			}
			return (SCNActionTimingMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTimingModeHandle);
		}
		[Export("setTimingMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTimingMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTimingMode_Handle, (long)value);
			}
		}
	}

	[Obsolete("Use 'TimingFunction2' property.")]
	public virtual void SetTimingFunction(Action<float> timingFunction)
	{
		TimingFunction = timingFunction;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNAction()
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
	public SCNAction(NSCoder coder)
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
	protected SCNAction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNAction(IntPtr handle)
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

	[Export("customActionWithDuration:actionBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static SCNAction CustomAction(double seconds, [BlockProxy(typeof(Trampolines.NIDSCNActionNodeWithElapsedTimeHandler))] SCNActionNodeWithElapsedTimeHandler handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNActionNodeWithElapsedTimeHandler.Handler, handler);
		SCNAction nSObject = Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_Double_IntPtr(class_ptr, selCustomActionWithDuration_ActionBlock_Handle, seconds, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
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

	[Export("fadeInWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction FadeIn(double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selFadeInWithDuration_Handle, durationInSeconds));
	}

	[Export("fadeOpacityBy:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction FadeOpacityBy(nfloat factor, double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selFadeOpacityBy_Duration_Handle, factor, durationInSeconds));
	}

	[Export("fadeOpacityTo:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction FadeOpacityTo(nfloat opacity, double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selFadeOpacityTo_Duration_Handle, opacity, durationInSeconds));
	}

	[Export("fadeOutWithDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction FadeOut(double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selFadeOutWithDuration_Handle, durationInSeconds));
	}

	[Export("javaScriptActionWithScript:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction FromJavascript(string script, double seconds)
	{
		if (script == null)
		{
			throw new ArgumentNullException("script");
		}
		IntPtr arg = NSString.CreateNative(script);
		SCNAction nSObject = Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selJavaScriptActionWithScript_Duration_Handle, arg, seconds));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("group:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction Group(SCNAction[] actions)
	{
		if (actions == null)
		{
			throw new ArgumentNullException("actions");
		}
		NSArray nSArray = NSArray.FromNSObjects(actions);
		SCNAction nSObject = Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selGroup_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("hide")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction Hide()
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend(class_ptr, selHideHandle));
	}

	[Export("moveByX:y:z:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction MoveBy(nfloat deltaX, nfloat deltaY, nfloat deltaZ, double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_Double(class_ptr, selMoveByX_Y_Z_Duration_Handle, deltaX, deltaY, deltaZ, durationInSeconds));
	}

	[Export("moveBy:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction MoveBy(SCNVector3 delta, double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_SCNVector3_Double(class_ptr, selMoveBy_Duration_Handle, delta, durationInSeconds));
	}

	[Export("moveTo:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction MoveTo(SCNVector3 location, double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_SCNVector3_Double(class_ptr, selMoveTo_Duration_Handle, location, durationInSeconds));
	}

	[Export("playAudioSource:waitForCompletion:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction PlayAudioSource(SCNAudioSource source, bool wait)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selPlayAudioSource_WaitForCompletion_Handle, source.Handle, wait));
	}

	[Export("removeFromParentNode")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction RemoveFromParentNode()
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend(class_ptr, selRemoveFromParentNodeHandle));
	}

	[Export("repeatAction:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction RepeatAction(SCNAction action, nuint count)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selRepeatAction_Count_Handle, action.Handle, count));
	}

	[Export("repeatActionForever:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction RepeatActionForever(SCNAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selRepeatActionForever_Handle, action.Handle));
	}

	[Export("reversedAction")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNAction ReversedAction()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend(base.Handle, selReversedActionHandle));
		}
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReversedActionHandle));
	}

	[Export("rotateByX:y:z:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction RotateBy(nfloat xAngle, nfloat yAngle, nfloat zAngle, double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_Double(class_ptr, selRotateByX_Y_Z_Duration_Handle, xAngle, yAngle, zAngle, durationInSeconds));
	}

	[Export("rotateByAngle:aroundAxis:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction RotateBy(nfloat angle, SCNVector3 axis, double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_nfloat_SCNVector3_Double(class_ptr, selRotateByAngle_AroundAxis_Duration_Handle, angle, axis, durationInSeconds));
	}

	[Export("rotateToX:y:z:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction RotateTo(nfloat xAngle, nfloat yAngle, nfloat zAngle, double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_Double(class_ptr, selRotateToX_Y_Z_Duration_Handle, xAngle, yAngle, zAngle, durationInSeconds));
	}

	[Export("rotateToX:y:z:duration:shortestUnitArc:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction RotateTo(nfloat xAngle, nfloat yAngle, nfloat zAngle, double durationInSeconds, bool shortestUnitArc)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_Double_bool(class_ptr, selRotateToX_Y_Z_Duration_ShortestUnitArc_Handle, xAngle, yAngle, zAngle, durationInSeconds, shortestUnitArc));
	}

	[Export("rotateToAxisAngle:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction RotateTo(SCNVector4 axisAngle, double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_SCNVector4_Double(class_ptr, selRotateToAxisAngle_Duration_Handle, axisAngle, durationInSeconds));
	}

	[Export("runBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static SCNAction Run([BlockProxy(typeof(Trampolines.NIDActionArity1V85))] Action<SCNNode> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V85.Handler, handler);
		SCNAction nSObject = Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selRunBlock_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("runBlock:queue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static SCNAction Run([BlockProxy(typeof(Trampolines.NIDActionArity1V85))] Action<SCNNode> handler, DispatchQueue queue)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V85.Handler, handler);
		SCNAction nSObject = Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selRunBlock_Queue_Handle, (IntPtr)ptr, queue.Handle));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("scaleBy:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction ScaleBy(nfloat scale, double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selScaleBy_Duration_Handle, scale, durationInSeconds));
	}

	[Export("scaleTo:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction ScaleTo(nfloat scale, double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_nfloat_Double(class_ptr, selScaleTo_Duration_Handle, scale, durationInSeconds));
	}

	[Export("sequence:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction Sequence(SCNAction[] actions)
	{
		if (actions == null)
		{
			throw new ArgumentNullException("actions");
		}
		NSArray nSArray = NSArray.FromNSObjects(actions);
		SCNAction nSObject = Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSequence_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("unhide")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction Unhide()
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnhideHandle));
	}

	[Export("waitForDuration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction Wait(double durationInSeconds)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selWaitForDuration_Handle, durationInSeconds));
	}

	[Export("waitForDuration:withRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAction Wait(double durationInSeconds, double durationRange)
	{
		return Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_Double_Double(class_ptr, selWaitForDuration_WithRange_Handle, durationInSeconds, durationRange));
	}
}

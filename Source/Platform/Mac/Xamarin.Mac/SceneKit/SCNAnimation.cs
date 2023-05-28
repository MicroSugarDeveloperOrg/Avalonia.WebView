using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNAnimation", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class SCNAnimation : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding, ISCNAnimationProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationDidStart = "animationDidStart";

	private static readonly IntPtr selAnimationDidStartHandle = Selector.GetHandle("animationDidStart");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationDidStop = "animationDidStop";

	private static readonly IntPtr selAnimationDidStopHandle = Selector.GetHandle("animationDidStop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationEvents = "animationEvents";

	private static readonly IntPtr selAnimationEventsHandle = Selector.GetHandle("animationEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationNamed_ = "animationNamed:";

	private static readonly IntPtr selAnimationNamed_Handle = Selector.GetHandle("animationNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationWithCAAnimation_ = "animationWithCAAnimation:";

	private static readonly IntPtr selAnimationWithCAAnimation_Handle = Selector.GetHandle("animationWithCAAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationWithContentsOfURL_ = "animationWithContentsOfURL:";

	private static readonly IntPtr selAnimationWithContentsOfURL_Handle = Selector.GetHandle("animationWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutoreverses = "autoreverses";

	private static readonly IntPtr selAutoreversesHandle = Selector.GetHandle("autoreverses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendInDuration = "blendInDuration";

	private static readonly IntPtr selBlendInDurationHandle = Selector.GetHandle("blendInDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendOutDuration = "blendOutDuration";

	private static readonly IntPtr selBlendOutDurationHandle = Selector.GetHandle("blendOutDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillsBackward = "fillsBackward";

	private static readonly IntPtr selFillsBackwardHandle = Selector.GetHandle("fillsBackward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillsForward = "fillsForward";

	private static readonly IntPtr selFillsForwardHandle = Selector.GetHandle("fillsForward");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAdditive = "isAdditive";

	private static readonly IntPtr selIsAdditiveHandle = Selector.GetHandle("isAdditive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAppliedOnCompletion = "isAppliedOnCompletion";

	private static readonly IntPtr selIsAppliedOnCompletionHandle = Selector.GetHandle("isAppliedOnCompletion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCumulative = "isCumulative";

	private static readonly IntPtr selIsCumulativeHandle = Selector.GetHandle("isCumulative");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRemovedOnCompletion = "isRemovedOnCompletion";

	private static readonly IntPtr selIsRemovedOnCompletionHandle = Selector.GetHandle("isRemovedOnCompletion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyPath = "keyPath";

	private static readonly IntPtr selKeyPathHandle = Selector.GetHandle("keyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepeatCount = "repeatCount";

	private static readonly IntPtr selRepeatCountHandle = Selector.GetHandle("repeatCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAdditive_ = "setAdditive:";

	private static readonly IntPtr selSetAdditive_Handle = Selector.GetHandle("setAdditive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimationDidStart_ = "setAnimationDidStart:";

	private static readonly IntPtr selSetAnimationDidStart_Handle = Selector.GetHandle("setAnimationDidStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimationDidStop_ = "setAnimationDidStop:";

	private static readonly IntPtr selSetAnimationDidStop_Handle = Selector.GetHandle("setAnimationDidStop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimationEvents_ = "setAnimationEvents:";

	private static readonly IntPtr selSetAnimationEvents_Handle = Selector.GetHandle("setAnimationEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAppliedOnCompletion_ = "setAppliedOnCompletion:";

	private static readonly IntPtr selSetAppliedOnCompletion_Handle = Selector.GetHandle("setAppliedOnCompletion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutoreverses_ = "setAutoreverses:";

	private static readonly IntPtr selSetAutoreverses_Handle = Selector.GetHandle("setAutoreverses:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendInDuration_ = "setBlendInDuration:";

	private static readonly IntPtr selSetBlendInDuration_Handle = Selector.GetHandle("setBlendInDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendOutDuration_ = "setBlendOutDuration:";

	private static readonly IntPtr selSetBlendOutDuration_Handle = Selector.GetHandle("setBlendOutDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCumulative_ = "setCumulative:";

	private static readonly IntPtr selSetCumulative_Handle = Selector.GetHandle("setCumulative:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDuration_ = "setDuration:";

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillsBackward_ = "setFillsBackward:";

	private static readonly IntPtr selSetFillsBackward_Handle = Selector.GetHandle("setFillsBackward:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillsForward_ = "setFillsForward:";

	private static readonly IntPtr selSetFillsForward_Handle = Selector.GetHandle("setFillsForward:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyPath_ = "setKeyPath:";

	private static readonly IntPtr selSetKeyPath_Handle = Selector.GetHandle("setKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRemovedOnCompletion_ = "setRemovedOnCompletion:";

	private static readonly IntPtr selSetRemovedOnCompletion_Handle = Selector.GetHandle("setRemovedOnCompletion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRepeatCount_ = "setRepeatCount:";

	private static readonly IntPtr selSetRepeatCount_Handle = Selector.GetHandle("setRepeatCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStartDelay_ = "setStartDelay:";

	private static readonly IntPtr selSetStartDelay_Handle = Selector.GetHandle("setStartDelay:");

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
	private const string selStartDelay = "startDelay";

	private static readonly IntPtr selStartDelayHandle = Selector.GetHandle("startDelay");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNAnimation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Additive
	{
		[Export("isAdditive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAdditiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAdditiveHandle);
		}
		[Export("setAdditive:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAdditive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAdditive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'AnimationDidStart2' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe virtual SCNAnimationDidStartHandler? AnimationDidStart
	{
		[Export("animationDidStart", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDSCNAnimationDidStartHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationDidStartHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationDidStartHandle));
			return Trampolines.NIDSCNAnimationDidStartHandler.Create(block);
		}
		[Export("setAnimationDidStart:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDSCNAnimationDidStartHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNAnimationDidStartHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimationDidStart_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimationDidStart_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe SCNAnimationDidStartHandler2? AnimationDidStart2
	{
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationDidStartHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationDidStartHandle));
			return Trampolines.NIDSCNAnimationDidStartHandler2.Create(block);
		}
		[param: BlockProxy(typeof(Trampolines.NIDSCNAnimationDidStartHandler2))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNAnimationDidStartHandler2.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimationDidStart_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimationDidStart_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'AnimationDidStop2' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public unsafe virtual SCNAnimationDidStopHandler? AnimationDidStop
	{
		[Export("animationDidStop", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDSCNAnimationDidStopHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationDidStopHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationDidStopHandle));
			return Trampolines.NIDSCNAnimationDidStopHandler.Create(block);
		}
		[Export("setAnimationDidStop:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDSCNAnimationDidStopHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNAnimationDidStopHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimationDidStop_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimationDidStop_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe SCNAnimationDidStopHandler2? AnimationDidStop2
	{
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationDidStopHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationDidStopHandle));
			return Trampolines.NIDSCNAnimationDidStopHandler2.Create(block);
		}
		[param: BlockProxy(typeof(Trampolines.NIDSCNAnimationDidStopHandler2))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNAnimationDidStopHandler2.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimationDidStop_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimationDidStop_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNAnimationEvent[]? AnimationEvents
	{
		[Export("animationEvents", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SCNAnimationEvent>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationEventsHandle));
			}
			return NSArray.ArrayFromHandle<SCNAnimationEvent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationEventsHandle));
		}
		[Export("setAnimationEvents:", ArgumentSemantic.Copy)]
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
	public virtual bool AppliedOnCompletion
	{
		[Export("isAppliedOnCompletion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAppliedOnCompletionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAppliedOnCompletionHandle);
		}
		[Export("setAppliedOnCompletion:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAppliedOnCompletion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAppliedOnCompletion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Autoreverses
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
	public virtual double BlendInDuration
	{
		[Export("blendInDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBlendInDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBlendInDurationHandle);
		}
		[Export("setBlendInDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetBlendInDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetBlendInDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double BlendOutDuration
	{
		[Export("blendOutDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBlendOutDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBlendOutDurationHandle);
		}
		[Export("setBlendOutDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetBlendOutDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetBlendOutDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Cumulative
	{
		[Export("isCumulative")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCumulativeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCumulativeHandle);
		}
		[Export("setCumulative:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCumulative_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCumulative_Handle, value);
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
	public virtual bool FillsBackward
	{
		[Export("fillsBackward")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFillsBackwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFillsBackwardHandle);
		}
		[Export("setFillsBackward:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFillsBackward_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFillsBackward_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FillsForward
	{
		[Export("fillsForward")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFillsForwardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFillsForwardHandle);
		}
		[Export("setFillsForward:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFillsForward_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFillsForward_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? KeyPath
	{
		[Export("keyPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyPathHandle));
		}
		[Export("setKeyPath:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeyPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeyPath_Handle, arg);
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
	public virtual nfloat RepeatCount
	{
		[Export("repeatCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRepeatCountHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRepeatCountHandle);
		}
		[Export("setRepeatCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRepeatCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRepeatCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double StartDelay
	{
		[Export("startDelay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selStartDelayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selStartDelayHandle);
		}
		[Export("setStartDelay:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetStartDelay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetStartDelay_Handle, value);
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
	public virtual SCNTimingFunction TimingFunction
	{
		[Export("timingFunction", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SCNTimingFunction>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimingFunctionHandle));
			}
			return Runtime.GetNSObject<SCNTimingFunction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimingFunctionHandle));
		}
		[Export("setTimingFunction:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTimingFunction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTimingFunction_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesSceneTimeBase
	{
		[Export("usesSceneTimeBase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesSceneTimeBaseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesSceneTimeBaseHandle);
		}
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNAnimation()
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
	public SCNAnimation(NSCoder coder)
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
	protected SCNAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNAnimation(IntPtr handle)
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

	[Export("animationWithCAAnimation:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAnimation FromCAAnimation(CAAnimation caAnimation)
	{
		if (caAnimation == null)
		{
			throw new ArgumentNullException("caAnimation");
		}
		return Runtime.GetNSObject<SCNAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAnimationWithCAAnimation_Handle, caAnimation.Handle));
	}

	[Export("animationNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAnimation FromName(string animationName)
	{
		if (animationName == null)
		{
			throw new ArgumentNullException("animationName");
		}
		IntPtr arg = NSString.CreateNative(animationName);
		SCNAnimation nSObject = Runtime.GetNSObject<SCNAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAnimationNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("animationWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAnimation FromUrl(NSUrl animationUrl)
	{
		if (animationUrl == null)
		{
			throw new ArgumentNullException("animationUrl");
		}
		return Runtime.GetNSObject<SCNAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAnimationWithContentsOfURL_Handle, animationUrl.Handle));
	}
}

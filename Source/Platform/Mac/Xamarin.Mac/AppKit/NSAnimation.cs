using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAnimation", true)]
public class NSAnimation : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	[Register]
	internal class _NSAnimationDelegate : NSObject, INSAnimationDelegate, INativeObject, IDisposable
	{
		internal EventHandler? animationDidEnd;

		internal EventHandler<NSAnimationEventArgs>? animationDidReachProgressMark;

		internal EventHandler? animationDidStop;

		internal NSAnimationPredicate? animationShouldStart;

		internal NSAnimationProgress? computeAnimationCurve;

		public _NSAnimationDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("animationDidEnd:")]
		public void AnimationDidEnd(NSAnimation animation)
		{
			animationDidEnd?.Invoke(animation, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("animation:didReachProgressMark:")]
		public void AnimationDidReachProgressMark(NSAnimation animation, float progress)
		{
			EventHandler<NSAnimationEventArgs> eventHandler = animationDidReachProgressMark;
			if (eventHandler != null)
			{
				NSAnimationEventArgs e = new NSAnimationEventArgs(progress);
				eventHandler(animation, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("animationDidStop:")]
		public void AnimationDidStop(NSAnimation animation)
		{
			animationDidStop?.Invoke(animation, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("animationShouldStart:")]
		public bool AnimationShouldStart(NSAnimation animation)
		{
			return animationShouldStart?.Invoke(animation) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("animation:valueForProgress:")]
		public float ComputeAnimationCurve(NSAnimation animation, float progress)
		{
			return computeAnimationCurve?.Invoke(animation, progress) ?? progress;
		}
	}

	public static class Notifications
	{
		public static NSObject ObserveProgressMark(EventHandler<NSAnimationProgressMarkEventArgs> handler)
		{
			EventHandler<NSAnimationProgressMarkEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ProgressMarkNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSAnimationProgressMarkEventArgs(notification));
			});
		}

		public static NSObject ObserveProgressMark(NSObject objectToObserve, EventHandler<NSAnimationProgressMarkEventArgs> handler)
		{
			EventHandler<NSAnimationProgressMarkEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ProgressMarkNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSAnimationProgressMarkEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddProgressMark_ = "addProgressMark:";

	private static readonly IntPtr selAddProgressMark_Handle = Selector.GetHandle("addProgressMark:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationBlockingMode = "animationBlockingMode";

	private static readonly IntPtr selAnimationBlockingModeHandle = Selector.GetHandle("animationBlockingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationCurve = "animationCurve";

	private static readonly IntPtr selAnimationCurveHandle = Selector.GetHandle("animationCurve");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearStartAnimation = "clearStartAnimation";

	private static readonly IntPtr selClearStartAnimationHandle = Selector.GetHandle("clearStartAnimation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearStopAnimation = "clearStopAnimation";

	private static readonly IntPtr selClearStopAnimationHandle = Selector.GetHandle("clearStopAnimation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentProgress = "currentProgress";

	private static readonly IntPtr selCurrentProgressHandle = Selector.GetHandle("currentProgress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentValue = "currentValue";

	private static readonly IntPtr selCurrentValueHandle = Selector.GetHandle("currentValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameRate = "frameRate";

	private static readonly IntPtr selFrameRateHandle = Selector.GetHandle("frameRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDuration_AnimationCurve_ = "initWithDuration:animationCurve:";

	private static readonly IntPtr selInitWithDuration_AnimationCurve_Handle = Selector.GetHandle("initWithDuration:animationCurve:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAnimating = "isAnimating";

	private static readonly IntPtr selIsAnimatingHandle = Selector.GetHandle("isAnimating");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgressMarks = "progressMarks";

	private static readonly IntPtr selProgressMarksHandle = Selector.GetHandle("progressMarks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveProgressMark_ = "removeProgressMark:";

	private static readonly IntPtr selRemoveProgressMark_Handle = Selector.GetHandle("removeProgressMark:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunLoopModesForAnimating = "runLoopModesForAnimating";

	private static readonly IntPtr selRunLoopModesForAnimatingHandle = Selector.GetHandle("runLoopModesForAnimating");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimationBlockingMode_ = "setAnimationBlockingMode:";

	private static readonly IntPtr selSetAnimationBlockingMode_Handle = Selector.GetHandle("setAnimationBlockingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimationCurve_ = "setAnimationCurve:";

	private static readonly IntPtr selSetAnimationCurve_Handle = Selector.GetHandle("setAnimationCurve:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentProgress_ = "setCurrentProgress:";

	private static readonly IntPtr selSetCurrentProgress_Handle = Selector.GetHandle("setCurrentProgress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDuration_ = "setDuration:";

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameRate_ = "setFrameRate:";

	private static readonly IntPtr selSetFrameRate_Handle = Selector.GetHandle("setFrameRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProgressMarks_ = "setProgressMarks:";

	private static readonly IntPtr selSetProgressMarks_Handle = Selector.GetHandle("setProgressMarks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartAnimation = "startAnimation";

	private static readonly IntPtr selStartAnimationHandle = Selector.GetHandle("startAnimation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartWhenAnimation_ReachesProgress_ = "startWhenAnimation:reachesProgress:";

	private static readonly IntPtr selStartWhenAnimation_ReachesProgress_Handle = Selector.GetHandle("startWhenAnimation:reachesProgress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopAnimation = "stopAnimation";

	private static readonly IntPtr selStopAnimationHandle = Selector.GetHandle("stopAnimation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopWhenAnimation_ReachesProgress_ = "stopWhenAnimation:reachesProgress:";

	private static readonly IntPtr selStopWhenAnimation_ReachesProgress_Handle = Selector.GetHandle("stopWhenAnimation:reachesProgress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAnimation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProgressMark;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProgressMarkNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TriggerOrderIn;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TriggerOrderOut;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAnimationBlockingMode AnimationBlockingMode
	{
		[Export("animationBlockingMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAnimationBlockingMode)Messaging.UInt64_objc_msgSend(base.Handle, selAnimationBlockingModeHandle);
			}
			return (NSAnimationBlockingMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAnimationBlockingModeHandle);
		}
		[Export("setAnimationBlockingMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAnimationBlockingMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAnimationBlockingMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAnimationCurve AnimationCurve
	{
		[Export("animationCurve")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAnimationCurve)Messaging.UInt64_objc_msgSend(base.Handle, selAnimationCurveHandle);
			}
			return (NSAnimationCurve)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAnimationCurveHandle);
		}
		[Export("setAnimationCurve:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAnimationCurve_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAnimationCurve_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float CurrentProgress
	{
		[Export("currentProgress")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selCurrentProgressHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selCurrentProgressHandle);
		}
		[Export("setCurrentProgress:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetCurrentProgress_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetCurrentProgress_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float CurrentValue
	{
		[Export("currentValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selCurrentValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selCurrentValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSAnimationDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSAnimationDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
		[Export("setDuration:")]
		set
		{
			NSApplication.EnsureUIThread();
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
	public virtual float FrameRate
	{
		[Export("frameRate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFrameRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFrameRateHandle);
		}
		[Export("setFrameRate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFrameRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFrameRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] ProgressMarks
	{
		[Export("progressMarks", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selProgressMarksHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProgressMarksHandle));
		}
		[Export("setProgressMarks:", ArgumentSemantic.Copy)]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProgressMarks_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProgressMarks_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] RunLoopModesForAnimating
	{
		[Export("runLoopModesForAnimating")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selRunLoopModesForAnimatingHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRunLoopModesForAnimatingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[Field("NSAnimationProgressMark", "AppKit")]
	public static NSString ProgressMark
	{
		get
		{
			if (_ProgressMark == null)
			{
				_ProgressMark = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAnimationProgressMark");
			}
			return _ProgressMark;
		}
	}

	[Field("NSAnimationProgressMarkNotification", "AppKit")]
	[Advice("Use NSAnimation.Notifications.ObserveProgressMark helper method instead.")]
	public static NSString ProgressMarkNotification
	{
		get
		{
			if (_ProgressMarkNotification == null)
			{
				_ProgressMarkNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAnimationProgressMarkNotification");
			}
			return _ProgressMarkNotification;
		}
	}

	[Field("NSAnimationTriggerOrderIn", "AppKit")]
	public static NSString TriggerOrderIn
	{
		get
		{
			if (_TriggerOrderIn == null)
			{
				_TriggerOrderIn = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAnimationTriggerOrderIn");
			}
			return _TriggerOrderIn;
		}
	}

	[Field("NSAnimationTriggerOrderOut", "AppKit")]
	public static NSString TriggerOrderOut
	{
		get
		{
			if (_TriggerOrderOut == null)
			{
				_TriggerOrderOut = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAnimationTriggerOrderOut");
			}
			return _TriggerOrderOut;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSAnimationDelegate);

	public NSAnimationPredicate? AnimationShouldStart
	{
		get
		{
			return EnsureNSAnimationDelegate().animationShouldStart;
		}
		set
		{
			EnsureNSAnimationDelegate().animationShouldStart = value;
		}
	}

	public NSAnimationProgress? ComputeAnimationCurve
	{
		get
		{
			return EnsureNSAnimationDelegate().computeAnimationCurve;
		}
		set
		{
			EnsureNSAnimationDelegate().computeAnimationCurve = value;
		}
	}

	public event EventHandler AnimationDidEnd
	{
		add
		{
			_NSAnimationDelegate nSAnimationDelegate = EnsureNSAnimationDelegate();
			nSAnimationDelegate.animationDidEnd = (EventHandler)System.Delegate.Combine(nSAnimationDelegate.animationDidEnd, value);
		}
		remove
		{
			_NSAnimationDelegate nSAnimationDelegate = EnsureNSAnimationDelegate();
			nSAnimationDelegate.animationDidEnd = (EventHandler)System.Delegate.Remove(nSAnimationDelegate.animationDidEnd, value);
		}
	}

	public event EventHandler<NSAnimationEventArgs> AnimationDidReachProgressMark
	{
		add
		{
			_NSAnimationDelegate nSAnimationDelegate = EnsureNSAnimationDelegate();
			nSAnimationDelegate.animationDidReachProgressMark = (EventHandler<NSAnimationEventArgs>)System.Delegate.Combine(nSAnimationDelegate.animationDidReachProgressMark, value);
		}
		remove
		{
			_NSAnimationDelegate nSAnimationDelegate = EnsureNSAnimationDelegate();
			nSAnimationDelegate.animationDidReachProgressMark = (EventHandler<NSAnimationEventArgs>)System.Delegate.Remove(nSAnimationDelegate.animationDidReachProgressMark, value);
		}
	}

	public event EventHandler AnimationDidStop
	{
		add
		{
			_NSAnimationDelegate nSAnimationDelegate = EnsureNSAnimationDelegate();
			nSAnimationDelegate.animationDidStop = (EventHandler)System.Delegate.Combine(nSAnimationDelegate.animationDidStop, value);
		}
		remove
		{
			_NSAnimationDelegate nSAnimationDelegate = EnsureNSAnimationDelegate();
			nSAnimationDelegate.animationDidStop = (EventHandler)System.Delegate.Remove(nSAnimationDelegate.animationDidStop, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAnimation()
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
	public NSAnimation(NSCoder coder)
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
	protected NSAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAnimation(double duration, NSAnimationCurve animationCurve)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double_UInt64(base.Handle, selInitWithDuration_AnimationCurve_Handle, duration, (ulong)animationCurve), "initWithDuration:animationCurve:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double_UInt64(base.SuperHandle, selInitWithDuration_AnimationCurve_Handle, duration, (ulong)animationCurve), "initWithDuration:animationCurve:");
		}
	}

	[Export("addProgressMark:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddProgressMark(float progressMark)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float(base.Handle, selAddProgressMark_Handle, progressMark);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selAddProgressMark_Handle, progressMark);
		}
	}

	[Export("clearStartAnimation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClearStartAnimation()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearStartAnimationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearStartAnimationHandle);
		}
	}

	[Export("clearStopAnimation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClearStopAnimation()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearStopAnimationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearStopAnimationHandle);
		}
	}

	[Export("initWithDuration:animationCurve:")]
	[Obsolete("Use the constructor instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr Constant(double duration, NSAnimationCurve animationCurve)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_Double_UInt64(base.Handle, selInitWithDuration_AnimationCurve_Handle, duration, (ulong)animationCurve);
		}
		return Messaging.IntPtr_objc_msgSendSuper_Double_UInt64(base.SuperHandle, selInitWithDuration_AnimationCurve_Handle, duration, (ulong)animationCurve);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
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
		NSApplication.EnsureUIThread();
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

	[Export("isAnimating")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAnimating()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsAnimatingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAnimatingHandle);
	}

	[Export("removeProgressMark:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveProgressMark(float progressMark)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float(base.Handle, selRemoveProgressMark_Handle, progressMark);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selRemoveProgressMark_Handle, progressMark);
		}
	}

	[Export("startAnimation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartAnimation()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartAnimationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartAnimationHandle);
		}
	}

	[Export("startWhenAnimation:reachesProgress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartWhenAnimationReaches(NSAnimation animation, float startProgress)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_float(base.Handle, selStartWhenAnimation_ReachesProgress_Handle, animation.Handle, startProgress);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selStartWhenAnimation_ReachesProgress_Handle, animation.Handle, startProgress);
		}
	}

	[Export("stopAnimation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopAnimation()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopAnimationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopAnimationHandle);
		}
	}

	[Export("stopWhenAnimation:reachesProgress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopWhenAnimationReaches(NSAnimation animation, float stopProgress)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_float(base.Handle, selStopWhenAnimation_ReachesProgress_Handle, animation.Handle, stopProgress);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selStopWhenAnimation_ReachesProgress_Handle, animation.Handle, stopProgress);
		}
	}

	internal virtual _NSAnimationDelegate CreateInternalEventDelegateType()
	{
		return new _NSAnimationDelegate();
	}

	internal _NSAnimationDelegate EnsureNSAnimationDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSAnimationDelegate nSAnimationDelegate = Delegate as _NSAnimationDelegate;
		if (nSAnimationDelegate == null)
		{
			nSAnimationDelegate = (_NSAnimationDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSAnimationDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

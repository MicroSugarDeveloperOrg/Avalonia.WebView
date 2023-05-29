using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAnimation", true)]
public class NSAnimation : NSObject
{
	[Register]
	private sealed class _NSAnimationDelegate : NSAnimationDelegate
	{
		internal NSAnimationPredicate animationShouldStart;

		internal EventHandler animationDidStop;

		internal EventHandler animationDidEnd;

		internal NSAnimationProgress computeAnimationCurve;

		internal EventHandler<NSAnimationEventArgs> animationDidReachProgressMark;

		[Preserve(Conditional = true)]
		public override bool AnimationShouldStart(NSAnimation animation)
		{
			return animationShouldStart?.Invoke(animation) ?? true;
		}

		[Preserve(Conditional = true)]
		public override void AnimationDidStop(NSAnimation animation)
		{
			animationDidStop?.Invoke(animation, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void AnimationDidEnd(NSAnimation animation)
		{
			animationDidEnd?.Invoke(animation, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override double ComputeAnimationCurve(NSAnimation animation, double progress)
		{
			return computeAnimationCurve?.Invoke(animation, progress) ?? progress;
		}

		[Preserve(Conditional = true)]
		public override void AnimationDidReachProgressMark(NSAnimation animation, double progress)
		{
			EventHandler<NSAnimationEventArgs> eventHandler = animationDidReachProgressMark;
			if (eventHandler != null)
			{
				NSAnimationEventArgs e = new NSAnimationEventArgs(progress);
				eventHandler(animation, e);
			}
		}
	}

	public static class Notifications
	{
		public static NSObject ObserveProgressMark(EventHandler<NSAnimationProgressMarkEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(ProgressMarkNotification, delegate(NSNotification notification)
			{
				handler(null, new NSAnimationProgressMarkEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selCurrentProgressHandle = Selector.GetHandle("currentProgress");

	private static readonly IntPtr selSetCurrentProgress_Handle = Selector.GetHandle("setCurrentProgress:");

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selSetDuration_Handle = Selector.GetHandle("setDuration:");

	private static readonly IntPtr selAnimationBlockingModeHandle = Selector.GetHandle("animationBlockingMode");

	private static readonly IntPtr selSetAnimationBlockingMode_Handle = Selector.GetHandle("setAnimationBlockingMode:");

	private static readonly IntPtr selFrameRateHandle = Selector.GetHandle("frameRate");

	private static readonly IntPtr selSetFrameRate_Handle = Selector.GetHandle("setFrameRate:");

	private static readonly IntPtr selAnimationCurveHandle = Selector.GetHandle("animationCurve");

	private static readonly IntPtr selSetAnimationCurve_Handle = Selector.GetHandle("setAnimationCurve:");

	private static readonly IntPtr selCurrentValueHandle = Selector.GetHandle("currentValue");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selProgressMarksHandle = Selector.GetHandle("progressMarks");

	private static readonly IntPtr selSetProgressMarks_Handle = Selector.GetHandle("setProgressMarks:");

	private static readonly IntPtr selInitWithDurationAnimationCurve_Handle = Selector.GetHandle("initWithDuration:animationCurve:");

	private static readonly IntPtr selStartAnimationHandle = Selector.GetHandle("startAnimation");

	private static readonly IntPtr selStopAnimationHandle = Selector.GetHandle("stopAnimation");

	private static readonly IntPtr selIsAnimatingHandle = Selector.GetHandle("isAnimating");

	private static readonly IntPtr selAddProgressMark_Handle = Selector.GetHandle("addProgressMark:");

	private static readonly IntPtr selRemoveProgressMark_Handle = Selector.GetHandle("removeProgressMark:");

	private static readonly IntPtr selStartWhenAnimationReachesProgress_Handle = Selector.GetHandle("startWhenAnimation:reachesProgress:");

	private static readonly IntPtr selStopWhenAnimationReachesProgress_Handle = Selector.GetHandle("stopWhenAnimation:reachesProgress:");

	private static readonly IntPtr selClearStartAnimationHandle = Selector.GetHandle("clearStartAnimation");

	private static readonly IntPtr selClearStopAnimationHandle = Selector.GetHandle("clearStopAnimation");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSAnimation");

	private object __mt_Delegate_var;

	private object __mt_ProgressMarks_var;

	private static NSString _ProgressMarkNotification;

	private static NSString _ProgressMark;

	private static NSString _TriggerOrderIn;

	private static NSString _TriggerOrderOut;

	public override IntPtr ClassHandle => class_ptr;

	public virtual double CurrentProgress
	{
		[Export("currentProgress")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCurrentProgressHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCurrentProgressHandle);
		}
		[Export("setCurrentProgress:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCurrentProgress_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCurrentProgress_Handle, value);
			}
		}
	}

	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
		[Export("setDuration:")]
		set
		{
			NSApplication.EnsureUIThread();
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

	public virtual NSAnimationBlockingMode AnimationBlockingMode
	{
		[Export("animationBlockingMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSAnimationBlockingMode)Messaging.UInt64_objc_msgSend(base.Handle, selAnimationBlockingModeHandle);
			}
			return (NSAnimationBlockingMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAnimationBlockingModeHandle);
		}
		[Export("setAnimationBlockingMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAnimationBlockingMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAnimationBlockingMode_Handle, (ulong)value);
			}
		}
	}

	public virtual double FrameRate
	{
		[Export("frameRate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selFrameRateHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selFrameRateHandle);
		}
		[Export("setFrameRate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetFrameRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetFrameRate_Handle, value);
			}
		}
	}

	public virtual NSAnimationCurve AnimationCurve
	{
		[Export("animationCurve")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSAnimationCurve)Messaging.UInt64_objc_msgSend(base.Handle, selAnimationCurveHandle);
			}
			return (NSAnimationCurve)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAnimationCurveHandle);
		}
		[Export("setAnimationCurve:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAnimationCurve_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAnimationCurve_Handle, (ulong)value);
			}
		}
	}

	public virtual double CurrentValue
	{
		[Export("currentValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCurrentValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCurrentValueHandle);
		}
	}

	public virtual NSAnimationDelegate Delegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAnimationDelegate)(__mt_Delegate_var = ((!IsDirectBinding) ? ((NSAnimationDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle))) : ((NSAnimationDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value.Handle);
			}
			__mt_Delegate_var = value;
		}
	}

	public virtual NSNumber[] ProgressMarks
	{
		[Export("progressMarks")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSNumber[])(__mt_ProgressMarks_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProgressMarksHandle)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selProgressMarksHandle))));
		}
		[Export("setProgressMarks:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProgressMarks_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProgressMarks_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_ProgressMarks_var = value;
		}
	}

	[Field("NSAnimationProgressMarkNotification", "AppKit")]
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

	public NSAnimationPredicate AnimationShouldStart
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

	public NSAnimationProgress ComputeAnimationCurve
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAnimation()
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
	public NSAnimation(NSCoder coder)
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
	public NSAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDuration:animationCurve:")]
	public virtual IntPtr Constant(double duration, NSAnimationCurve animationCurve)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_Double_UInt64(base.Handle, selInitWithDurationAnimationCurve_Handle, duration, (ulong)animationCurve);
		}
		return Messaging.IntPtr_objc_msgSendSuper_Double_UInt64(base.SuperHandle, selInitWithDurationAnimationCurve_Handle, duration, (ulong)animationCurve);
	}

	[Export("startAnimation")]
	public virtual void StartAnimation()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartAnimationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartAnimationHandle);
		}
	}

	[Export("stopAnimation")]
	public virtual void StopAnimation()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopAnimationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopAnimationHandle);
		}
	}

	[Export("isAnimating")]
	public virtual bool IsAnimating()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsAnimatingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAnimatingHandle);
	}

	[Export("addProgressMark:")]
	public virtual void AddProgressMark(double progressMark)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selAddProgressMark_Handle, progressMark);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selAddProgressMark_Handle, progressMark);
		}
	}

	[Export("removeProgressMark:")]
	public virtual void RemoveProgressMark(double progressMark)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selRemoveProgressMark_Handle, progressMark);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selRemoveProgressMark_Handle, progressMark);
		}
	}

	[Export("startWhenAnimation:reachesProgress:")]
	public virtual void StartWhenAnimationReaches(NSAnimation animation, double startProgress)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Double(base.Handle, selStartWhenAnimationReachesProgress_Handle, animation.Handle, startProgress);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selStartWhenAnimationReachesProgress_Handle, animation.Handle, startProgress);
		}
	}

	[Export("stopWhenAnimation:reachesProgress:")]
	public virtual void StopWhenAnimationReaches(NSAnimation animation, double stopProgress)
	{
		NSApplication.EnsureUIThread();
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Double(base.Handle, selStopWhenAnimationReachesProgress_Handle, animation.Handle, stopProgress);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selStopWhenAnimationReachesProgress_Handle, animation.Handle, stopProgress);
		}
	}

	[Export("clearStartAnimation")]
	public virtual void ClearStartAnimation()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearStartAnimationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearStartAnimationHandle);
		}
	}

	[Export("clearStopAnimation")]
	public virtual void ClearStopAnimation()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearStopAnimationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearStopAnimationHandle);
		}
	}

	private _NSAnimationDelegate EnsureNSAnimationDelegate()
	{
		NSAnimationDelegate nSAnimationDelegate = Delegate;
		if (nSAnimationDelegate == null || !(nSAnimationDelegate is _NSAnimationDelegate))
		{
			nSAnimationDelegate = (Delegate = new _NSAnimationDelegate());
		}
		return (_NSAnimationDelegate)nSAnimationDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
			__mt_ProgressMarks_var = null;
		}
	}
}

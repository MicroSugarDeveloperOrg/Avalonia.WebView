using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSProgressIndicator", true)]
public class NSProgressIndicator : NSView
{
	private static readonly IntPtr selStyleHandle = Selector.GetHandle("style");

	private static readonly IntPtr selSetStyle_Handle = Selector.GetHandle("setStyle:");

	private static readonly IntPtr selIsDisplayedWhenStoppedHandle = Selector.GetHandle("isDisplayedWhenStopped");

	private static readonly IntPtr selSetDisplayedWhenStopped_Handle = Selector.GetHandle("setDisplayedWhenStopped:");

	private static readonly IntPtr selIsIndeterminateHandle = Selector.GetHandle("isIndeterminate");

	private static readonly IntPtr selSetIndeterminate_Handle = Selector.GetHandle("setIndeterminate:");

	private static readonly IntPtr selIsBezeledHandle = Selector.GetHandle("isBezeled");

	private static readonly IntPtr selSetBezeled_Handle = Selector.GetHandle("setBezeled:");

	private static readonly IntPtr selControlTintHandle = Selector.GetHandle("controlTint");

	private static readonly IntPtr selSetControlTint_Handle = Selector.GetHandle("setControlTint:");

	private static readonly IntPtr selControlSizeHandle = Selector.GetHandle("controlSize");

	private static readonly IntPtr selSetControlSize_Handle = Selector.GetHandle("setControlSize:");

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	private static readonly IntPtr selSetDoubleValue_Handle = Selector.GetHandle("setDoubleValue:");

	private static readonly IntPtr selMinValueHandle = Selector.GetHandle("minValue");

	private static readonly IntPtr selSetMinValue_Handle = Selector.GetHandle("setMinValue:");

	private static readonly IntPtr selMaxValueHandle = Selector.GetHandle("maxValue");

	private static readonly IntPtr selSetMaxValue_Handle = Selector.GetHandle("setMaxValue:");

	private static readonly IntPtr selUsesThreadedAnimationHandle = Selector.GetHandle("usesThreadedAnimation");

	private static readonly IntPtr selSetUsesThreadedAnimation_Handle = Selector.GetHandle("setUsesThreadedAnimation:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selIncrementBy_Handle = Selector.GetHandle("incrementBy:");

	private static readonly IntPtr selStartAnimation_Handle = Selector.GetHandle("startAnimation:");

	private static readonly IntPtr selStopAnimation_Handle = Selector.GetHandle("stopAnimation:");

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSProgressIndicator");

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSProgressIndicatorStyle Style
	{
		[Export("style")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSProgressIndicatorStyle)Messaging.UInt64_objc_msgSend(base.Handle, selStyleHandle);
			}
			return (NSProgressIndicatorStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStyleHandle);
		}
		[Export("setStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetStyle_Handle, (ulong)value);
			}
		}
	}

	public virtual bool IsDisplayedWhenStopped
	{
		[Export("isDisplayedWhenStopped")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDisplayedWhenStoppedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDisplayedWhenStoppedHandle);
		}
		[Export("setDisplayedWhenStopped:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplayedWhenStopped_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplayedWhenStopped_Handle, value);
			}
		}
	}

	public virtual bool Indeterminate
	{
		[Export("isIndeterminate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsIndeterminateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsIndeterminateHandle);
		}
		[Export("setIndeterminate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIndeterminate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIndeterminate_Handle, value);
			}
		}
	}

	public virtual bool Bezeled
	{
		[Export("isBezeled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBezeledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBezeledHandle);
		}
		[Export("setBezeled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBezeled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBezeled_Handle, value);
			}
		}
	}

	public virtual NSControlTint ControlTint
	{
		[Export("controlTint")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSControlTint)Messaging.UInt64_objc_msgSend(base.Handle, selControlTintHandle);
			}
			return (NSControlTint)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selControlTintHandle);
		}
		[Export("setControlTint:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlTint_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlTint_Handle, (ulong)value);
			}
		}
	}

	public virtual NSControlSize ControlSize
	{
		[Export("controlSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSControlSize)Messaging.UInt64_objc_msgSend(base.Handle, selControlSizeHandle);
			}
			return (NSControlSize)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selControlSizeHandle);
		}
		[Export("setControlSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlSize_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlSize_Handle, (ulong)value);
			}
		}
	}

	public virtual double DoubleValue
	{
		[Export("doubleValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDoubleValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDoubleValueHandle);
		}
		[Export("setDoubleValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDoubleValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDoubleValue_Handle, value);
			}
		}
	}

	public virtual double MinValue
	{
		[Export("minValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinValueHandle);
		}
		[Export("setMinValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMinValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMinValue_Handle, value);
			}
		}
	}

	public virtual double MaxValue
	{
		[Export("maxValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMaxValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMaxValueHandle);
		}
		[Export("setMaxValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMaxValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMaxValue_Handle, value);
			}
		}
	}

	public virtual bool UsesThreadedAnimation
	{
		[Export("usesThreadedAnimation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesThreadedAnimationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesThreadedAnimationHandle);
		}
		[Export("setUsesThreadedAnimation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesThreadedAnimation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesThreadedAnimation_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSProgressIndicator()
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
	public NSProgressIndicator(NSCoder coder)
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
	public NSProgressIndicator(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSProgressIndicator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSProgressIndicator(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	[Export("incrementBy:")]
	public virtual void IncrementBy(double delta)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selIncrementBy_Handle, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selIncrementBy_Handle, delta);
		}
	}

	[Export("startAnimation:")]
	public virtual void StartAnimation(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartAnimation_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartAnimation_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("stopAnimation:")]
	public virtual void StopAnimation(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStopAnimation_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStopAnimation_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("sizeToFit")]
	public virtual void SizeToFit()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToFitHandle);
		}
	}
}

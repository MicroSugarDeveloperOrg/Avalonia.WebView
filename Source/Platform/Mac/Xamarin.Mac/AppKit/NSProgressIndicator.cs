using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSProgressIndicator", true)]
public class NSProgressIndicator : NSView, INSAccessibilityElementProtocol, INativeObject, IDisposable, INSAccessibilityGroup, INSAccessibilityProgressIndicator
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrame = "accessibilityFrame";

	private static readonly IntPtr selAccessibilityFrameHandle = Selector.GetHandle("accessibilityFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIdentifier = "accessibilityIdentifier";

	private static readonly IntPtr selAccessibilityIdentifierHandle = Selector.GetHandle("accessibilityIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParent = "accessibilityParent";

	private static readonly IntPtr selAccessibilityParentHandle = Selector.GetHandle("accessibilityParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityValue = "accessibilityValue";

	private static readonly IntPtr selAccessibilityValueHandle = Selector.GetHandle("accessibilityValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlSize = "controlSize";

	private static readonly IntPtr selControlSizeHandle = Selector.GetHandle("controlSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlTint = "controlTint";

	private static readonly IntPtr selControlTintHandle = Selector.GetHandle("controlTint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleValue = "doubleValue";

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncrementBy_ = "incrementBy:";

	private static readonly IntPtr selIncrementBy_Handle = Selector.GetHandle("incrementBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFocused = "isAccessibilityFocused";

	private static readonly IntPtr selIsAccessibilityFocusedHandle = Selector.GetHandle("isAccessibilityFocused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBezeled = "isBezeled";

	private static readonly IntPtr selIsBezeledHandle = Selector.GetHandle("isBezeled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDisplayedWhenStopped = "isDisplayedWhenStopped";

	private static readonly IntPtr selIsDisplayedWhenStoppedHandle = Selector.GetHandle("isDisplayedWhenStopped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsIndeterminate = "isIndeterminate";

	private static readonly IntPtr selIsIndeterminateHandle = Selector.GetHandle("isIndeterminate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxValue = "maxValue";

	private static readonly IntPtr selMaxValueHandle = Selector.GetHandle("maxValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinValue = "minValue";

	private static readonly IntPtr selMinValueHandle = Selector.GetHandle("minValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBezeled_ = "setBezeled:";

	private static readonly IntPtr selSetBezeled_Handle = Selector.GetHandle("setBezeled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControlSize_ = "setControlSize:";

	private static readonly IntPtr selSetControlSize_Handle = Selector.GetHandle("setControlSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControlTint_ = "setControlTint:";

	private static readonly IntPtr selSetControlTint_Handle = Selector.GetHandle("setControlTint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplayedWhenStopped_ = "setDisplayedWhenStopped:";

	private static readonly IntPtr selSetDisplayedWhenStopped_Handle = Selector.GetHandle("setDisplayedWhenStopped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleValue_ = "setDoubleValue:";

	private static readonly IntPtr selSetDoubleValue_Handle = Selector.GetHandle("setDoubleValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndeterminate_ = "setIndeterminate:";

	private static readonly IntPtr selSetIndeterminate_Handle = Selector.GetHandle("setIndeterminate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxValue_ = "setMaxValue:";

	private static readonly IntPtr selSetMaxValue_Handle = Selector.GetHandle("setMaxValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinValue_ = "setMinValue:";

	private static readonly IntPtr selSetMinValue_Handle = Selector.GetHandle("setMinValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStyle_ = "setStyle:";

	private static readonly IntPtr selSetStyle_Handle = Selector.GetHandle("setStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesThreadedAnimation_ = "setUsesThreadedAnimation:";

	private static readonly IntPtr selSetUsesThreadedAnimation_Handle = Selector.GetHandle("setUsesThreadedAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeToFit = "sizeToFit";

	private static readonly IntPtr selSizeToFitHandle = Selector.GetHandle("sizeToFit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartAnimation_ = "startAnimation:";

	private static readonly IntPtr selStartAnimation_Handle = Selector.GetHandle("startAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopAnimation_ = "stopAnimation:";

	private static readonly IntPtr selStopAnimation_Handle = Selector.GetHandle("stopAnimation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStyle = "style";

	private static readonly IntPtr selStyleHandle = Selector.GetHandle("style");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesThreadedAnimation = "usesThreadedAnimation";

	private static readonly IntPtr selUsesThreadedAnimationHandle = Selector.GetHandle("usesThreadedAnimation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSProgressIndicator");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual bool AccessibilityFocused
	{
		[Export("isAccessibilityFocused")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessibilityFocusedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessibilityFocusedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual CGRect AccessibilityFrame
	{
		[Export("accessibilityFrame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selAccessibilityFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAccessibilityFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual string AccessibilityIdentifier
	{
		[Export("accessibilityIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSObject? AccessibilityParent
	{
		[Export("accessibilityParent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityParentHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityParentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public new virtual NSNumber? AccessibilityValue
	{
		[Export("accessibilityValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityValueHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Bezeled
	{
		[Export("isBezeled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBezeledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBezeledHandle);
		}
		[Export("setBezeled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBezeled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBezeled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSControlSize ControlSize
	{
		[Export("controlSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSControlSize)Messaging.UInt64_objc_msgSend(base.Handle, selControlSizeHandle);
			}
			return (NSControlSize)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selControlSizeHandle);
		}
		[Export("setControlSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlSize_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlSize_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSControlTint ControlTint
	{
		[Export("controlTint")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSControlTint)Messaging.UInt64_objc_msgSend(base.Handle, selControlTintHandle);
			}
			return (NSControlTint)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selControlTintHandle);
		}
		[Export("setControlTint:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetControlTint_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetControlTint_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DoubleValue
	{
		[Export("doubleValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDoubleValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDoubleValueHandle);
		}
		[Export("setDoubleValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetDoubleValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetDoubleValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Indeterminate
	{
		[Export("isIndeterminate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsIndeterminateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsIndeterminateHandle);
		}
		[Export("setIndeterminate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIndeterminate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIndeterminate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDisplayedWhenStopped
	{
		[Export("isDisplayedWhenStopped")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDisplayedWhenStoppedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDisplayedWhenStoppedHandle);
		}
		[Export("setDisplayedWhenStopped:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplayedWhenStopped_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplayedWhenStopped_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double MaxValue
	{
		[Export("maxValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMaxValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMaxValueHandle);
		}
		[Export("setMaxValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMaxValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMaxValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double MinValue
	{
		[Export("minValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinValueHandle);
		}
		[Export("setMinValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMinValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMinValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSProgressIndicatorStyle Style
	{
		[Export("style")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSProgressIndicatorStyle)Messaging.UInt64_objc_msgSend(base.Handle, selStyleHandle);
			}
			return (NSProgressIndicatorStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStyleHandle);
		}
		[Export("setStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesThreadedAnimation
	{
		[Export("usesThreadedAnimation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesThreadedAnimationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesThreadedAnimationHandle);
		}
		[Export("setUsesThreadedAnimation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesThreadedAnimation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesThreadedAnimation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSProgressIndicator()
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
	public NSProgressIndicator(NSCoder coder)
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
	protected NSProgressIndicator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSProgressIndicator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSProgressIndicator(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("incrementBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void IncrementBy(double delta)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selIncrementBy_Handle, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selIncrementBy_Handle, delta);
		}
	}

	[Export("sizeToFit")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SizeToFit()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSizeToFitHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSizeToFitHandle);
		}
	}

	[Export("startAnimation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartAnimation(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartAnimation_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartAnimation_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("stopAnimation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopAnimation(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStopAnimation_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStopAnimation_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}
}

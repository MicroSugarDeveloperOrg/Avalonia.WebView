using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSScroller", true)]
public class NSScroller : NSControl
{
	public new static class Notifications
	{
		public static NSObject ObservePreferredStyleChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(PreferredStyleChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObservePreferredStyleChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(PreferredStyleChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrowsPosition = "arrowsPosition";

	private static readonly IntPtr selArrowsPositionHandle = Selector.GetHandle("arrowsPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckSpaceForParts = "checkSpaceForParts";

	private static readonly IntPtr selCheckSpaceForPartsHandle = Selector.GetHandle("checkSpaceForParts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlSize = "controlSize";

	private static readonly IntPtr selControlSizeHandle = Selector.GetHandle("controlSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlTint = "controlTint";

	private static readonly IntPtr selControlTintHandle = Selector.GetHandle("controlTint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawArrow_Highlight_ = "drawArrow:highlight:";

	private static readonly IntPtr selDrawArrow_Highlight_Handle = Selector.GetHandle("drawArrow:highlight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawKnob = "drawKnob";

	private static readonly IntPtr selDrawKnobHandle = Selector.GetHandle("drawKnob");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawKnobSlotInRect_Highlight_ = "drawKnobSlotInRect:highlight:";

	private static readonly IntPtr selDrawKnobSlotInRect_Highlight_Handle = Selector.GetHandle("drawKnobSlotInRect:highlight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawParts = "drawParts";

	private static readonly IntPtr selDrawPartsHandle = Selector.GetHandle("drawParts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlight_ = "highlight:";

	private static readonly IntPtr selHighlight_Handle = Selector.GetHandle("highlight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHitPart = "hitPart";

	private static readonly IntPtr selHitPartHandle = Selector.GetHandle("hitPart");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCompatibleWithOverlayScrollers = "isCompatibleWithOverlayScrollers";

	private static readonly IntPtr selIsCompatibleWithOverlayScrollersHandle = Selector.GetHandle("isCompatibleWithOverlayScrollers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKnobProportion = "knobProportion";

	private static readonly IntPtr selKnobProportionHandle = Selector.GetHandle("knobProportion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKnobStyle = "knobStyle";

	private static readonly IntPtr selKnobStyleHandle = Selector.GetHandle("knobStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredScrollerStyle = "preferredScrollerStyle";

	private static readonly IntPtr selPreferredScrollerStyleHandle = Selector.GetHandle("preferredScrollerStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectForPart_ = "rectForPart:";

	private static readonly IntPtr selRectForPart_Handle = Selector.GetHandle("rectForPart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollerStyle = "scrollerStyle";

	private static readonly IntPtr selScrollerStyleHandle = Selector.GetHandle("scrollerStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollerWidth = "scrollerWidth";

	private static readonly IntPtr selScrollerWidthHandle = Selector.GetHandle("scrollerWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollerWidthForControlSize_ = "scrollerWidthForControlSize:";

	private static readonly IntPtr selScrollerWidthForControlSize_Handle = Selector.GetHandle("scrollerWidthForControlSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollerWidthForControlSize_ScrollerStyle_ = "scrollerWidthForControlSize:scrollerStyle:";

	private static readonly IntPtr selScrollerWidthForControlSize_ScrollerStyle_Handle = Selector.GetHandle("scrollerWidthForControlSize:scrollerStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArrowsPosition_ = "setArrowsPosition:";

	private static readonly IntPtr selSetArrowsPosition_Handle = Selector.GetHandle("setArrowsPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControlSize_ = "setControlSize:";

	private static readonly IntPtr selSetControlSize_Handle = Selector.GetHandle("setControlSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControlTint_ = "setControlTint:";

	private static readonly IntPtr selSetControlTint_Handle = Selector.GetHandle("setControlTint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKnobProportion_ = "setKnobProportion:";

	private static readonly IntPtr selSetKnobProportion_Handle = Selector.GetHandle("setKnobProportion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKnobStyle_ = "setKnobStyle:";

	private static readonly IntPtr selSetKnobStyle_Handle = Selector.GetHandle("setKnobStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollerStyle_ = "setScrollerStyle:";

	private static readonly IntPtr selSetScrollerStyle_Handle = Selector.GetHandle("setScrollerStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTestPart_ = "testPart:";

	private static readonly IntPtr selTestPart_Handle = Selector.GetHandle("testPart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackKnob_ = "trackKnob:";

	private static readonly IntPtr selTrackKnob_Handle = Selector.GetHandle("trackKnob:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackScrollButtons_ = "trackScrollButtons:";

	private static readonly IntPtr selTrackScrollButtons_Handle = Selector.GetHandle("trackScrollButtons:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsableParts = "usableParts";

	private static readonly IntPtr selUsablePartsHandle = Selector.GetHandle("usableParts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSScroller");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreferredStyleChangedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No effect since 10.7.")]
	public virtual NSScrollArrowPosition ArrowsPosition
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No effect since 10.7.")]
		[Export("arrowsPosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSScrollArrowPosition)Messaging.UInt64_objc_msgSend(base.Handle, selArrowsPositionHandle);
			}
			return (NSScrollArrowPosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selArrowsPositionHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No effect since 10.7.")]
		[Export("setArrowsPosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetArrowsPosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetArrowsPosition_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CompatibleWithOverlayScrollers
	{
		[Export("isCompatibleWithOverlayScrollers")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsCompatibleWithOverlayScrollersHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSControlSize ControlSize
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
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No effect since 10.7.")]
	public virtual NSControlTint ControlTint
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No effect since 10.7.")]
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
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No effect since 10.7.")]
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
	public virtual NSScrollerPart HitPart
	{
		[Export("hitPart")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSScrollerPart)Messaging.UInt64_objc_msgSend(base.Handle, selHitPartHandle);
			}
			return (NSScrollerPart)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selHitPartHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat KnobProportion
	{
		[Export("knobProportion")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selKnobProportionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selKnobProportionHandle);
		}
		[Export("setKnobProportion:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetKnobProportion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetKnobProportion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrollerKnobStyle KnobStyle
	{
		[Export("knobStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSScrollerKnobStyle)Messaging.Int64_objc_msgSend(base.Handle, selKnobStyleHandle);
			}
			return (NSScrollerKnobStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selKnobStyleHandle);
		}
		[Export("setKnobStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetKnobStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetKnobStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSScrollerStyle PreferredScrollerStyle
	{
		[Export("preferredScrollerStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSScrollerStyle)Messaging.Int64_objc_msgSend(class_ptr, selPreferredScrollerStyleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrollerStyle ScrollerStyle
	{
		[Export("scrollerStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSScrollerStyle)Messaging.Int64_objc_msgSend(base.Handle, selScrollerStyleHandle);
			}
			return (NSScrollerStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selScrollerStyleHandle);
		}
		[Export("setScrollerStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetScrollerStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetScrollerStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, "Use GetScrollerWidth instead.")]
	public static nfloat ScrollerWidth
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, "Use GetScrollerWidth instead.")]
		[Export("scrollerWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nfloat_objc_msgSend(class_ptr, selScrollerWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUsableScrollerParts UsableParts
	{
		[Export("usableParts")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSUsableScrollerParts)Messaging.UInt64_objc_msgSend(base.Handle, selUsablePartsHandle);
			}
			return (NSUsableScrollerParts)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUsablePartsHandle);
		}
	}

	[Field("NSPreferredScrollerStyleDidChangeNotification", "AppKit")]
	[Advice("Use NSScroller.Notifications.ObservePreferredStyleChanged helper method instead.")]
	public static NSString PreferredStyleChangedNotification
	{
		get
		{
			if (_PreferredStyleChangedNotification == null)
			{
				_PreferredStyleChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPreferredScrollerStyleDidChangeNotification");
			}
			return _PreferredStyleChangedNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSScroller()
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
	public NSScroller(NSCoder coder)
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
	protected NSScroller(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSScroller(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSScroller(CGRect frameRect)
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

	[Export("checkSpaceForParts")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CheckSpaceForParts()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCheckSpaceForPartsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCheckSpaceForPartsHandle);
		}
	}

	[Export("drawArrow:highlight:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, "Scrollers don't have arrows anymore.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawArrow(NSScrollerArrow whichArrow, bool highlight)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_bool(base.Handle, selDrawArrow_Highlight_Handle, (ulong)whichArrow, highlight);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_bool(base.SuperHandle, selDrawArrow_Highlight_Handle, (ulong)whichArrow, highlight);
		}
	}

	[Export("drawKnob")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawKnob()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDrawKnobHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDrawKnobHandle);
		}
	}

	[Export("drawKnobSlotInRect:highlight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawKnobSlot(CGRect slotRect, bool highlight)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_bool(base.Handle, selDrawKnobSlotInRect_Highlight_Handle, slotRect, highlight);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_bool(base.SuperHandle, selDrawKnobSlotInRect_Highlight_Handle, slotRect, highlight);
		}
	}

	[Export("drawParts")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, "Not used.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawParts()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDrawPartsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDrawPartsHandle);
		}
	}

	[Export("scrollerWidthForControlSize:scrollerStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat GetScrollerWidth(NSControlSize forControlSize, NSScrollerStyle scrollerStyle)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nfloat_objc_msgSend_UInt64_Int64(class_ptr, selScrollerWidthForControlSize_ScrollerStyle_Handle, (ulong)forControlSize, (long)scrollerStyle);
	}

	[Export("highlight:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No effect since 10.7.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Highlight(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selHighlight_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selHighlight_Handle, flag);
		}
	}

	[Export("rectForPart:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect RectForPart(NSScrollerPart partCode)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_UInt64(out retval, base.Handle, selRectForPart_Handle, (ulong)partCode);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_UInt64(out retval, base.SuperHandle, selRectForPart_Handle, (ulong)partCode);
		}
		return retval;
	}

	[Export("scrollerWidthForControlSize:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, "Use GetScrollerWidth instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat ScrollerWidthForControlSize(NSControlSize controlSize)
	{
		NSApplication.EnsureUIThread();
		return Messaging.nfloat_objc_msgSend_UInt64(class_ptr, selScrollerWidthForControlSize_Handle, (ulong)controlSize);
	}

	[Export("testPart:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrollerPart TestPart(CGPoint thePoint)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSScrollerPart)Messaging.UInt64_objc_msgSend_CGPoint(base.Handle, selTestPart_Handle, thePoint);
		}
		return (NSScrollerPart)Messaging.UInt64_objc_msgSendSuper_CGPoint(base.SuperHandle, selTestPart_Handle, thePoint);
	}

	[Export("trackKnob:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TrackKnob(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTrackKnob_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTrackKnob_Handle, theEvent.Handle);
		}
	}

	[Export("trackScrollButtons:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No effect since 10.7.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TrackScrollButtons(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTrackScrollButtons_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTrackScrollButtons_Handle, theEvent.Handle);
		}
	}
}

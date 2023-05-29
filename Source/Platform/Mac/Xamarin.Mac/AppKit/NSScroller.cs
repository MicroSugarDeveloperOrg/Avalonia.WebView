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
			return NSNotificationCenter.DefaultCenter.AddObserver(PreferredStyleChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selScrollerWidthHandle = Selector.GetHandle("scrollerWidth");

	private static readonly IntPtr selUsablePartsHandle = Selector.GetHandle("usableParts");

	private static readonly IntPtr selHitPartHandle = Selector.GetHandle("hitPart");

	private static readonly IntPtr selArrowsPositionHandle = Selector.GetHandle("arrowsPosition");

	private static readonly IntPtr selSetArrowsPosition_Handle = Selector.GetHandle("setArrowsPosition:");

	private static readonly IntPtr selControlTintHandle = Selector.GetHandle("controlTint");

	private static readonly IntPtr selSetControlTint_Handle = Selector.GetHandle("setControlTint:");

	private static readonly IntPtr selControlSizeHandle = Selector.GetHandle("controlSize");

	private static readonly IntPtr selSetControlSize_Handle = Selector.GetHandle("setControlSize:");

	private static readonly IntPtr selKnobProportionHandle = Selector.GetHandle("knobProportion");

	private static readonly IntPtr selSetKnobProportion_Handle = Selector.GetHandle("setKnobProportion:");

	private static readonly IntPtr selIsCompatibleWithOverlayScrollersHandle = Selector.GetHandle("isCompatibleWithOverlayScrollers");

	private static readonly IntPtr selKnobStyleHandle = Selector.GetHandle("knobStyle");

	private static readonly IntPtr selSetKnobStyle_Handle = Selector.GetHandle("setKnobStyle:");

	private static readonly IntPtr selPreferredScrollerStyleHandle = Selector.GetHandle("preferredScrollerStyle");

	private static readonly IntPtr selScrollerStyleHandle = Selector.GetHandle("scrollerStyle");

	private static readonly IntPtr selSetScrollerStyle_Handle = Selector.GetHandle("setScrollerStyle:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selScrollerWidthForControlSize_Handle = Selector.GetHandle("scrollerWidthForControlSize:");

	private static readonly IntPtr selDrawPartsHandle = Selector.GetHandle("drawParts");

	private static readonly IntPtr selRectForPart_Handle = Selector.GetHandle("rectForPart:");

	private static readonly IntPtr selCheckSpaceForPartsHandle = Selector.GetHandle("checkSpaceForParts");

	private static readonly IntPtr selDrawArrowHighlight_Handle = Selector.GetHandle("drawArrow:highlight:");

	private static readonly IntPtr selDrawKnobHandle = Selector.GetHandle("drawKnob");

	private static readonly IntPtr selDrawKnobSlotInRectHighlight_Handle = Selector.GetHandle("drawKnobSlotInRect:highlight:");

	private static readonly IntPtr selHighlight_Handle = Selector.GetHandle("highlight:");

	private static readonly IntPtr selTestPart_Handle = Selector.GetHandle("testPart:");

	private static readonly IntPtr selTrackKnob_Handle = Selector.GetHandle("trackKnob:");

	private static readonly IntPtr selTrackScrollButtons_Handle = Selector.GetHandle("trackScrollButtons:");

	private static readonly IntPtr selScrollerWidthForControlSizeScrollerStyle_Handle = Selector.GetHandle("scrollerWidthForControlSize:scrollerStyle:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSScroller");

	private static NSString _PreferredStyleChangedNotification;

	public override IntPtr ClassHandle => class_ptr;

	public static double ScrollerWidth
	{
		[Export("scrollerWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selScrollerWidthHandle);
		}
	}

	public virtual NSUsableScrollerParts UsableParts
	{
		[Export("usableParts")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSUsableScrollerParts)Messaging.UInt64_objc_msgSend(base.Handle, selUsablePartsHandle);
			}
			return (NSUsableScrollerParts)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUsablePartsHandle);
		}
	}

	public virtual NSScrollerPart HitPart
	{
		[Export("hitPart")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSScrollerPart)Messaging.UInt64_objc_msgSend(base.Handle, selHitPartHandle);
			}
			return (NSScrollerPart)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selHitPartHandle);
		}
	}

	public virtual NSScrollArrowPosition ArrowsPosition
	{
		[Export("arrowsPosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSScrollArrowPosition)Messaging.UInt64_objc_msgSend(base.Handle, selArrowsPositionHandle);
			}
			return (NSScrollArrowPosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selArrowsPositionHandle);
		}
		[Export("setArrowsPosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetArrowsPosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetArrowsPosition_Handle, (ulong)value);
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

	public virtual double KnobProportion
	{
		[Export("knobProportion")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selKnobProportionHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selKnobProportionHandle);
		}
		[Export("setKnobProportion:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetKnobProportion_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetKnobProportion_Handle, value);
			}
		}
	}

	public static bool CompatibleWithOverlayScrollers
	{
		[Export("isCompatibleWithOverlayScrollers")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsCompatibleWithOverlayScrollersHandle);
		}
	}

	public virtual NSScrollerKnobStyle KnobStyle
	{
		[Export("knobStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSScrollerKnobStyle)Messaging.Int64_objc_msgSend(base.Handle, selKnobStyleHandle);
			}
			return (NSScrollerKnobStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selKnobStyleHandle);
		}
		[Export("setKnobStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetKnobStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetKnobStyle_Handle, (long)value);
			}
		}
	}

	public static NSScrollerStyle PreferredScrollerStyle
	{
		[Export("preferredScrollerStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSScrollerStyle)Messaging.Int64_objc_msgSend(class_ptr, selPreferredScrollerStyleHandle);
		}
	}

	public virtual NSScrollerStyle ScrollerStyle
	{
		[Export("scrollerStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSScrollerStyle)Messaging.Int64_objc_msgSend(base.Handle, selScrollerStyleHandle);
			}
			return (NSScrollerStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selScrollerStyleHandle);
		}
		[Export("setScrollerStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetScrollerStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetScrollerStyle_Handle, (long)value);
			}
		}
	}

	[Field("NSPreferredScrollerStyleDidChangeNotification", "AppKit")]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSScroller()
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
	public NSScroller(NSCoder coder)
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
	public NSScroller(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSScroller(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSScroller(CGRect frameRect)
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

	[Export("scrollerWidthForControlSize:")]
	public static double ScrollerWidthForControlSize(NSControlSize controlSize)
	{
		NSApplication.EnsureUIThread();
		return Messaging.Double_objc_msgSend_UInt64(class_ptr, selScrollerWidthForControlSize_Handle, (ulong)controlSize);
	}

	[Export("drawParts")]
	[Obsolete("", false)]
	public virtual void DrawParts()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDrawPartsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDrawPartsHandle);
		}
	}

	[Export("rectForPart:")]
	public virtual CGRect RectForPart(NSScrollerPart partCode)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_UInt64(out retval, base.Handle, selRectForPart_Handle, (ulong)partCode);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_UInt64(out retval, base.SuperHandle, selRectForPart_Handle, (ulong)partCode);
		}
		return retval;
	}

	[Export("checkSpaceForParts")]
	public virtual void CheckSpaceForParts()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCheckSpaceForPartsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCheckSpaceForPartsHandle);
		}
	}

	[Export("drawArrow:highlight:")]
	public virtual void DrawArrow(NSScrollerArrow whichArrow, bool highlight)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_bool(base.Handle, selDrawArrowHighlight_Handle, (ulong)whichArrow, highlight);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_bool(base.SuperHandle, selDrawArrowHighlight_Handle, (ulong)whichArrow, highlight);
		}
	}

	[Export("drawKnob")]
	public virtual void DrawKnob()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDrawKnobHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDrawKnobHandle);
		}
	}

	[Export("drawKnobSlotInRect:highlight:")]
	public virtual void DrawKnobSlot(CGRect slotRect, bool highlight)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_bool(base.Handle, selDrawKnobSlotInRectHighlight_Handle, slotRect, highlight);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_bool(base.SuperHandle, selDrawKnobSlotInRectHighlight_Handle, slotRect, highlight);
		}
	}

	[Export("highlight:")]
	public virtual void Highlight(bool flag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selHighlight_Handle, flag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selHighlight_Handle, flag);
		}
	}

	[Export("testPart:")]
	public virtual NSScrollerPart TestPart(CGPoint thePoint)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSScrollerPart)Messaging.UInt64_objc_msgSend_CGPoint(base.Handle, selTestPart_Handle, thePoint);
		}
		return (NSScrollerPart)Messaging.UInt64_objc_msgSendSuper_CGPoint(base.SuperHandle, selTestPart_Handle, thePoint);
	}

	[Export("trackKnob:")]
	public virtual void TrackKnob(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTrackKnob_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTrackKnob_Handle, theEvent.Handle);
		}
	}

	[Export("trackScrollButtons:")]
	public virtual void TrackScrollButtons(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTrackScrollButtons_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTrackScrollButtons_Handle, theEvent.Handle);
		}
	}

	[Export("scrollerWidthForControlSize:scrollerStyle:")]
	public static double GetScrollerWidth(NSControlSize forControlSize, NSScrollerStyle scrollerStyle)
	{
		NSApplication.EnsureUIThread();
		return Messaging.Double_objc_msgSend_UInt64_Int64(class_ptr, selScrollerWidthForControlSizeScrollerStyle_Handle, (ulong)forControlSize, (long)scrollerStyle);
	}
}

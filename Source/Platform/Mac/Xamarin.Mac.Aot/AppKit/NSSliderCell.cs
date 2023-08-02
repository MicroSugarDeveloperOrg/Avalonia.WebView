using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSliderCell", true)]
public class NSSliderCell : NSActionCell
{
	private static readonly IntPtr selIsVerticalHandle = Selector.GetHandle("isVertical");

	private static readonly IntPtr selTrackRectHandle = Selector.GetHandle("trackRect");

	private static readonly IntPtr selMinValueHandle = Selector.GetHandle("minValue");

	private static readonly IntPtr selSetMinValue_Handle = Selector.GetHandle("setMinValue:");

	private static readonly IntPtr selMaxValueHandle = Selector.GetHandle("maxValue");

	private static readonly IntPtr selSetMaxValue_Handle = Selector.GetHandle("setMaxValue:");

	private static readonly IntPtr selAltIncrementValueHandle = Selector.GetHandle("altIncrementValue");

	private static readonly IntPtr selSetAltIncrementValue_Handle = Selector.GetHandle("setAltIncrementValue:");

	private static readonly IntPtr selTitleColorHandle = Selector.GetHandle("titleColor");

	private static readonly IntPtr selSetTitleColor_Handle = Selector.GetHandle("setTitleColor:");

	private static readonly IntPtr selTitleFontHandle = Selector.GetHandle("titleFont");

	private static readonly IntPtr selSetTitleFont_Handle = Selector.GetHandle("setTitleFont:");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selTitleCellHandle = Selector.GetHandle("titleCell");

	private static readonly IntPtr selSetTitleCell_Handle = Selector.GetHandle("setTitleCell:");

	private static readonly IntPtr selKnobThicknessHandle = Selector.GetHandle("knobThickness");

	private static readonly IntPtr selSetKnobThickness_Handle = Selector.GetHandle("setKnobThickness:");

	private static readonly IntPtr selSliderTypeHandle = Selector.GetHandle("sliderType");

	private static readonly IntPtr selSetSliderType_Handle = Selector.GetHandle("setSliderType:");

	private static readonly IntPtr selNumberOfTickMarksHandle = Selector.GetHandle("numberOfTickMarks");

	private static readonly IntPtr selSetNumberOfTickMarks_Handle = Selector.GetHandle("setNumberOfTickMarks:");

	private static readonly IntPtr selTickMarkPositionHandle = Selector.GetHandle("tickMarkPosition");

	private static readonly IntPtr selSetTickMarkPosition_Handle = Selector.GetHandle("setTickMarkPosition:");

	private static readonly IntPtr selAllowsTickMarkValuesOnlyHandle = Selector.GetHandle("allowsTickMarkValuesOnly");

	private static readonly IntPtr selSetAllowsTickMarkValuesOnly_Handle = Selector.GetHandle("setAllowsTickMarkValuesOnly:");

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	private static readonly IntPtr selPrefersTrackingUntilMouseUpHandle = Selector.GetHandle("prefersTrackingUntilMouseUp");

	private static readonly IntPtr selKnobRectFlipped_Handle = Selector.GetHandle("knobRectFlipped:");

	private static readonly IntPtr selDrawKnob_Handle = Selector.GetHandle("drawKnob:");

	private static readonly IntPtr selDrawKnobHandle = Selector.GetHandle("drawKnob");

	private static readonly IntPtr selDrawBarInsideFlipped_Handle = Selector.GetHandle("drawBarInside:flipped:");

	private static readonly IntPtr selTickMarkValueAtIndex_Handle = Selector.GetHandle("tickMarkValueAtIndex:");

	private static readonly IntPtr selRectOfTickMarkAtIndex_Handle = Selector.GetHandle("rectOfTickMarkAtIndex:");

	private static readonly IntPtr selIndexOfTickMarkAtPoint_Handle = Selector.GetHandle("indexOfTickMarkAtPoint:");

	private static readonly IntPtr selClosestTickMarkValueToValue_Handle = Selector.GetHandle("closestTickMarkValueToValue:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSliderCell");

	private object __mt_TitleColor_var;

	private object __mt_TitleFont_var;

	private object __mt_TitleCell_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual int IsVertical
	{
		[Export("isVertical")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selIsVerticalHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selIsVerticalHandle);
		}
	}

	public virtual CGRect TrackRect
	{
		[Export("trackRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selTrackRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTrackRectHandle);
			}
			return retval;
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

	public virtual double AltIncrementValue
	{
		[Export("altIncrementValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAltIncrementValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAltIncrementValueHandle);
		}
		[Export("setAltIncrementValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAltIncrementValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAltIncrementValue_Handle, value);
			}
		}
	}

	public virtual NSColor TitleColor
	{
		[Export("titleColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_TitleColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleColorHandle)))));
		}
		[Export("setTitleColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleColor_Handle, value.Handle);
			}
			__mt_TitleColor_var = value;
		}
	}

	public virtual NSFont TitleFont
	{
		[Export("titleFont")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFont)(__mt_TitleFont_var = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleFontHandle))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleFontHandle)))));
		}
		[Export("setTitleFont:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleFont_Handle, value.Handle);
			}
			__mt_TitleFont_var = value;
		}
	}

	public new virtual string Title
	{
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSObject TitleCell
	{
		[Export("titleCell")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_TitleCell_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleCellHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleCellHandle))));
		}
		[Export("setTitleCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleCell_Handle, value.Handle);
			}
			__mt_TitleCell_var = value;
		}
	}

	public virtual double KnobThickness
	{
		[Export("knobThickness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selKnobThicknessHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selKnobThicknessHandle);
		}
		[Export("setKnobThickness:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetKnobThickness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetKnobThickness_Handle, value);
			}
		}
	}

	public virtual NSSliderType SliderType
	{
		[Export("sliderType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSSliderType)Messaging.UInt64_objc_msgSend(base.Handle, selSliderTypeHandle);
			}
			return (NSSliderType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSliderTypeHandle);
		}
		[Export("setSliderType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSliderType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSliderType_Handle, (ulong)value);
			}
		}
	}

	public virtual long TickMarks
	{
		[Export("numberOfTickMarks")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfTickMarksHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfTickMarksHandle);
		}
		[Export("setNumberOfTickMarks:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetNumberOfTickMarks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetNumberOfTickMarks_Handle, value);
			}
		}
	}

	public virtual NSTickMarkPosition TickMarkPosition
	{
		[Export("tickMarkPosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTickMarkPosition)Messaging.UInt64_objc_msgSend(base.Handle, selTickMarkPositionHandle);
			}
			return (NSTickMarkPosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTickMarkPositionHandle);
		}
		[Export("setTickMarkPosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTickMarkPosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTickMarkPosition_Handle, (ulong)value);
			}
		}
	}

	public virtual bool AllowsTickMarkValuesOnly
	{
		[Export("allowsTickMarkValuesOnly")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsTickMarkValuesOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsTickMarkValuesOnlyHandle);
		}
		[Export("setAllowsTickMarkValuesOnly:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsTickMarkValuesOnly_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsTickMarkValuesOnly_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSliderCell()
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
	public NSSliderCell(NSCoder coder)
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
	public NSSliderCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSliderCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	public NSSliderCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	public NSSliderCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle);
		}
	}

	[Export("prefersTrackingUntilMouseUp")]
	public new static bool PrefersTrackingUntilMouseUp()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(class_ptr, selPrefersTrackingUntilMouseUpHandle);
	}

	[Export("knobRectFlipped:")]
	public virtual CGRect KnobRectFlipped(bool flipped)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_bool(out retval, base.Handle, selKnobRectFlipped_Handle, flipped);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_bool(out retval, base.SuperHandle, selKnobRectFlipped_Handle, flipped);
		}
		return retval;
	}

	[Export("drawKnob:")]
	public virtual void DrawKnob(CGRect knobRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawKnob_Handle, knobRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawKnob_Handle, knobRect);
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

	[Export("drawBarInside:flipped:")]
	public virtual void DrawBar(CGRect aRect, bool flipped)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_bool(base.Handle, selDrawBarInsideFlipped_Handle, aRect, flipped);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_bool(base.SuperHandle, selDrawBarInsideFlipped_Handle, aRect, flipped);
		}
	}

	[Export("tickMarkValueAtIndex:")]
	public virtual double TickMarkValue(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Int64(base.Handle, selTickMarkValueAtIndex_Handle, index);
		}
		return Messaging.Double_objc_msgSendSuper_Int64(base.SuperHandle, selTickMarkValueAtIndex_Handle, index);
	}

	[Export("rectOfTickMarkAtIndex:")]
	public virtual CGRect RectOfTickMark(long index)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selRectOfTickMarkAtIndex_Handle, index);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selRectOfTickMarkAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("indexOfTickMarkAtPoint:")]
	public virtual long IndexOfTickMark(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_CGPoint(base.Handle, selIndexOfTickMarkAtPoint_Handle, point);
		}
		return Messaging.Int64_objc_msgSendSuper_CGPoint(base.SuperHandle, selIndexOfTickMarkAtPoint_Handle, point);
	}

	[Export("closestTickMarkValueToValue:")]
	public virtual double ClosestTickMarkValue(double value)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double(base.Handle, selClosestTickMarkValueToValue_Handle, value);
		}
		return Messaging.Double_objc_msgSendSuper_Double(base.SuperHandle, selClosestTickMarkValueToValue_Handle, value);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TitleColor_var = null;
			__mt_TitleFont_var = null;
			__mt_TitleCell_var = null;
		}
	}
}

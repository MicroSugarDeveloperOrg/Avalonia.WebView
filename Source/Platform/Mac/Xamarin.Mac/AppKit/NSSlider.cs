using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSlider", true)]
public class NSSlider : NSControl, INSAccessibilityElementProtocol, INativeObject, IDisposable, INSAccessibilitySlider
{
	private NSActionDispatcher dispatcher;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsFirstMouse_ = "acceptsFirstMouse:";

	private static readonly IntPtr selAcceptsFirstMouse_Handle = Selector.GetHandle("acceptsFirstMouse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityFrame = "accessibilityFrame";

	private static readonly IntPtr selAccessibilityFrameHandle = Selector.GetHandle("accessibilityFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityIdentifier = "accessibilityIdentifier";

	private static readonly IntPtr selAccessibilityIdentifierHandle = Selector.GetHandle("accessibilityIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityLabel = "accessibilityLabel";

	private static readonly IntPtr selAccessibilityLabelHandle = Selector.GetHandle("accessibilityLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityParent = "accessibilityParent";

	private static readonly IntPtr selAccessibilityParentHandle = Selector.GetHandle("accessibilityParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformDecrement = "accessibilityPerformDecrement";

	private static readonly IntPtr selAccessibilityPerformDecrementHandle = Selector.GetHandle("accessibilityPerformDecrement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityPerformIncrement = "accessibilityPerformIncrement";

	private static readonly IntPtr selAccessibilityPerformIncrementHandle = Selector.GetHandle("accessibilityPerformIncrement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityValue = "accessibilityValue";

	private static readonly IntPtr selAccessibilityValueHandle = Selector.GetHandle("accessibilityValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsTickMarkValuesOnly = "allowsTickMarkValuesOnly";

	private static readonly IntPtr selAllowsTickMarkValuesOnlyHandle = Selector.GetHandle("allowsTickMarkValuesOnly");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAltIncrementValue = "altIncrementValue";

	private static readonly IntPtr selAltIncrementValueHandle = Selector.GetHandle("altIncrementValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClosestTickMarkValueToValue_ = "closestTickMarkValueToValue:";

	private static readonly IntPtr selClosestTickMarkValueToValue_Handle = Selector.GetHandle("closestTickMarkValueToValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImage = "image";

	private static readonly IntPtr selImageHandle = Selector.GetHandle("image");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfTickMarkAtPoint_ = "indexOfTickMarkAtPoint:";

	private static readonly IntPtr selIndexOfTickMarkAtPoint_Handle = Selector.GetHandle("indexOfTickMarkAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessibilityFocused = "isAccessibilityFocused";

	private static readonly IntPtr selIsAccessibilityFocusedHandle = Selector.GetHandle("isAccessibilityFocused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVertical = "isVertical";

	private static readonly IntPtr selIsVerticalHandle = Selector.GetHandle("isVertical");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKnobThickness = "knobThickness";

	private static readonly IntPtr selKnobThicknessHandle = Selector.GetHandle("knobThickness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxValue = "maxValue";

	private static readonly IntPtr selMaxValueHandle = Selector.GetHandle("maxValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinValue = "minValue";

	private static readonly IntPtr selMinValueHandle = Selector.GetHandle("minValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfTickMarks = "numberOfTickMarks";

	private static readonly IntPtr selNumberOfTickMarksHandle = Selector.GetHandle("numberOfTickMarks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectOfTickMarkAtIndex_ = "rectOfTickMarkAtIndex:";

	private static readonly IntPtr selRectOfTickMarkAtIndex_Handle = Selector.GetHandle("rectOfTickMarkAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsTickMarkValuesOnly_ = "setAllowsTickMarkValuesOnly:";

	private static readonly IntPtr selSetAllowsTickMarkValuesOnly_Handle = Selector.GetHandle("setAllowsTickMarkValuesOnly:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAltIncrementValue_ = "setAltIncrementValue:";

	private static readonly IntPtr selSetAltIncrementValue_Handle = Selector.GetHandle("setAltIncrementValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImage_ = "setImage:";

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKnobThickness_ = "setKnobThickness:";

	private static readonly IntPtr selSetKnobThickness_Handle = Selector.GetHandle("setKnobThickness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxValue_ = "setMaxValue:";

	private static readonly IntPtr selSetMaxValue_Handle = Selector.GetHandle("setMaxValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinValue_ = "setMinValue:";

	private static readonly IntPtr selSetMinValue_Handle = Selector.GetHandle("setMinValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfTickMarks_ = "setNumberOfTickMarks:";

	private static readonly IntPtr selSetNumberOfTickMarks_Handle = Selector.GetHandle("setNumberOfTickMarks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSliderType_ = "setSliderType:";

	private static readonly IntPtr selSetSliderType_Handle = Selector.GetHandle("setSliderType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTickMarkPosition_ = "setTickMarkPosition:";

	private static readonly IntPtr selSetTickMarkPosition_Handle = Selector.GetHandle("setTickMarkPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitleCell_ = "setTitleCell:";

	private static readonly IntPtr selSetTitleCell_Handle = Selector.GetHandle("setTitleCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitleColor_ = "setTitleColor:";

	private static readonly IntPtr selSetTitleColor_Handle = Selector.GetHandle("setTitleColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitleFont_ = "setTitleFont:";

	private static readonly IntPtr selSetTitleFont_Handle = Selector.GetHandle("setTitleFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTrackFillColor_ = "setTrackFillColor:";

	private static readonly IntPtr selSetTrackFillColor_Handle = Selector.GetHandle("setTrackFillColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVertical_ = "setVertical:";

	private static readonly IntPtr selSetVertical_Handle = Selector.GetHandle("setVertical:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSliderType = "sliderType";

	private static readonly IntPtr selSliderTypeHandle = Selector.GetHandle("sliderType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSliderWithTarget_Action_ = "sliderWithTarget:action:";

	private static readonly IntPtr selSliderWithTarget_Action_Handle = Selector.GetHandle("sliderWithTarget:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSliderWithValue_MinValue_MaxValue_Target_Action_ = "sliderWithValue:minValue:maxValue:target:action:";

	private static readonly IntPtr selSliderWithValue_MinValue_MaxValue_Target_Action_Handle = Selector.GetHandle("sliderWithValue:minValue:maxValue:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTickMarkPosition = "tickMarkPosition";

	private static readonly IntPtr selTickMarkPositionHandle = Selector.GetHandle("tickMarkPosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTickMarkValueAtIndex_ = "tickMarkValueAtIndex:";

	private static readonly IntPtr selTickMarkValueAtIndex_Handle = Selector.GetHandle("tickMarkValueAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleCell = "titleCell";

	private static readonly IntPtr selTitleCellHandle = Selector.GetHandle("titleCell");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleColor = "titleColor";

	private static readonly IntPtr selTitleColorHandle = Selector.GetHandle("titleColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleFont = "titleFont";

	private static readonly IntPtr selTitleFontHandle = Selector.GetHandle("titleFont");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackFillColor = "trackFillColor";

	private static readonly IntPtr selTrackFillColorHandle = Selector.GetHandle("trackFillColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSlider");

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
	public new virtual string? AccessibilityLabel
	{
		[Export("accessibilityLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityLabelHandle));
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
	public new virtual NSObject? AccessibilityValue
	{
		[Export("accessibilityValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsTickMarkValuesOnly
	{
		[Export("allowsTickMarkValuesOnly")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsTickMarkValuesOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsTickMarkValuesOnlyHandle);
		}
		[Export("setAllowsTickMarkValuesOnly:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsTickMarkValuesOnly_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsTickMarkValuesOnly_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double AltIncrementValue
	{
		[Export("altIncrementValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAltIncrementValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAltIncrementValueHandle);
		}
		[Export("setAltIncrementValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAltIncrementValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAltIncrementValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	public virtual NSImage Image
	{
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("image")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("setImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IsVertical
	{
		[Export("isVertical")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selIsVerticalHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selIsVerticalHandle);
		}
		[Export("setVertical:")]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetVertical_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetVertical_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	public virtual nfloat KnobThickness
	{
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("knobThickness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selKnobThicknessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selKnobThicknessHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("setKnobThickness:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetKnobThickness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetKnobThickness_Handle, value);
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSSliderType SliderType
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("sliderType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSSliderType)Messaging.UInt64_objc_msgSend(base.Handle, selSliderTypeHandle);
			}
			return (NSSliderType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSliderTypeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setSliderType:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSliderType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSliderType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTickMarkPosition TickMarkPosition
	{
		[Export("tickMarkPosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTickMarkPosition)Messaging.UInt64_objc_msgSend(base.Handle, selTickMarkPositionHandle);
			}
			return (NSTickMarkPosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTickMarkPositionHandle);
		}
		[Export("setTickMarkPosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTickMarkPosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTickMarkPosition_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint TickMarksCount
	{
		[Export("numberOfTickMarks")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfTickMarksHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfTickMarksHandle);
		}
		[Export("setNumberOfTickMarks:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetNumberOfTickMarks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetNumberOfTickMarks_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	public virtual string Title
	{
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("setTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	public virtual NSObject TitleCell
	{
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("titleCell")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleCellHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleCellHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("setTitleCell:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleCell_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleCell_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	public virtual NSColor TitleColor
	{
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("titleColor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleColorHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("setTitleColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	public virtual NSFont TitleFont
	{
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("titleFont")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleFontHandle));
			}
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleFontHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("setTitleFont:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleFont_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	public virtual NSColor? TrackFillColor
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("trackFillColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackFillColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackFillColorHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("setTrackFillColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTrackFillColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTrackFillColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[Mac(10, 12)]
	public static NSSlider FromTarget(Action action)
	{
		NSActionDispatcher nSActionDispatcher = new NSActionDispatcher(action);
		NSSlider nSSlider = _FromTarget(nSActionDispatcher, NSDispatcher.Selector);
		nSSlider.dispatcher = nSActionDispatcher;
		return nSSlider;
	}

	[Mac(10, 12)]
	public static NSSlider FromValue(double value, double minValue, double maxValue, Action action)
	{
		NSActionDispatcher nSActionDispatcher = new NSActionDispatcher(action);
		NSSlider nSSlider = _FromValue(value, minValue, maxValue, nSActionDispatcher, NSDispatcher.Selector);
		nSSlider.dispatcher = nSActionDispatcher;
		return nSSlider;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSlider()
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
	public NSSlider(NSCoder coder)
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
	protected NSSlider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSlider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSlider(CGRect frameRect)
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

	[Export("acceptsFirstMouse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool AcceptsFirstMouse(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAcceptsFirstMouse_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAcceptsFirstMouse_Handle, theEvent.Handle);
	}

	[Export("accessibilityPerformDecrement")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool AccessibilityPerformDecrement()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformDecrementHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformDecrementHandle);
	}

	[Export("accessibilityPerformIncrement")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool AccessibilityPerformIncrement()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAccessibilityPerformIncrementHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessibilityPerformIncrementHandle);
	}

	[Export("closestTickMarkValueToValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ClosestTickMarkValue(double value)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double(base.Handle, selClosestTickMarkValueToValue_Handle, value);
		}
		return Messaging.Double_objc_msgSendSuper_Double(base.SuperHandle, selClosestTickMarkValueToValue_Handle, value);
	}

	[Export("indexOfTickMarkAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOfTickMark(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_CGPoint(base.Handle, selIndexOfTickMarkAtPoint_Handle, point);
		}
		return Messaging.nint_objc_msgSendSuper_CGPoint(base.SuperHandle, selIndexOfTickMarkAtPoint_Handle, point);
	}

	[Export("rectOfTickMarkAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect RectOfTick(nint index)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selRectOfTickMarkAtIndex_Handle, index);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selRectOfTickMarkAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("tickMarkValueAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TickMarkValue(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_nint(base.Handle, selTickMarkValueAtIndex_Handle, index);
		}
		return Messaging.Double_objc_msgSendSuper_nint(base.SuperHandle, selTickMarkValueAtIndex_Handle, index);
	}

	[Export("sliderWithTarget:action:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSSlider _FromTarget(NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSSlider>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selSliderWithTarget_Action_Handle, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
	}

	[Export("sliderWithValue:minValue:maxValue:target:action:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSSlider _FromValue(double value, double minValue, double maxValue, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSSlider>(Messaging.IntPtr_objc_msgSend_Double_Double_Double_IntPtr_IntPtr(class_ptr, selSliderWithValue_MinValue_MaxValue_Target_Action_Handle, value, minValue, maxValue, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
	}
}

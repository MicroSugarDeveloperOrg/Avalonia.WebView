using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColor", true)]
public class NSColor : NSObject
{
	private static readonly IntPtr selBlackColorHandle = Selector.GetHandle("blackColor");

	private static readonly IntPtr selDarkGrayColorHandle = Selector.GetHandle("darkGrayColor");

	private static readonly IntPtr selLightGrayColorHandle = Selector.GetHandle("lightGrayColor");

	private static readonly IntPtr selWhiteColorHandle = Selector.GetHandle("whiteColor");

	private static readonly IntPtr selGrayColorHandle = Selector.GetHandle("grayColor");

	private static readonly IntPtr selRedColorHandle = Selector.GetHandle("redColor");

	private static readonly IntPtr selGreenColorHandle = Selector.GetHandle("greenColor");

	private static readonly IntPtr selBlueColorHandle = Selector.GetHandle("blueColor");

	private static readonly IntPtr selCyanColorHandle = Selector.GetHandle("cyanColor");

	private static readonly IntPtr selYellowColorHandle = Selector.GetHandle("yellowColor");

	private static readonly IntPtr selMagentaColorHandle = Selector.GetHandle("magentaColor");

	private static readonly IntPtr selOrangeColorHandle = Selector.GetHandle("orangeColor");

	private static readonly IntPtr selPurpleColorHandle = Selector.GetHandle("purpleColor");

	private static readonly IntPtr selBrownColorHandle = Selector.GetHandle("brownColor");

	private static readonly IntPtr selClearColorHandle = Selector.GetHandle("clearColor");

	private static readonly IntPtr selControlShadowColorHandle = Selector.GetHandle("controlShadowColor");

	private static readonly IntPtr selControlDarkShadowColorHandle = Selector.GetHandle("controlDarkShadowColor");

	private static readonly IntPtr selControlColorHandle = Selector.GetHandle("controlColor");

	private static readonly IntPtr selControlHighlightColorHandle = Selector.GetHandle("controlHighlightColor");

	private static readonly IntPtr selControlLightHighlightColorHandle = Selector.GetHandle("controlLightHighlightColor");

	private static readonly IntPtr selControlTextColorHandle = Selector.GetHandle("controlTextColor");

	private static readonly IntPtr selControlBackgroundColorHandle = Selector.GetHandle("controlBackgroundColor");

	private static readonly IntPtr selSelectedControlColorHandle = Selector.GetHandle("selectedControlColor");

	private static readonly IntPtr selSecondarySelectedControlColorHandle = Selector.GetHandle("secondarySelectedControlColor");

	private static readonly IntPtr selSelectedControlTextColorHandle = Selector.GetHandle("selectedControlTextColor");

	private static readonly IntPtr selDisabledControlTextColorHandle = Selector.GetHandle("disabledControlTextColor");

	private static readonly IntPtr selTextColorHandle = Selector.GetHandle("textColor");

	private static readonly IntPtr selTextBackgroundColorHandle = Selector.GetHandle("textBackgroundColor");

	private static readonly IntPtr selSelectedTextColorHandle = Selector.GetHandle("selectedTextColor");

	private static readonly IntPtr selSelectedTextBackgroundColorHandle = Selector.GetHandle("selectedTextBackgroundColor");

	private static readonly IntPtr selGridColorHandle = Selector.GetHandle("gridColor");

	private static readonly IntPtr selKeyboardFocusIndicatorColorHandle = Selector.GetHandle("keyboardFocusIndicatorColor");

	private static readonly IntPtr selWindowBackgroundColorHandle = Selector.GetHandle("windowBackgroundColor");

	private static readonly IntPtr selScrollBarColorHandle = Selector.GetHandle("scrollBarColor");

	private static readonly IntPtr selKnobColorHandle = Selector.GetHandle("knobColor");

	private static readonly IntPtr selSelectedKnobColorHandle = Selector.GetHandle("selectedKnobColor");

	private static readonly IntPtr selWindowFrameColorHandle = Selector.GetHandle("windowFrameColor");

	private static readonly IntPtr selWindowFrameTextColorHandle = Selector.GetHandle("windowFrameTextColor");

	private static readonly IntPtr selSelectedMenuItemColorHandle = Selector.GetHandle("selectedMenuItemColor");

	private static readonly IntPtr selSelectedMenuItemTextColorHandle = Selector.GetHandle("selectedMenuItemTextColor");

	private static readonly IntPtr selHighlightColorHandle = Selector.GetHandle("highlightColor");

	private static readonly IntPtr selShadowColorHandle = Selector.GetHandle("shadowColor");

	private static readonly IntPtr selHeaderColorHandle = Selector.GetHandle("headerColor");

	private static readonly IntPtr selHeaderTextColorHandle = Selector.GetHandle("headerTextColor");

	private static readonly IntPtr selAlternateSelectedControlColorHandle = Selector.GetHandle("alternateSelectedControlColor");

	private static readonly IntPtr selAlternateSelectedControlTextColorHandle = Selector.GetHandle("alternateSelectedControlTextColor");

	private static readonly IntPtr selUnderPageBackgroundColorHandle = Selector.GetHandle("underPageBackgroundColor");

	private static readonly IntPtr selCurrentControlTintHandle = Selector.GetHandle("currentControlTint");

	private static readonly IntPtr selColorSpaceNameHandle = Selector.GetHandle("colorSpaceName");

	private static readonly IntPtr selCatalogNameComponentHandle = Selector.GetHandle("catalogNameComponent");

	private static readonly IntPtr selColorNameComponentHandle = Selector.GetHandle("colorNameComponent");

	private static readonly IntPtr selLocalizedCatalogNameComponentHandle = Selector.GetHandle("localizedCatalogNameComponent");

	private static readonly IntPtr selLocalizedColorNameComponentHandle = Selector.GetHandle("localizedColorNameComponent");

	private static readonly IntPtr selRedComponentHandle = Selector.GetHandle("redComponent");

	private static readonly IntPtr selGreenComponentHandle = Selector.GetHandle("greenComponent");

	private static readonly IntPtr selBlueComponentHandle = Selector.GetHandle("blueComponent");

	private static readonly IntPtr selHueComponentHandle = Selector.GetHandle("hueComponent");

	private static readonly IntPtr selSaturationComponentHandle = Selector.GetHandle("saturationComponent");

	private static readonly IntPtr selBrightnessComponentHandle = Selector.GetHandle("brightnessComponent");

	private static readonly IntPtr selWhiteComponentHandle = Selector.GetHandle("whiteComponent");

	private static readonly IntPtr selCyanComponentHandle = Selector.GetHandle("cyanComponent");

	private static readonly IntPtr selMagentaComponentHandle = Selector.GetHandle("magentaComponent");

	private static readonly IntPtr selYellowComponentHandle = Selector.GetHandle("yellowComponent");

	private static readonly IntPtr selBlackComponentHandle = Selector.GetHandle("blackComponent");

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	private static readonly IntPtr selNumberOfComponentsHandle = Selector.GetHandle("numberOfComponents");

	private static readonly IntPtr selAlphaComponentHandle = Selector.GetHandle("alphaComponent");

	private static readonly IntPtr selPatternImageHandle = Selector.GetHandle("patternImage");

	private static readonly IntPtr selCGColorHandle = Selector.GetHandle("CGColor");

	private static readonly IntPtr selIgnoresAlphaHandle = Selector.GetHandle("ignoresAlpha");

	private static readonly IntPtr selSetIgnoresAlpha_Handle = Selector.GetHandle("setIgnoresAlpha:");

	private static readonly IntPtr selColorWithCalibratedWhiteAlpha_Handle = Selector.GetHandle("colorWithCalibratedWhite:alpha:");

	private static readonly IntPtr selColorWithCalibratedHueSaturationBrightnessAlpha_Handle = Selector.GetHandle("colorWithCalibratedHue:saturation:brightness:alpha:");

	private static readonly IntPtr selColorWithCalibratedRedGreenBlueAlpha_Handle = Selector.GetHandle("colorWithCalibratedRed:green:blue:alpha:");

	private static readonly IntPtr selColorWithDeviceWhiteAlpha_Handle = Selector.GetHandle("colorWithDeviceWhite:alpha:");

	private static readonly IntPtr selColorWithDeviceHueSaturationBrightnessAlpha_Handle = Selector.GetHandle("colorWithDeviceHue:saturation:brightness:alpha:");

	private static readonly IntPtr selColorWithDeviceRedGreenBlueAlpha_Handle = Selector.GetHandle("colorWithDeviceRed:green:blue:alpha:");

	private static readonly IntPtr selColorWithDeviceCyanMagentaYellowBlackAlpha_Handle = Selector.GetHandle("colorWithDeviceCyan:magenta:yellow:black:alpha:");

	private static readonly IntPtr selColorWithCatalogNameColorName_Handle = Selector.GetHandle("colorWithCatalogName:colorName:");

	private static readonly IntPtr selColorWithColorSpaceComponentsCount_Handle = Selector.GetHandle("colorWithColorSpace:components:count:");

	private static readonly IntPtr selControlAlternatingRowBackgroundColorsHandle = Selector.GetHandle("controlAlternatingRowBackgroundColors");

	private static readonly IntPtr selHighlightWithLevel_Handle = Selector.GetHandle("highlightWithLevel:");

	private static readonly IntPtr selShadowWithLevel_Handle = Selector.GetHandle("shadowWithLevel:");

	private static readonly IntPtr selColorForControlTint_Handle = Selector.GetHandle("colorForControlTint:");

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	private static readonly IntPtr selSetFillHandle = Selector.GetHandle("setFill");

	private static readonly IntPtr selSetStrokeHandle = Selector.GetHandle("setStroke");

	private static readonly IntPtr selColorUsingColorSpaceName_Handle = Selector.GetHandle("colorUsingColorSpaceName:");

	private static readonly IntPtr selColorUsingColorSpaceNameDevice_Handle = Selector.GetHandle("colorUsingColorSpaceName:device:");

	private static readonly IntPtr selColorUsingColorSpace_Handle = Selector.GetHandle("colorUsingColorSpace:");

	private static readonly IntPtr selBlendedColorWithFractionOfColor_Handle = Selector.GetHandle("blendedColorWithFraction:ofColor:");

	private static readonly IntPtr selColorWithAlphaComponent_Handle = Selector.GetHandle("colorWithAlphaComponent:");

	private static readonly IntPtr selGetRedGreenBlueAlpha_Handle = Selector.GetHandle("getRed:green:blue:alpha:");

	private static readonly IntPtr selGetHueSaturationBrightnessAlpha_Handle = Selector.GetHandle("getHue:saturation:brightness:alpha:");

	private static readonly IntPtr selGetWhiteAlpha_Handle = Selector.GetHandle("getWhite:alpha:");

	private static readonly IntPtr selGetCyanMagentaYellowBlackAlpha_Handle = Selector.GetHandle("getCyan:magenta:yellow:black:alpha:");

	private static readonly IntPtr selGetComponents_Handle = Selector.GetHandle("getComponents:");

	private static readonly IntPtr selColorFromPasteboard_Handle = Selector.GetHandle("colorFromPasteboard:");

	private static readonly IntPtr selWriteToPasteboard_Handle = Selector.GetHandle("writeToPasteboard:");

	private static readonly IntPtr selColorWithPatternImage_Handle = Selector.GetHandle("colorWithPatternImage:");

	private static readonly IntPtr selDrawSwatchInRect_Handle = Selector.GetHandle("drawSwatchInRect:");

	private static readonly IntPtr selColorWithCIColor_Handle = Selector.GetHandle("colorWithCIColor:");

	private static readonly IntPtr selColorWithCGColor_Handle = Selector.GetHandle("colorWithCGColor:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSColor");

	private static object __mt_Black_var_static;

	private static object __mt_DarkGray_var_static;

	private static object __mt_LightGray_var_static;

	private static object __mt_White_var_static;

	private static object __mt_Gray_var_static;

	private static object __mt_Red_var_static;

	private static object __mt_Green_var_static;

	private static object __mt_Blue_var_static;

	private static object __mt_Cyan_var_static;

	private static object __mt_Yellow_var_static;

	private static object __mt_Magenta_var_static;

	private static object __mt_Orange_var_static;

	private static object __mt_Purple_var_static;

	private static object __mt_Brown_var_static;

	private static object __mt_Clear_var_static;

	private static object __mt_ControlShadow_var_static;

	private static object __mt_ControlDarkShadow_var_static;

	private static object __mt_Control_var_static;

	private static object __mt_ControlHighlight_var_static;

	private static object __mt_ControlLightHighlight_var_static;

	private static object __mt_ControlText_var_static;

	private static object __mt_ControlBackground_var_static;

	private static object __mt_SelectedControl_var_static;

	private static object __mt_SecondarySelectedControl_var_static;

	private static object __mt_SelectedControlText_var_static;

	private static object __mt_DisabledControlText_var_static;

	private static object __mt_Text_var_static;

	private static object __mt_TextBackground_var_static;

	private static object __mt_SelectedText_var_static;

	private static object __mt_SelectedTextBackground_var_static;

	private static object __mt_Grid_var_static;

	private static object __mt_KeyboardFocusIndicator_var_static;

	private static object __mt_WindowBackground_var_static;

	private static object __mt_ScrollBar_var_static;

	private static object __mt_Knob_var_static;

	private static object __mt_SelectedKnob_var_static;

	private static object __mt_WindowFrame_var_static;

	private static object __mt_WindowFrameText_var_static;

	private static object __mt_SelectedMenuItem_var_static;

	private static object __mt_SelectedMenuItemText_var_static;

	private static object __mt_Highlight_var_static;

	private static object __mt_Shadow_var_static;

	private static object __mt_Header_var_static;

	private static object __mt_HeaderText_var_static;

	private static object __mt_AlternateSelectedControl_var_static;

	private static object __mt_AlternateSelectedControlText_var_static;

	private static object __mt_UnderPageBackground_var_static;

	private object __mt_ColorSpace_var;

	private object __mt_PatternImage_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSColor Black
	{
		[Export("blackColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Black_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selBlackColorHandle)));
		}
	}

	public static NSColor DarkGray
	{
		[Export("darkGrayColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_DarkGray_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDarkGrayColorHandle)));
		}
	}

	public static NSColor LightGray
	{
		[Export("lightGrayColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_LightGray_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLightGrayColorHandle)));
		}
	}

	public static NSColor White
	{
		[Export("whiteColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_White_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selWhiteColorHandle)));
		}
	}

	public static NSColor Gray
	{
		[Export("grayColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Gray_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selGrayColorHandle)));
		}
	}

	public static NSColor Red
	{
		[Export("redColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Red_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selRedColorHandle)));
		}
	}

	public static NSColor Green
	{
		[Export("greenColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Green_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selGreenColorHandle)));
		}
	}

	public static NSColor Blue
	{
		[Export("blueColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Blue_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selBlueColorHandle)));
		}
	}

	public static NSColor Cyan
	{
		[Export("cyanColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Cyan_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCyanColorHandle)));
		}
	}

	public static NSColor Yellow
	{
		[Export("yellowColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Yellow_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selYellowColorHandle)));
		}
	}

	public static NSColor Magenta
	{
		[Export("magentaColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Magenta_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selMagentaColorHandle)));
		}
	}

	public static NSColor Orange
	{
		[Export("orangeColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Orange_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selOrangeColorHandle)));
		}
	}

	public static NSColor Purple
	{
		[Export("purpleColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Purple_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selPurpleColorHandle)));
		}
	}

	public static NSColor Brown
	{
		[Export("brownColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Brown_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selBrownColorHandle)));
		}
	}

	public static NSColor Clear
	{
		[Export("clearColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Clear_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selClearColorHandle)));
		}
	}

	public static NSColor ControlShadow
	{
		[Export("controlShadowColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_ControlShadow_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selControlShadowColorHandle)));
		}
	}

	public static NSColor ControlDarkShadow
	{
		[Export("controlDarkShadowColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_ControlDarkShadow_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selControlDarkShadowColorHandle)));
		}
	}

	public static NSColor Control
	{
		[Export("controlColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Control_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selControlColorHandle)));
		}
	}

	public static NSColor ControlHighlight
	{
		[Export("controlHighlightColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_ControlHighlight_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selControlHighlightColorHandle)));
		}
	}

	public static NSColor ControlLightHighlight
	{
		[Export("controlLightHighlightColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_ControlLightHighlight_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selControlLightHighlightColorHandle)));
		}
	}

	public static NSColor ControlText
	{
		[Export("controlTextColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_ControlText_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selControlTextColorHandle)));
		}
	}

	public static NSColor ControlBackground
	{
		[Export("controlBackgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_ControlBackground_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selControlBackgroundColorHandle)));
		}
	}

	public static NSColor SelectedControl
	{
		[Export("selectedControlColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_SelectedControl_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedControlColorHandle)));
		}
	}

	public static NSColor SecondarySelectedControl
	{
		[Export("secondarySelectedControlColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_SecondarySelectedControl_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSecondarySelectedControlColorHandle)));
		}
	}

	public static NSColor SelectedControlText
	{
		[Export("selectedControlTextColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_SelectedControlText_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedControlTextColorHandle)));
		}
	}

	public static NSColor DisabledControlText
	{
		[Export("disabledControlTextColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_DisabledControlText_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDisabledControlTextColorHandle)));
		}
	}

	public static NSColor Text
	{
		[Export("textColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Text_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selTextColorHandle)));
		}
	}

	public static NSColor TextBackground
	{
		[Export("textBackgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_TextBackground_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selTextBackgroundColorHandle)));
		}
	}

	public static NSColor SelectedText
	{
		[Export("selectedTextColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_SelectedText_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedTextColorHandle)));
		}
	}

	public static NSColor SelectedTextBackground
	{
		[Export("selectedTextBackgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_SelectedTextBackground_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedTextBackgroundColorHandle)));
		}
	}

	public static NSColor Grid
	{
		[Export("gridColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Grid_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selGridColorHandle)));
		}
	}

	public static NSColor KeyboardFocusIndicator
	{
		[Export("keyboardFocusIndicatorColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_KeyboardFocusIndicator_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selKeyboardFocusIndicatorColorHandle)));
		}
	}

	public static NSColor WindowBackground
	{
		[Export("windowBackgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_WindowBackground_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selWindowBackgroundColorHandle)));
		}
	}

	public static NSColor ScrollBar
	{
		[Export("scrollBarColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_ScrollBar_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selScrollBarColorHandle)));
		}
	}

	public static NSColor Knob
	{
		[Export("knobColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Knob_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selKnobColorHandle)));
		}
	}

	public static NSColor SelectedKnob
	{
		[Export("selectedKnobColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_SelectedKnob_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedKnobColorHandle)));
		}
	}

	public static NSColor WindowFrame
	{
		[Export("windowFrameColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_WindowFrame_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selWindowFrameColorHandle)));
		}
	}

	public static NSColor WindowFrameText
	{
		[Export("windowFrameTextColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_WindowFrameText_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selWindowFrameTextColorHandle)));
		}
	}

	public static NSColor SelectedMenuItem
	{
		[Export("selectedMenuItemColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_SelectedMenuItem_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedMenuItemColorHandle)));
		}
	}

	public static NSColor SelectedMenuItemText
	{
		[Export("selectedMenuItemTextColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_SelectedMenuItemText_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedMenuItemTextColorHandle)));
		}
	}

	public static NSColor Highlight
	{
		[Export("highlightColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Highlight_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selHighlightColorHandle)));
		}
	}

	public static NSColor Shadow
	{
		[Export("shadowColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Shadow_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selShadowColorHandle)));
		}
	}

	public static NSColor Header
	{
		[Export("headerColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Header_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selHeaderColorHandle)));
		}
	}

	public static NSColor HeaderText
	{
		[Export("headerTextColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_HeaderText_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selHeaderTextColorHandle)));
		}
	}

	public static NSColor AlternateSelectedControl
	{
		[Export("alternateSelectedControlColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_AlternateSelectedControl_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selAlternateSelectedControlColorHandle)));
		}
	}

	public static NSColor AlternateSelectedControlText
	{
		[Export("alternateSelectedControlTextColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_AlternateSelectedControlText_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selAlternateSelectedControlTextColorHandle)));
		}
	}

	[MountainLion]
	public static NSColor UnderPageBackground
	{
		[MountainLion]
		[Export("underPageBackgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_UnderPageBackground_var_static = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selUnderPageBackgroundColorHandle)));
		}
	}

	public static NSControlTint CurrentControlTint
	{
		[Export("currentControlTint")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSControlTint)Messaging.UInt64_objc_msgSend(class_ptr, selCurrentControlTintHandle);
		}
	}

	public virtual string ColorSpaceName
	{
		[Export("colorSpaceName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceNameHandle));
		}
	}

	public virtual string CatalogNameComponent
	{
		[Export("catalogNameComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCatalogNameComponentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCatalogNameComponentHandle));
		}
	}

	public virtual string ColorNameComponent
	{
		[Export("colorNameComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selColorNameComponentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorNameComponentHandle));
		}
	}

	public virtual string LocalizedCatalogNameComponent
	{
		[Export("localizedCatalogNameComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedCatalogNameComponentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedCatalogNameComponentHandle));
		}
	}

	public virtual string LocalizedColorNameComponent
	{
		[Export("localizedColorNameComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedColorNameComponentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedColorNameComponentHandle));
		}
	}

	public virtual double RedComponent
	{
		[Export("redComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRedComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRedComponentHandle);
		}
	}

	public virtual double GreenComponent
	{
		[Export("greenComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selGreenComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selGreenComponentHandle);
		}
	}

	public virtual double BlueComponent
	{
		[Export("blueComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBlueComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBlueComponentHandle);
		}
	}

	public virtual double HueComponent
	{
		[Export("hueComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selHueComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selHueComponentHandle);
		}
	}

	public virtual double SaturationComponent
	{
		[Export("saturationComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSaturationComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSaturationComponentHandle);
		}
	}

	public virtual double BrightnessComponent
	{
		[Export("brightnessComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBrightnessComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBrightnessComponentHandle);
		}
	}

	public virtual double WhiteComponent
	{
		[Export("whiteComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selWhiteComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selWhiteComponentHandle);
		}
	}

	public virtual double CyanComponent
	{
		[Export("cyanComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCyanComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCyanComponentHandle);
		}
	}

	public virtual double MagentaComponent
	{
		[Export("magentaComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMagentaComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMagentaComponentHandle);
		}
	}

	public virtual double YellowComponent
	{
		[Export("yellowComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selYellowComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selYellowComponentHandle);
		}
	}

	public virtual double BlackComponent
	{
		[Export("blackComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBlackComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBlackComponentHandle);
		}
	}

	public virtual NSColorSpace ColorSpace
	{
		[Export("colorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_ColorSpace_var = ((!IsDirectBinding) ? ((NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle))) : ((NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle)))));
		}
	}

	public virtual long ComponentCount
	{
		[Export("numberOfComponents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfComponentsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfComponentsHandle);
		}
	}

	public virtual double AlphaComponent
	{
		[Export("alphaComponent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAlphaComponentHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAlphaComponentHandle);
		}
	}

	public virtual NSImage PatternImage
	{
		[Export("patternImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_PatternImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPatternImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPatternImageHandle)))));
		}
	}

	[MountainLion]
	public virtual CGColor CGColor
	{
		[MountainLion]
		[Export("CGColor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return new CGColor(Messaging.IntPtr_objc_msgSend(base.Handle, selCGColorHandle));
			}
			return new CGColor(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGColorHandle));
		}
	}

	public static bool IgnoresAlpha
	{
		[Export("ignoresAlpha")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIgnoresAlphaHandle);
		}
		[Export("setIgnoresAlpha:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(class_ptr, selSetIgnoresAlpha_Handle, value);
		}
	}

	public static NSColor FromColorSpace(NSColorSpace space, double[] components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(components[0]) * components.Length);
		Marshal.Copy(components, 0, intPtr, components.Length);
		NSColor result = _FromColorSpace(space, intPtr, components.Length);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public void GetComponents(out double[] components)
	{
		int num = (int)ComponentCount;
		double[] array = new double[num];
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(array[0]) * num);
		_GetComponents(intPtr);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		components = array;
	}

	public override string ToString()
	{
		try
		{
			string colorSpaceName = ColorSpaceName;
			if (colorSpaceName == "NSNamedColorSpace")
			{
				return LocalizedCatalogNameComponent + "/" + LocalizedColorNameComponent;
			}
			if (colorSpaceName == "NSPatternColorSpace")
			{
				return "Pattern Color: " + PatternImage.Name;
			}
			StringBuilder stringBuilder = new StringBuilder(ColorSpace.LocalizedName);
			GetComponents(out var components);
			if (components.Length != 0)
			{
				stringBuilder.Append("(" + components[0]);
			}
			for (int i = 1; i < components.Length; i++)
			{
				stringBuilder.Append("," + components[i]);
			}
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}
		catch
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSColor(NSCoder coder)
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
	public NSColor(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSColor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("colorWithCalibratedWhite:alpha:")]
	public static NSColor FromCalibratedWhite(double white, double alpha)
	{
		NSApplication.EnsureUIThread();
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double(class_ptr, selColorWithCalibratedWhiteAlpha_Handle, white, alpha));
	}

	[Export("colorWithCalibratedHue:saturation:brightness:alpha:")]
	public static NSColor FromCalibratedHsba(double hue, double saturation, double brightness, double alpha)
	{
		NSApplication.EnsureUIThread();
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double_Double_Double(class_ptr, selColorWithCalibratedHueSaturationBrightnessAlpha_Handle, hue, saturation, brightness, alpha));
	}

	[Export("colorWithCalibratedRed:green:blue:alpha:")]
	public static NSColor FromCalibratedRgba(double red, double green, double blue, double alpha)
	{
		NSApplication.EnsureUIThread();
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double_Double_Double(class_ptr, selColorWithCalibratedRedGreenBlueAlpha_Handle, red, green, blue, alpha));
	}

	[Export("colorWithDeviceWhite:alpha:")]
	public static NSColor FromDeviceWhite(double white, double alpha)
	{
		NSApplication.EnsureUIThread();
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double(class_ptr, selColorWithDeviceWhiteAlpha_Handle, white, alpha));
	}

	[Export("colorWithDeviceHue:saturation:brightness:alpha:")]
	public static NSColor FromDeviceHsba(double hue, double saturation, double brightness, double alpha)
	{
		NSApplication.EnsureUIThread();
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double_Double_Double(class_ptr, selColorWithDeviceHueSaturationBrightnessAlpha_Handle, hue, saturation, brightness, alpha));
	}

	[Export("colorWithDeviceRed:green:blue:alpha:")]
	public static NSColor FromDeviceRgba(double red, double green, double blue, double alpha)
	{
		NSApplication.EnsureUIThread();
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double_Double_Double(class_ptr, selColorWithDeviceRedGreenBlueAlpha_Handle, red, green, blue, alpha));
	}

	[Export("colorWithDeviceCyan:magenta:yellow:black:alpha:")]
	public static NSColor FromDeviceCymka(double cyan, double magenta, double yellow, double black, double alpha)
	{
		NSApplication.EnsureUIThread();
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_Double_Double_Double_Double(class_ptr, selColorWithDeviceCyanMagentaYellowBlackAlpha_Handle, cyan, magenta, yellow, black, alpha));
	}

	[Export("colorWithCatalogName:colorName:")]
	public static NSColor FromCatalogName(string listName, string colorName)
	{
		NSApplication.EnsureUIThread();
		if (listName == null)
		{
			throw new ArgumentNullException("listName");
		}
		if (colorName == null)
		{
			throw new ArgumentNullException("colorName");
		}
		IntPtr arg = NSString.CreateNative(listName);
		IntPtr arg2 = NSString.CreateNative(colorName);
		NSColor result = (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selColorWithCatalogNameColorName_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("colorWithColorSpace:components:count:")]
	internal static NSColor _FromColorSpace(NSColorSpace space, IntPtr components, long numberOfComponents)
	{
		NSApplication.EnsureUIThread();
		if (space == null)
		{
			throw new ArgumentNullException("space");
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64(class_ptr, selColorWithColorSpaceComponentsCount_Handle, space.Handle, components, numberOfComponents));
	}

	[Export("controlAlternatingRowBackgroundColors")]
	public static NSColor[] ControlAlternatingRowBackgroundColors()
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selControlAlternatingRowBackgroundColorsHandle));
	}

	[Export("highlightWithLevel:")]
	public virtual NSColor HighlightWithLevel(double highlightLevel)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selHighlightWithLevel_Handle, highlightLevel));
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selHighlightWithLevel_Handle, highlightLevel));
	}

	[Export("shadowWithLevel:")]
	public virtual NSColor ShadowWithLevel(double shadowLevel)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selShadowWithLevel_Handle, shadowLevel));
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selShadowWithLevel_Handle, shadowLevel));
	}

	[Export("colorForControlTint:")]
	public static NSColor FromControlTint(NSControlTint controlTint)
	{
		NSApplication.EnsureUIThread();
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selColorForControlTint_Handle, (ulong)controlTint));
	}

	[Export("set")]
	public virtual void Set()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetHandle);
		}
	}

	[Export("setFill")]
	public virtual void SetFill()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetFillHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetFillHandle);
		}
	}

	[Export("setStroke")]
	public virtual void SetStroke()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetStrokeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetStrokeHandle);
		}
	}

	[Export("colorUsingColorSpaceName:")]
	public virtual NSColor UsingColorSpace(string colorSpaceName)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(colorSpaceName);
		NSColor result = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selColorUsingColorSpaceName_Handle, arg))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selColorUsingColorSpaceName_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("colorUsingColorSpaceName:device:")]
	public virtual NSColor UsingColorSpace(string colorSpaceName, NSDictionary deviceDescription)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(colorSpaceName);
		NSColor result = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selColorUsingColorSpaceNameDevice_Handle, arg, deviceDescription?.Handle ?? IntPtr.Zero))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selColorUsingColorSpaceNameDevice_Handle, arg, deviceDescription?.Handle ?? IntPtr.Zero))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("colorUsingColorSpace:")]
	public virtual NSColor UsingColorSpace(NSColorSpace colorSpace)
	{
		NSApplication.EnsureUIThread();
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (IsDirectBinding)
		{
			return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selColorUsingColorSpace_Handle, colorSpace.Handle));
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selColorUsingColorSpace_Handle, colorSpace.Handle));
	}

	[Export("blendedColorWithFraction:ofColor:")]
	public virtual NSColor BlendedColor(double fraction, NSColor color)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (IsDirectBinding)
		{
			return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double_IntPtr(base.Handle, selBlendedColorWithFractionOfColor_Handle, fraction, color.Handle));
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Double_IntPtr(base.SuperHandle, selBlendedColorWithFractionOfColor_Handle, fraction, color.Handle));
	}

	[Export("colorWithAlphaComponent:")]
	public virtual NSColor ColorWithAlphaComponent(double alpha)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selColorWithAlphaComponent_Handle, alpha));
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selColorWithAlphaComponent_Handle, alpha));
	}

	[Export("getRed:green:blue:alpha:")]
	public virtual void GetRgba(out double red, out double green, out double blue, out double alpha)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_Double_out_Double_out_Double_out_Double(base.Handle, selGetRedGreenBlueAlpha_Handle, out red, out green, out blue, out alpha);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_Double_out_Double_out_Double_out_Double(base.SuperHandle, selGetRedGreenBlueAlpha_Handle, out red, out green, out blue, out alpha);
		}
	}

	[Export("getHue:saturation:brightness:alpha:")]
	public virtual void GetHsba(out double hue, out double saturation, out double brightness, out double alpha)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_Double_out_Double_out_Double_out_Double(base.Handle, selGetHueSaturationBrightnessAlpha_Handle, out hue, out saturation, out brightness, out alpha);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_Double_out_Double_out_Double_out_Double(base.SuperHandle, selGetHueSaturationBrightnessAlpha_Handle, out hue, out saturation, out brightness, out alpha);
		}
	}

	[Export("getWhite:alpha:")]
	public virtual void GetWhiteAlpha(out double white, out double alpha)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_Double_out_Double(base.Handle, selGetWhiteAlpha_Handle, out white, out alpha);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_Double_out_Double(base.SuperHandle, selGetWhiteAlpha_Handle, out white, out alpha);
		}
	}

	[Export("getCyan:magenta:yellow:black:alpha:")]
	public virtual void GetCmyka(out double cyan, out double magenta, out double yellow, out double black, out double alpha)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_Double_out_Double_out_Double_out_Double_out_Double(base.Handle, selGetCyanMagentaYellowBlackAlpha_Handle, out cyan, out magenta, out yellow, out black, out alpha);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_Double_out_Double_out_Double_out_Double_out_Double(base.SuperHandle, selGetCyanMagentaYellowBlackAlpha_Handle, out cyan, out magenta, out yellow, out black, out alpha);
		}
	}

	[Export("getComponents:")]
	internal virtual void _GetComponents(IntPtr components)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetComponents_Handle, components);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetComponents_Handle, components);
		}
	}

	[Export("colorFromPasteboard:")]
	public static NSColor FromPasteboard(NSPasteboard pasteBoard)
	{
		NSApplication.EnsureUIThread();
		if (pasteBoard == null)
		{
			throw new ArgumentNullException("pasteBoard");
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorFromPasteboard_Handle, pasteBoard.Handle));
	}

	[Export("writeToPasteboard:")]
	public virtual void WriteToPasteboard(NSPasteboard pasteBoard)
	{
		NSApplication.EnsureUIThread();
		if (pasteBoard == null)
		{
			throw new ArgumentNullException("pasteBoard");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWriteToPasteboard_Handle, pasteBoard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToPasteboard_Handle, pasteBoard.Handle);
		}
	}

	[Export("colorWithPatternImage:")]
	public static NSColor FromPatternImage(NSImage image)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorWithPatternImage_Handle, image.Handle));
	}

	[Export("drawSwatchInRect:")]
	public virtual void DrawSwatchInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawSwatchInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawSwatchInRect_Handle, rect);
		}
	}

	[Export("colorWithCIColor:")]
	public static NSColor FromCIColor(CIColor color)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorWithCIColor_Handle, color.Handle));
	}

	[Export("colorWithCGColor:")]
	[MountainLion]
	public static NSColor FromCGColor(CGColor color)
	{
		NSApplication.EnsureUIThread();
		return (NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorWithCGColor_Handle, color.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ColorSpace_var = null;
			__mt_PatternImage_var = null;
		}
	}
}

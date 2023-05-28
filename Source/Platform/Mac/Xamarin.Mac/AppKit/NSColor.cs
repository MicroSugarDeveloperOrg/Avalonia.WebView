using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColor", true)]
public class NSColor : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSPasteboardReading, INSPasteboardWriting, INSSecureCoding
{
	public static class Notifications
	{
		public static NSObject ObserveSystemColorsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SystemColorsChanged, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSystemColorsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SystemColorsChanged, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGColor = "CGColor";

	private static readonly IntPtr selCGColorHandle = Selector.GetHandle("CGColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlphaComponent = "alphaComponent";

	private static readonly IntPtr selAlphaComponentHandle = Selector.GetHandle("alphaComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternateSelectedControlColor = "alternateSelectedControlColor";

	private static readonly IntPtr selAlternateSelectedControlColorHandle = Selector.GetHandle("alternateSelectedControlColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternateSelectedControlTextColor = "alternateSelectedControlTextColor";

	private static readonly IntPtr selAlternateSelectedControlTextColorHandle = Selector.GetHandle("alternateSelectedControlTextColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternatingContentBackgroundColors = "alternatingContentBackgroundColors";

	private static readonly IntPtr selAlternatingContentBackgroundColorsHandle = Selector.GetHandle("alternatingContentBackgroundColors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlackColor = "blackColor";

	private static readonly IntPtr selBlackColorHandle = Selector.GetHandle("blackColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlackComponent = "blackComponent";

	private static readonly IntPtr selBlackComponentHandle = Selector.GetHandle("blackComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendedColorWithFraction_OfColor_ = "blendedColorWithFraction:ofColor:";

	private static readonly IntPtr selBlendedColorWithFraction_OfColor_Handle = Selector.GetHandle("blendedColorWithFraction:ofColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlueColor = "blueColor";

	private static readonly IntPtr selBlueColorHandle = Selector.GetHandle("blueColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlueComponent = "blueComponent";

	private static readonly IntPtr selBlueComponentHandle = Selector.GetHandle("blueComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBrightnessComponent = "brightnessComponent";

	private static readonly IntPtr selBrightnessComponentHandle = Selector.GetHandle("brightnessComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBrownColor = "brownColor";

	private static readonly IntPtr selBrownColorHandle = Selector.GetHandle("brownColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCatalogNameComponent = "catalogNameComponent";

	private static readonly IntPtr selCatalogNameComponentHandle = Selector.GetHandle("catalogNameComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearColor = "clearColor";

	private static readonly IntPtr selClearColorHandle = Selector.GetHandle("clearColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorForControlTint_ = "colorForControlTint:";

	private static readonly IntPtr selColorForControlTint_Handle = Selector.GetHandle("colorForControlTint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorFromPasteboard_ = "colorFromPasteboard:";

	private static readonly IntPtr selColorFromPasteboard_Handle = Selector.GetHandle("colorFromPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorNameComponent = "colorNameComponent";

	private static readonly IntPtr selColorNameComponentHandle = Selector.GetHandle("colorNameComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorNamed_ = "colorNamed:";

	private static readonly IntPtr selColorNamed_Handle = Selector.GetHandle("colorNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorNamed_Bundle_ = "colorNamed:bundle:";

	private static readonly IntPtr selColorNamed_Bundle_Handle = Selector.GetHandle("colorNamed:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpace = "colorSpace";

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpaceName = "colorSpaceName";

	private static readonly IntPtr selColorSpaceNameHandle = Selector.GetHandle("colorSpaceName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorUsingColorSpace_ = "colorUsingColorSpace:";

	private static readonly IntPtr selColorUsingColorSpace_Handle = Selector.GetHandle("colorUsingColorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorUsingColorSpaceName_ = "colorUsingColorSpaceName:";

	private static readonly IntPtr selColorUsingColorSpaceName_Handle = Selector.GetHandle("colorUsingColorSpaceName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorUsingColorSpaceName_Device_ = "colorUsingColorSpaceName:device:";

	private static readonly IntPtr selColorUsingColorSpaceName_Device_Handle = Selector.GetHandle("colorUsingColorSpaceName:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorUsingType_ = "colorUsingType:";

	private static readonly IntPtr selColorUsingType_Handle = Selector.GetHandle("colorUsingType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithAlphaComponent_ = "colorWithAlphaComponent:";

	private static readonly IntPtr selColorWithAlphaComponent_Handle = Selector.GetHandle("colorWithAlphaComponent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithCGColor_ = "colorWithCGColor:";

	private static readonly IntPtr selColorWithCGColor_Handle = Selector.GetHandle("colorWithCGColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithCIColor_ = "colorWithCIColor:";

	private static readonly IntPtr selColorWithCIColor_Handle = Selector.GetHandle("colorWithCIColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithCalibratedHue_Saturation_Brightness_Alpha_ = "colorWithCalibratedHue:saturation:brightness:alpha:";

	private static readonly IntPtr selColorWithCalibratedHue_Saturation_Brightness_Alpha_Handle = Selector.GetHandle("colorWithCalibratedHue:saturation:brightness:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithCalibratedRed_Green_Blue_Alpha_ = "colorWithCalibratedRed:green:blue:alpha:";

	private static readonly IntPtr selColorWithCalibratedRed_Green_Blue_Alpha_Handle = Selector.GetHandle("colorWithCalibratedRed:green:blue:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithCalibratedWhite_Alpha_ = "colorWithCalibratedWhite:alpha:";

	private static readonly IntPtr selColorWithCalibratedWhite_Alpha_Handle = Selector.GetHandle("colorWithCalibratedWhite:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithCatalogName_ColorName_ = "colorWithCatalogName:colorName:";

	private static readonly IntPtr selColorWithCatalogName_ColorName_Handle = Selector.GetHandle("colorWithCatalogName:colorName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithColorSpace_Components_Count_ = "colorWithColorSpace:components:count:";

	private static readonly IntPtr selColorWithColorSpace_Components_Count_Handle = Selector.GetHandle("colorWithColorSpace:components:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithColorSpace_Hue_Saturation_Brightness_Alpha_ = "colorWithColorSpace:hue:saturation:brightness:alpha:";

	private static readonly IntPtr selColorWithColorSpace_Hue_Saturation_Brightness_Alpha_Handle = Selector.GetHandle("colorWithColorSpace:hue:saturation:brightness:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithDeviceCyan_Magenta_Yellow_Black_Alpha_ = "colorWithDeviceCyan:magenta:yellow:black:alpha:";

	private static readonly IntPtr selColorWithDeviceCyan_Magenta_Yellow_Black_Alpha_Handle = Selector.GetHandle("colorWithDeviceCyan:magenta:yellow:black:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithDeviceHue_Saturation_Brightness_Alpha_ = "colorWithDeviceHue:saturation:brightness:alpha:";

	private static readonly IntPtr selColorWithDeviceHue_Saturation_Brightness_Alpha_Handle = Selector.GetHandle("colorWithDeviceHue:saturation:brightness:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithDeviceRed_Green_Blue_Alpha_ = "colorWithDeviceRed:green:blue:alpha:";

	private static readonly IntPtr selColorWithDeviceRed_Green_Blue_Alpha_Handle = Selector.GetHandle("colorWithDeviceRed:green:blue:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithDeviceWhite_Alpha_ = "colorWithDeviceWhite:alpha:";

	private static readonly IntPtr selColorWithDeviceWhite_Alpha_Handle = Selector.GetHandle("colorWithDeviceWhite:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithDisplayP3Red_Green_Blue_Alpha_ = "colorWithDisplayP3Red:green:blue:alpha:";

	private static readonly IntPtr selColorWithDisplayP3Red_Green_Blue_Alpha_Handle = Selector.GetHandle("colorWithDisplayP3Red:green:blue:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithGenericGamma22White_Alpha_ = "colorWithGenericGamma22White:alpha:";

	private static readonly IntPtr selColorWithGenericGamma22White_Alpha_Handle = Selector.GetHandle("colorWithGenericGamma22White:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithHue_Saturation_Brightness_Alpha_ = "colorWithHue:saturation:brightness:alpha:";

	private static readonly IntPtr selColorWithHue_Saturation_Brightness_Alpha_Handle = Selector.GetHandle("colorWithHue:saturation:brightness:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithName_DynamicProvider_ = "colorWithName:dynamicProvider:";

	private static readonly IntPtr selColorWithName_DynamicProvider_Handle = Selector.GetHandle("colorWithName:dynamicProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithPatternImage_ = "colorWithPatternImage:";

	private static readonly IntPtr selColorWithPatternImage_Handle = Selector.GetHandle("colorWithPatternImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithRed_Green_Blue_Alpha_ = "colorWithRed:green:blue:alpha:";

	private static readonly IntPtr selColorWithRed_Green_Blue_Alpha_Handle = Selector.GetHandle("colorWithRed:green:blue:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithSRGBRed_Green_Blue_Alpha_ = "colorWithSRGBRed:green:blue:alpha:";

	private static readonly IntPtr selColorWithSRGBRed_Green_Blue_Alpha_Handle = Selector.GetHandle("colorWithSRGBRed:green:blue:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithSystemEffect_ = "colorWithSystemEffect:";

	private static readonly IntPtr selColorWithSystemEffect_Handle = Selector.GetHandle("colorWithSystemEffect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithWhite_Alpha_ = "colorWithWhite:alpha:";

	private static readonly IntPtr selColorWithWhite_Alpha_Handle = Selector.GetHandle("colorWithWhite:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlAccentColor = "controlAccentColor";

	private static readonly IntPtr selControlAccentColorHandle = Selector.GetHandle("controlAccentColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlAlternatingRowBackgroundColors = "controlAlternatingRowBackgroundColors";

	private static readonly IntPtr selControlAlternatingRowBackgroundColorsHandle = Selector.GetHandle("controlAlternatingRowBackgroundColors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlBackgroundColor = "controlBackgroundColor";

	private static readonly IntPtr selControlBackgroundColorHandle = Selector.GetHandle("controlBackgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlColor = "controlColor";

	private static readonly IntPtr selControlColorHandle = Selector.GetHandle("controlColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlDarkShadowColor = "controlDarkShadowColor";

	private static readonly IntPtr selControlDarkShadowColorHandle = Selector.GetHandle("controlDarkShadowColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlHighlightColor = "controlHighlightColor";

	private static readonly IntPtr selControlHighlightColorHandle = Selector.GetHandle("controlHighlightColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlLightHighlightColor = "controlLightHighlightColor";

	private static readonly IntPtr selControlLightHighlightColorHandle = Selector.GetHandle("controlLightHighlightColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlShadowColor = "controlShadowColor";

	private static readonly IntPtr selControlShadowColorHandle = Selector.GetHandle("controlShadowColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlTextColor = "controlTextColor";

	private static readonly IntPtr selControlTextColorHandle = Selector.GetHandle("controlTextColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentControlTint = "currentControlTint";

	private static readonly IntPtr selCurrentControlTintHandle = Selector.GetHandle("currentControlTint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCyanColor = "cyanColor";

	private static readonly IntPtr selCyanColorHandle = Selector.GetHandle("cyanColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCyanComponent = "cyanComponent";

	private static readonly IntPtr selCyanComponentHandle = Selector.GetHandle("cyanComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDarkGrayColor = "darkGrayColor";

	private static readonly IntPtr selDarkGrayColorHandle = Selector.GetHandle("darkGrayColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisabledControlTextColor = "disabledControlTextColor";

	private static readonly IntPtr selDisabledControlTextColorHandle = Selector.GetHandle("disabledControlTextColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawSwatchInRect_ = "drawSwatchInRect:";

	private static readonly IntPtr selDrawSwatchInRect_Handle = Selector.GetHandle("drawSwatchInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindHighlightColor = "findHighlightColor";

	private static readonly IntPtr selFindHighlightColorHandle = Selector.GetHandle("findHighlightColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetComponents_ = "getComponents:";

	private static readonly IntPtr selGetComponents_Handle = Selector.GetHandle("getComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetCyan_Magenta_Yellow_Black_Alpha_ = "getCyan:magenta:yellow:black:alpha:";

	private static readonly IntPtr selGetCyan_Magenta_Yellow_Black_Alpha_Handle = Selector.GetHandle("getCyan:magenta:yellow:black:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetHue_Saturation_Brightness_Alpha_ = "getHue:saturation:brightness:alpha:";

	private static readonly IntPtr selGetHue_Saturation_Brightness_Alpha_Handle = Selector.GetHandle("getHue:saturation:brightness:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetRed_Green_Blue_Alpha_ = "getRed:green:blue:alpha:";

	private static readonly IntPtr selGetRed_Green_Blue_Alpha_Handle = Selector.GetHandle("getRed:green:blue:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetWhite_Alpha_ = "getWhite:alpha:";

	private static readonly IntPtr selGetWhite_Alpha_Handle = Selector.GetHandle("getWhite:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGrayColor = "grayColor";

	private static readonly IntPtr selGrayColorHandle = Selector.GetHandle("grayColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGreenColor = "greenColor";

	private static readonly IntPtr selGreenColorHandle = Selector.GetHandle("greenColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGreenComponent = "greenComponent";

	private static readonly IntPtr selGreenComponentHandle = Selector.GetHandle("greenComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridColor = "gridColor";

	private static readonly IntPtr selGridColorHandle = Selector.GetHandle("gridColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeaderColor = "headerColor";

	private static readonly IntPtr selHeaderColorHandle = Selector.GetHandle("headerColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeaderTextColor = "headerTextColor";

	private static readonly IntPtr selHeaderTextColorHandle = Selector.GetHandle("headerTextColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlightColor = "highlightColor";

	private static readonly IntPtr selHighlightColorHandle = Selector.GetHandle("highlightColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlightWithLevel_ = "highlightWithLevel:";

	private static readonly IntPtr selHighlightWithLevel_Handle = Selector.GetHandle("highlightWithLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHueComponent = "hueComponent";

	private static readonly IntPtr selHueComponentHandle = Selector.GetHandle("hueComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoresAlpha = "ignoresAlpha";

	private static readonly IntPtr selIgnoresAlphaHandle = Selector.GetHandle("ignoresAlpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyboardFocusIndicatorColor = "keyboardFocusIndicatorColor";

	private static readonly IntPtr selKeyboardFocusIndicatorColorHandle = Selector.GetHandle("keyboardFocusIndicatorColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKnobColor = "knobColor";

	private static readonly IntPtr selKnobColorHandle = Selector.GetHandle("knobColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelColor = "labelColor";

	private static readonly IntPtr selLabelColorHandle = Selector.GetHandle("labelColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightGrayColor = "lightGrayColor";

	private static readonly IntPtr selLightGrayColorHandle = Selector.GetHandle("lightGrayColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinkColor = "linkColor";

	private static readonly IntPtr selLinkColorHandle = Selector.GetHandle("linkColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedCatalogNameComponent = "localizedCatalogNameComponent";

	private static readonly IntPtr selLocalizedCatalogNameComponentHandle = Selector.GetHandle("localizedCatalogNameComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedColorNameComponent = "localizedColorNameComponent";

	private static readonly IntPtr selLocalizedColorNameComponentHandle = Selector.GetHandle("localizedColorNameComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagentaColor = "magentaColor";

	private static readonly IntPtr selMagentaColorHandle = Selector.GetHandle("magentaColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagentaComponent = "magentaComponent";

	private static readonly IntPtr selMagentaComponentHandle = Selector.GetHandle("magentaComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfComponents = "numberOfComponents";

	private static readonly IntPtr selNumberOfComponentsHandle = Selector.GetHandle("numberOfComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrangeColor = "orangeColor";

	private static readonly IntPtr selOrangeColorHandle = Selector.GetHandle("orangeColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteboardPropertyListForType_ = "pasteboardPropertyListForType:";

	private static readonly IntPtr selPasteboardPropertyListForType_Handle = Selector.GetHandle("pasteboardPropertyListForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPatternImage = "patternImage";

	private static readonly IntPtr selPatternImageHandle = Selector.GetHandle("patternImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaceholderTextColor = "placeholderTextColor";

	private static readonly IntPtr selPlaceholderTextColorHandle = Selector.GetHandle("placeholderTextColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPurpleColor = "purpleColor";

	private static readonly IntPtr selPurpleColorHandle = Selector.GetHandle("purpleColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuaternaryLabelColor = "quaternaryLabelColor";

	private static readonly IntPtr selQuaternaryLabelColorHandle = Selector.GetHandle("quaternaryLabelColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadableTypesForPasteboard_ = "readableTypesForPasteboard:";

	private static readonly IntPtr selReadableTypesForPasteboard_Handle = Selector.GetHandle("readableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadingOptionsForType_Pasteboard_ = "readingOptionsForType:pasteboard:";

	private static readonly IntPtr selReadingOptionsForType_Pasteboard_Handle = Selector.GetHandle("readingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedColor = "redColor";

	private static readonly IntPtr selRedColorHandle = Selector.GetHandle("redColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedComponent = "redComponent";

	private static readonly IntPtr selRedComponentHandle = Selector.GetHandle("redComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaturationComponent = "saturationComponent";

	private static readonly IntPtr selSaturationComponentHandle = Selector.GetHandle("saturationComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollBarColor = "scrollBarColor";

	private static readonly IntPtr selScrollBarColorHandle = Selector.GetHandle("scrollBarColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrubberTexturedBackgroundColor = "scrubberTexturedBackgroundColor";

	private static readonly IntPtr selScrubberTexturedBackgroundColorHandle = Selector.GetHandle("scrubberTexturedBackgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryLabelColor = "secondaryLabelColor";

	private static readonly IntPtr selSecondaryLabelColorHandle = Selector.GetHandle("secondaryLabelColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondarySelectedControlColor = "secondarySelectedControlColor";

	private static readonly IntPtr selSecondarySelectedControlColorHandle = Selector.GetHandle("secondarySelectedControlColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedContentBackgroundColor = "selectedContentBackgroundColor";

	private static readonly IntPtr selSelectedContentBackgroundColorHandle = Selector.GetHandle("selectedContentBackgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedControlColor = "selectedControlColor";

	private static readonly IntPtr selSelectedControlColorHandle = Selector.GetHandle("selectedControlColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedControlTextColor = "selectedControlTextColor";

	private static readonly IntPtr selSelectedControlTextColorHandle = Selector.GetHandle("selectedControlTextColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedKnobColor = "selectedKnobColor";

	private static readonly IntPtr selSelectedKnobColorHandle = Selector.GetHandle("selectedKnobColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedMenuItemColor = "selectedMenuItemColor";

	private static readonly IntPtr selSelectedMenuItemColorHandle = Selector.GetHandle("selectedMenuItemColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedMenuItemTextColor = "selectedMenuItemTextColor";

	private static readonly IntPtr selSelectedMenuItemTextColorHandle = Selector.GetHandle("selectedMenuItemTextColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedTextBackgroundColor = "selectedTextBackgroundColor";

	private static readonly IntPtr selSelectedTextBackgroundColorHandle = Selector.GetHandle("selectedTextBackgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedTextColor = "selectedTextColor";

	private static readonly IntPtr selSelectedTextColorHandle = Selector.GetHandle("selectedTextColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeparatorColor = "separatorColor";

	private static readonly IntPtr selSeparatorColorHandle = Selector.GetHandle("separatorColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSet = "set";

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFill = "setFill";

	private static readonly IntPtr selSetFillHandle = Selector.GetHandle("setFill");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIgnoresAlpha_ = "setIgnoresAlpha:";

	private static readonly IntPtr selSetIgnoresAlpha_Handle = Selector.GetHandle("setIgnoresAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStroke = "setStroke";

	private static readonly IntPtr selSetStrokeHandle = Selector.GetHandle("setStroke");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShadowColor = "shadowColor";

	private static readonly IntPtr selShadowColorHandle = Selector.GetHandle("shadowColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShadowWithLevel_ = "shadowWithLevel:";

	private static readonly IntPtr selShadowWithLevel_Handle = Selector.GetHandle("shadowWithLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemBlueColor = "systemBlueColor";

	private static readonly IntPtr selSystemBlueColorHandle = Selector.GetHandle("systemBlueColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemBrownColor = "systemBrownColor";

	private static readonly IntPtr selSystemBrownColorHandle = Selector.GetHandle("systemBrownColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemGrayColor = "systemGrayColor";

	private static readonly IntPtr selSystemGrayColorHandle = Selector.GetHandle("systemGrayColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemGreenColor = "systemGreenColor";

	private static readonly IntPtr selSystemGreenColorHandle = Selector.GetHandle("systemGreenColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemIndigoColor = "systemIndigoColor";

	private static readonly IntPtr selSystemIndigoColorHandle = Selector.GetHandle("systemIndigoColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemOrangeColor = "systemOrangeColor";

	private static readonly IntPtr selSystemOrangeColorHandle = Selector.GetHandle("systemOrangeColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemPinkColor = "systemPinkColor";

	private static readonly IntPtr selSystemPinkColorHandle = Selector.GetHandle("systemPinkColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemPurpleColor = "systemPurpleColor";

	private static readonly IntPtr selSystemPurpleColorHandle = Selector.GetHandle("systemPurpleColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemRedColor = "systemRedColor";

	private static readonly IntPtr selSystemRedColorHandle = Selector.GetHandle("systemRedColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemTealColor = "systemTealColor";

	private static readonly IntPtr selSystemTealColorHandle = Selector.GetHandle("systemTealColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemYellowColor = "systemYellowColor";

	private static readonly IntPtr selSystemYellowColorHandle = Selector.GetHandle("systemYellowColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTertiaryLabelColor = "tertiaryLabelColor";

	private static readonly IntPtr selTertiaryLabelColorHandle = Selector.GetHandle("tertiaryLabelColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextBackgroundColor = "textBackgroundColor";

	private static readonly IntPtr selTextBackgroundColorHandle = Selector.GetHandle("textBackgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextColor = "textColor";

	private static readonly IntPtr selTextColorHandle = Selector.GetHandle("textColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnderPageBackgroundColor = "underPageBackgroundColor";

	private static readonly IntPtr selUnderPageBackgroundColorHandle = Selector.GetHandle("underPageBackgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnemphasizedSelectedContentBackgroundColor = "unemphasizedSelectedContentBackgroundColor";

	private static readonly IntPtr selUnemphasizedSelectedContentBackgroundColorHandle = Selector.GetHandle("unemphasizedSelectedContentBackgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnemphasizedSelectedTextBackgroundColor = "unemphasizedSelectedTextBackgroundColor";

	private static readonly IntPtr selUnemphasizedSelectedTextBackgroundColorHandle = Selector.GetHandle("unemphasizedSelectedTextBackgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnemphasizedSelectedTextColor = "unemphasizedSelectedTextColor";

	private static readonly IntPtr selUnemphasizedSelectedTextColorHandle = Selector.GetHandle("unemphasizedSelectedTextColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWhiteColor = "whiteColor";

	private static readonly IntPtr selWhiteColorHandle = Selector.GetHandle("whiteColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWhiteComponent = "whiteComponent";

	private static readonly IntPtr selWhiteComponentHandle = Selector.GetHandle("whiteComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowBackgroundColor = "windowBackgroundColor";

	private static readonly IntPtr selWindowBackgroundColorHandle = Selector.GetHandle("windowBackgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowFrameColor = "windowFrameColor";

	private static readonly IntPtr selWindowFrameColorHandle = Selector.GetHandle("windowFrameColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowFrameTextColor = "windowFrameTextColor";

	private static readonly IntPtr selWindowFrameTextColorHandle = Selector.GetHandle("windowFrameTextColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritableTypesForPasteboard_ = "writableTypesForPasteboard:";

	private static readonly IntPtr selWritableTypesForPasteboard_Handle = Selector.GetHandle("writableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToPasteboard_ = "writeToPasteboard:";

	private static readonly IntPtr selWriteToPasteboard_Handle = Selector.GetHandle("writeToPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritingOptionsForType_Pasteboard_ = "writingOptionsForType:pasteboard:";

	private static readonly IntPtr selWritingOptionsForType_Pasteboard_Handle = Selector.GetHandle("writingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXamarinselector_Removed_ = "xamarinselector:removed:";

	private static readonly IntPtr selXamarinselector_Removed_Handle = Selector.GetHandle("xamarinselector:removed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYellowColor = "yellowColor";

	private static readonly IntPtr selYellowColorHandle = Selector.GetHandle("yellowColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYellowComponent = "yellowComponent";

	private static readonly IntPtr selYellowComponentHandle = Selector.GetHandle("yellowComponent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SystemColorsChanged;

	[Obsolete("Use 'UnderPageBackgroundColor' instead.")]
	public static NSColor UnderPageBackground => UnderPageBackgroundColor;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat AlphaComponent
	{
		[Export("alphaComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selAlphaComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selAlphaComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, PlatformArchitecture.None, "Use 'SelectedContentBackgroundColor' instead.")]
	public static NSColor AlternateSelectedControl
	{
		[Deprecated(PlatformName.MacOSX, PlatformArchitecture.None, "Use 'SelectedContentBackgroundColor' instead.")]
		[Export("alternateSelectedControlColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selAlternateSelectedControlColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor AlternateSelectedControlText
	{
		[Export("alternateSelectedControlTextColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selAlternateSelectedControlTextColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSColor[] AlternatingContentBackgroundColors
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("alternatingContentBackgroundColors", ArgumentSemantic.Retain)]
		get
		{
			return NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selAlternatingContentBackgroundColorsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Black
	{
		[Export("blackColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selBlackColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BlackComponent
	{
		[Export("blackComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selBlackComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selBlackComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Blue
	{
		[Export("blueColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selBlueColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BlueComponent
	{
		[Export("blueComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selBlueComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selBlueComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BrightnessComponent
	{
		[Export("brightnessComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selBrightnessComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selBrightnessComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Brown
	{
		[Export("brownColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selBrownColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor CGColor
	{
		[Export("CGColor")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCGColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual string CatalogNameComponent
	{
		[Export("catalogNameComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCatalogNameComponentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCatalogNameComponentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Clear
	{
		[Export("clearColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selClearColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual string ColorNameComponent
	{
		[Export("colorNameComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selColorNameComponentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorNameComponentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual NSColorSpace ColorSpace
	{
		[Export("colorSpace")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle));
			}
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Type' and 'NSColorType' instead.")]
	public virtual string ColorSpaceName
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Type' and 'NSColorType' instead.")]
		[Export("colorSpaceName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual nint ComponentCount
	{
		[Export("numberOfComponents")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfComponentsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfComponentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Control
	{
		[Export("controlColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selControlColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSColor ControlAccentColor
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("controlAccentColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selControlAccentColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor ControlBackground
	{
		[Export("controlBackgroundColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selControlBackgroundColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use a context specific color, 'SeparatorColor'")]
	public static NSColor ControlDarkShadow
	{
		[Export("controlDarkShadowColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selControlDarkShadowColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use a context specific color, 'SeparatorColor'")]
	public static NSColor ControlHighlight
	{
		[Export("controlHighlightColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selControlHighlightColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use a context specific color, 'SeparatorColor'")]
	public static NSColor ControlLightHighlight
	{
		[Export("controlLightHighlightColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selControlLightHighlightColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use a context specific color, 'SeparatorColor'")]
	public static NSColor ControlShadow
	{
		[Export("controlShadowColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selControlShadowColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor ControlText
	{
		[Export("controlTextColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selControlTextColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSControlTint CurrentControlTint
	{
		[Export("currentControlTint")]
		get
		{
			return (NSControlTint)Messaging.UInt64_objc_msgSend(class_ptr, selCurrentControlTintHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Cyan
	{
		[Export("cyanColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selCyanColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat CyanComponent
	{
		[Export("cyanComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selCyanComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selCyanComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor DarkGray
	{
		[Export("darkGrayColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selDarkGrayColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor DisabledControlText
	{
		[Export("disabledControlTextColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selDisabledControlTextColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSColor FindHighlightColor
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("findHighlightColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selFindHighlightColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Gray
	{
		[Export("grayColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selGrayColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Green
	{
		[Export("greenColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selGreenColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GreenComponent
	{
		[Export("greenComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selGreenComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selGreenComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Grid
	{
		[Export("gridColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selGridColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'NSVisualEffectMaterial.HeaderView' instead")]
	public static NSColor Header
	{
		[Export("headerColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selHeaderColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor HeaderText
	{
		[Export("headerTextColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selHeaderTextColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Highlight
	{
		[Export("highlightColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selHighlightColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat HueComponent
	{
		[Export("hueComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selHueComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selHueComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IgnoresAlpha
	{
		[Export("ignoresAlpha")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIgnoresAlphaHandle);
		}
		[Export("setIgnoresAlpha:")]
		set
		{
			Messaging.void_objc_msgSend_bool(class_ptr, selSetIgnoresAlpha_Handle, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor KeyboardFocusIndicator
	{
		[Export("keyboardFocusIndicatorColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selKeyboardFocusIndicatorColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'NSScroller' instead")]
	public static NSColor Knob
	{
		[Export("knobColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selKnobColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor LabelColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("labelColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selLabelColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor LightGray
	{
		[Export("lightGrayColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selLightGrayColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor LinkColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("linkColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selLinkColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual string LocalizedCatalogNameComponent
	{
		[Export("localizedCatalogNameComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedCatalogNameComponentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedCatalogNameComponentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual string LocalizedColorNameComponent
	{
		[Export("localizedColorNameComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedColorNameComponentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedColorNameComponentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Magenta
	{
		[Export("magentaColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selMagentaColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MagentaComponent
	{
		[Export("magentaComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selMagentaComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selMagentaComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Orange
	{
		[Export("orangeColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selOrangeColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual NSImage PatternImage
	{
		[Export("patternImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selPatternImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPatternImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor PlaceholderTextColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("placeholderTextColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selPlaceholderTextColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Purple
	{
		[Export("purpleColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selPurpleColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor QuaternaryLabelColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("quaternaryLabelColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selQuaternaryLabelColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Red
	{
		[Export("redColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selRedColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RedComponent
	{
		[Export("redComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selRedComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selRedComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat SaturationComponent
	{
		[Export("saturationComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selSaturationComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selSaturationComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'NSScroller' instead")]
	public static NSColor ScrollBar
	{
		[Export("scrollBarColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selScrollBarColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	public static NSColor ScrubberTexturedBackgroundColor
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("scrubberTexturedBackgroundColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selScrubberTexturedBackgroundColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor SecondaryLabelColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("secondaryLabelColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSecondaryLabelColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, PlatformArchitecture.None, "Use 'SelectedContentBackgroundColor' instead.")]
	public static NSColor SecondarySelectedControl
	{
		[Deprecated(PlatformName.MacOSX, PlatformArchitecture.None, "Use 'SelectedContentBackgroundColor' instead.")]
		[Export("secondarySelectedControlColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSecondarySelectedControlColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSColor SelectedContentBackgroundColor
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("selectedContentBackgroundColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedContentBackgroundColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor SelectedControl
	{
		[Export("selectedControlColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedControlColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor SelectedControlText
	{
		[Export("selectedControlTextColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedControlTextColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'NSScroller' instead")]
	public static NSColor SelectedKnob
	{
		[Export("selectedKnobColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedKnobColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'NSVisualEffectMaterial.Selection' instead")]
	public static NSColor SelectedMenuItem
	{
		[Export("selectedMenuItemColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedMenuItemColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor SelectedMenuItemText
	{
		[Export("selectedMenuItemTextColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedMenuItemTextColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor SelectedText
	{
		[Export("selectedTextColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedTextColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor SelectedTextBackground
	{
		[Export("selectedTextBackgroundColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSelectedTextBackgroundColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSColor SeparatorColor
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("separatorColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSeparatorColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Shadow
	{
		[Export("shadowColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selShadowColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor SystemBlueColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("systemBlueColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemBlueColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor SystemBrownColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("systemBrownColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemBrownColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor SystemGrayColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("systemGrayColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemGrayColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor SystemGreenColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("systemGreenColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemGreenColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSColor SystemIndigoColor
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("systemIndigoColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemIndigoColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor SystemOrangeColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("systemOrangeColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemOrangeColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor SystemPinkColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("systemPinkColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemPinkColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor SystemPurpleColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("systemPurpleColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemPurpleColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor SystemRedColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("systemRedColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemRedColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSColor SystemTealColor
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("systemTealColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemTealColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor SystemYellowColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("systemYellowColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selSystemYellowColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSColor TertiaryLabelColor
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("tertiaryLabelColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selTertiaryLabelColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Text
	{
		[Export("textColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selTextColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor TextBackground
	{
		[Export("textBackgroundColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selTextBackgroundColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSColorType Type
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSColorType)Messaging.Int64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (NSColorType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor UnderPageBackgroundColor
	{
		[Export("underPageBackgroundColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnderPageBackgroundColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSColor UnemphasizedSelectedContentBackgroundColor
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("unemphasizedSelectedContentBackgroundColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnemphasizedSelectedContentBackgroundColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSColor UnemphasizedSelectedTextBackgroundColor
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("unemphasizedSelectedTextBackgroundColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnemphasizedSelectedTextBackgroundColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSColor UnemphasizedSelectedTextColor
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("unemphasizedSelectedTextColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnemphasizedSelectedTextColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor White
	{
		[Export("whiteColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selWhiteColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat WhiteComponent
	{
		[Export("whiteComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selWhiteComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selWhiteComponentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor WindowBackground
	{
		[Export("windowBackgroundColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selWindowBackgroundColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'NSVisualEffectMaterial.Title' instead")]
	public static NSColor WindowFrame
	{
		[Export("windowFrameColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selWindowFrameColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor WindowFrameText
	{
		[Export("windowFrameTextColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selWindowFrameTextColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor Yellow
	{
		[Export("yellowColor")]
		get
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selYellowColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat YellowComponent
	{
		[Export("yellowComponent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_nfloat_objc_msgSend(base.Handle, selYellowComponentHandle);
			}
			return Messaging.xamarin_nfloat_objc_msgSendSuper(base.SuperHandle, selYellowComponentHandle);
		}
	}

	[Field("NSSystemColorsDidChangeNotification", "AppKit")]
	[Advice("Use NSColor.Notifications.ObserveSystemColorsChanged helper method instead.")]
	public static NSString SystemColorsChanged
	{
		get
		{
			if (_SystemColorsChanged == null)
			{
				_SystemColorsChanged = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSystemColorsDidChangeNotification");
			}
			return _SystemColorsChanged;
		}
	}

	public static NSColor FromRgb(nfloat red, nfloat green, nfloat blue)
	{
		return FromRgba(red, green, blue, 1f);
	}

	public static NSColor FromRgb(byte red, byte green, byte blue)
	{
		return FromRgba((float)(int)red / 255f, (float)(int)green / 255f, (float)(int)blue / 255f, 1f);
	}

	public static NSColor FromRgb(int red, int green, int blue)
	{
		return FromRgb((byte)red, (byte)green, (byte)blue);
	}

	public static NSColor FromRgba(byte red, byte green, byte blue, byte alpha)
	{
		return FromRgba((float)(int)red / 255f, (float)(int)green / 255f, (float)(int)blue / 255f, (float)(int)alpha / 255f);
	}

	public static NSColor FromRgba(int red, int green, int blue, int alpha)
	{
		return FromRgba((byte)red, (byte)green, (byte)blue, (byte)alpha);
	}

	public static NSColor FromHsb(nfloat hue, nfloat saturation, nfloat brightness)
	{
		return FromHsba(hue, saturation, brightness, 1f);
	}

	public static NSColor FromHsba(byte hue, byte saturation, byte brightness, byte alpha)
	{
		return FromHsba((float)(int)hue / 255f, (float)(int)saturation / 255f, (float)(int)brightness / 255f, (float)(int)alpha / 255f);
	}

	public static NSColor FromHsb(byte hue, byte saturation, byte brightness)
	{
		return FromHsba((float)(int)hue / 255f, (float)(int)saturation / 255f, (float)(int)brightness / 255f, 1f);
	}

	public static NSColor FromHsba(int hue, int saturation, int brightness, int alpha)
	{
		return FromHsba((byte)hue, (byte)saturation, (byte)brightness, (byte)alpha);
	}

	public static NSColor FromHsb(int hue, int saturation, int brightness)
	{
		return FromHsb((byte)hue, (byte)saturation, (byte)brightness);
	}

	public static NSColor FromDeviceRgb(nfloat red, nfloat green, nfloat blue)
	{
		return FromDeviceRgba(red, green, blue, 1f);
	}

	public static NSColor FromDeviceRgb(byte red, byte green, byte blue)
	{
		return FromDeviceRgba((float)(int)red / 255f, (float)(int)green / 255f, (float)(int)blue / 255f, 1f);
	}

	public static NSColor FromDeviceRgb(int red, int green, int blue)
	{
		return FromDeviceRgb((byte)red, (byte)green, (byte)blue);
	}

	public static NSColor FromDeviceRgba(byte red, byte green, byte blue, byte alpha)
	{
		return FromDeviceRgba((float)(int)red / 255f, (float)(int)green / 255f, (float)(int)blue / 255f, (float)(int)alpha / 255f);
	}

	public static NSColor FromDeviceRgba(int red, int green, int blue, int alpha)
	{
		return FromDeviceRgba((byte)red, (byte)green, (byte)blue, (byte)alpha);
	}

	public static NSColor FromDeviceHsb(nfloat hue, nfloat saturation, nfloat brightness)
	{
		return FromDeviceHsba(hue, saturation, brightness, 1f);
	}

	public static NSColor FromDeviceHsba(byte hue, byte saturation, byte brightness, byte alpha)
	{
		return FromDeviceHsba((float)(int)hue / 255f, (float)(int)saturation / 255f, (float)(int)brightness / 255f, (float)(int)alpha / 255f);
	}

	public static NSColor FromDeviceHsb(byte hue, byte saturation, byte brightness)
	{
		return FromDeviceHsba((float)(int)hue / 255f, (float)(int)saturation / 255f, (float)(int)brightness / 255f, 1f);
	}

	public static NSColor FromDeviceHsba(int hue, int saturation, int brightness, int alpha)
	{
		return FromDeviceHsba((byte)hue, (byte)saturation, (byte)brightness, (byte)alpha);
	}

	public static NSColor FromDeviceHsb(int hue, int saturation, int brightness)
	{
		return FromDeviceHsb((byte)hue, (byte)saturation, (byte)brightness);
	}

	public static NSColor FromDeviceCymk(nfloat cyan, nfloat magenta, nfloat yellow, nfloat black)
	{
		return FromDeviceCymka(cyan, magenta, yellow, black, 1f);
	}

	public static NSColor FromDeviceCymka(byte cyan, byte magenta, byte yellow, byte black, byte alpha)
	{
		return FromDeviceCymka((float)(int)cyan / 255f, (float)(int)magenta / 255f, (float)(int)yellow / 255f, (float)(int)black / 255f, (float)(int)alpha / 255f);
	}

	public static NSColor FromDeviceCymk(byte cyan, byte magenta, byte yellow, byte black)
	{
		return FromDeviceCymka((float)(int)cyan / 255f, (float)(int)magenta / 255f, (float)(int)yellow / 255f, (float)(int)black / 255f, 1f);
	}

	public static NSColor FromDeviceCymka(int cyan, int magenta, int yellow, int black, int alpha)
	{
		return FromDeviceCymka((byte)cyan, (byte)magenta, (byte)yellow, (byte)black, (byte)alpha);
	}

	public static NSColor FromDeviceCymk(int cyan, int magenta, int yellow, int black)
	{
		return FromDeviceCymk((byte)cyan, (byte)magenta, (byte)yellow, (byte)black);
	}

	public static NSColor FromCalibratedRgb(nfloat red, nfloat green, nfloat blue)
	{
		return FromCalibratedRgba(red, green, blue, 1f);
	}

	public static NSColor FromCalibratedRgb(byte red, byte green, byte blue)
	{
		return FromCalibratedRgba((float)(int)red / 255f, (float)(int)green / 255f, (float)(int)blue / 255f, 1f);
	}

	public static NSColor FromCalibratedRgb(int red, int green, int blue)
	{
		return FromCalibratedRgb((byte)red, (byte)green, (byte)blue);
	}

	public static NSColor FromCalibratedRgba(byte red, byte green, byte blue, byte alpha)
	{
		return FromCalibratedRgba((float)(int)red / 255f, (float)(int)green / 255f, (float)(int)blue / 255f, (float)(int)alpha / 255f);
	}

	public static NSColor FromCalibratedRgba(int red, int green, int blue, int alpha)
	{
		return FromCalibratedRgba((byte)red, (byte)green, (byte)blue, (byte)alpha);
	}

	public static NSColor FromCalibratedHsb(nfloat hue, nfloat saturation, nfloat brightness)
	{
		return FromCalibratedHsba(hue, saturation, brightness, 1f);
	}

	public static NSColor FromCalibratedHsba(byte hue, byte saturation, byte brightness, byte alpha)
	{
		return FromCalibratedHsba((float)(int)hue / 255f, (float)(int)saturation / 255f, (float)(int)brightness / 255f, (float)(int)alpha / 255f);
	}

	public static NSColor FromCalibratedHsb(byte hue, byte saturation, byte brightness)
	{
		return FromCalibratedHsba((float)(int)hue / 255f, (float)(int)saturation / 255f, (float)(int)brightness / 255f, 1f);
	}

	public static NSColor FromCalibratedHsba(int hue, int saturation, int brightness, int alpha)
	{
		return FromCalibratedHsba((byte)hue, (byte)saturation, (byte)brightness, (byte)alpha);
	}

	public static NSColor FromCalibratedHsb(int hue, int saturation, int brightness)
	{
		return FromCalibratedHsb((byte)hue, (byte)saturation, (byte)brightness);
	}

	public static NSColor FromColorSpace(NSColorSpace space, nfloat[] components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Marshal.AllocHGlobal(components.Length * IntPtr.Size);
			nfloat.CopyArray(components, 0, intPtr, components.Length);
			return _FromColorSpace(space, intPtr, components.Length);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public void GetComponents(out nfloat[] components)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			int num = (int)ComponentCount;
			components = new nfloat[num];
			intPtr = Marshal.AllocHGlobal(num * IntPtr.Size);
			_GetComponents(intPtr);
			nfloat.CopyArray(intPtr, components, 0, num);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
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
				nfloat nfloat = components[0];
				stringBuilder.Append("(" + nfloat.ToString());
			}
			for (int i = 1; i < components.Length; i++)
			{
				nfloat nfloat = components[i];
				stringBuilder.Append("," + nfloat.ToString());
			}
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}
		catch
		{
			return base.ToString();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSColor(NSCoder coder)
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
	protected NSColor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSColor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("blendedColorWithFraction:ofColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor BlendedColor(nfloat fraction, NSColor color)
	{
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_IntPtr(base.Handle, selBlendedColorWithFraction_OfColor_Handle, fraction, color.Handle));
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_nfloat_IntPtr(base.SuperHandle, selBlendedColorWithFraction_OfColor_Handle, fraction, color.Handle));
	}

	[Export("colorWithAlphaComponent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor ColorWithAlphaComponent(nfloat alpha)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selColorWithAlphaComponent_Handle, alpha));
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selColorWithAlphaComponent_Handle, alpha));
	}

	[Export("controlAlternatingRowBackgroundColors")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'AlternatingContentBackgroundColors' instead.")]
	public static NSColor[] ControlAlternatingRowBackgroundColors()
	{
		return NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selControlAlternatingRowBackgroundColorsHandle));
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

	[Export("drawSwatchInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawSwatchInRect(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawSwatchInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawSwatchInRect_Handle, rect);
		}
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

	[Export("colorWithCGColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromCGColor(CGColor cgColor)
	{
		if (cgColor == null)
		{
			throw new ArgumentNullException("cgColor");
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorWithCGColor_Handle, cgColor.Handle));
	}

	[Export("colorWithCIColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromCIColor(CIColor color)
	{
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorWithCIColor_Handle, color.Handle));
	}

	[Export("colorWithCalibratedHue:saturation:brightness:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromCalibratedHsba(nfloat hue, nfloat saturation, nfloat brightness, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(class_ptr, selColorWithCalibratedHue_Saturation_Brightness_Alpha_Handle, hue, saturation, brightness, alpha));
	}

	[Export("colorWithCalibratedRed:green:blue:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromCalibratedRgba(nfloat red, nfloat green, nfloat blue, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(class_ptr, selColorWithCalibratedRed_Green_Blue_Alpha_Handle, red, green, blue, alpha));
	}

	[Export("colorWithCalibratedWhite:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromCalibratedWhite(nfloat white, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selColorWithCalibratedWhite_Alpha_Handle, white, alpha));
	}

	[Export("colorWithCatalogName:colorName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromCatalogName(string listName, string colorName)
	{
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
		NSColor nSObject = Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selColorWithCatalogName_ColorName_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}

	[Export("colorWithColorSpace:hue:saturation:brightness:alpha:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromColor(NSColorSpace space, nfloat hue, nfloat saturation, nfloat brightness, nfloat alpha)
	{
		if (space == null)
		{
			throw new ArgumentNullException("space");
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat_nfloat_nfloat_nfloat(class_ptr, selColorWithColorSpace_Hue_Saturation_Brightness_Alpha_Handle, space.Handle, hue, saturation, brightness, alpha));
	}

	[Export("colorForControlTint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'NSColor.ControlAccentColor' instead.")]
	public static NSColor FromControlTint(NSControlTint controlTint)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selColorForControlTint_Handle, (ulong)controlTint));
	}

	[Export("colorWithDeviceCyan:magenta:yellow:black:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromDeviceCymka(nfloat cyan, nfloat magenta, nfloat yellow, nfloat black, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat_nfloat(class_ptr, selColorWithDeviceCyan_Magenta_Yellow_Black_Alpha_Handle, cyan, magenta, yellow, black, alpha));
	}

	[Export("colorWithDeviceHue:saturation:brightness:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromDeviceHsba(nfloat hue, nfloat saturation, nfloat brightness, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(class_ptr, selColorWithDeviceHue_Saturation_Brightness_Alpha_Handle, hue, saturation, brightness, alpha));
	}

	[Export("colorWithDeviceRed:green:blue:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromDeviceRgba(nfloat red, nfloat green, nfloat blue, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(class_ptr, selColorWithDeviceRed_Green_Blue_Alpha_Handle, red, green, blue, alpha));
	}

	[Export("colorWithDeviceWhite:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromDeviceWhite(nfloat white, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selColorWithDeviceWhite_Alpha_Handle, white, alpha));
	}

	[Export("colorWithDisplayP3Red:green:blue:alpha:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromDisplayP3(nfloat red, nfloat green, nfloat blue, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(class_ptr, selColorWithDisplayP3Red_Green_Blue_Alpha_Handle, red, green, blue, alpha));
	}

	[Export("colorWithGenericGamma22White:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromGamma22White(nfloat white, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selColorWithGenericGamma22White_Alpha_Handle, white, alpha));
	}

	[Export("colorWithHue:saturation:brightness:alpha:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromHsba(nfloat hue, nfloat saturation, nfloat brightness, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(class_ptr, selColorWithHue_Saturation_Brightness_Alpha_Handle, hue, saturation, brightness, alpha));
	}

	[Export("colorNamed:bundle:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor? FromName(string name, NSBundle? bundle)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSColor nSObject = Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selColorNamed_Bundle_Handle, arg, bundle?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("colorNamed:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor? FromName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSColor nSObject = Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("colorFromPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromPasteboard(NSPasteboard pasteBoard)
	{
		if (pasteBoard == null)
		{
			throw new ArgumentNullException("pasteBoard");
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorFromPasteboard_Handle, pasteBoard.Handle));
	}

	[Export("colorWithPatternImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromPatternImage(NSImage image)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorWithPatternImage_Handle, image.Handle));
	}

	[Export("colorWithRed:green:blue:alpha:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromRgba(nfloat red, nfloat green, nfloat blue, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(class_ptr, selColorWithRed_Green_Blue_Alpha_Handle, red, green, blue, alpha));
	}

	[Export("colorWithSRGBRed:green:blue:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromSrgb(nfloat red, nfloat green, nfloat blue, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(class_ptr, selColorWithSRGBRed_Green_Blue_Alpha_Handle, red, green, blue, alpha));
	}

	[Export("colorWithSystemEffect:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor FromSystemEffect(NSColorSystemEffect systemEffect)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selColorWithSystemEffect_Handle, (long)systemEffect));
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selColorWithSystemEffect_Handle, (long)systemEffect));
	}

	[Export("colorWithWhite:alpha:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor FromWhite(nfloat white, nfloat alpha)
	{
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selColorWithWhite_Alpha_Handle, white, alpha));
	}

	[Export("getCyan:magenta:yellow:black:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetCmyka(out nfloat cyan, out nfloat magenta, out nfloat yellow, out nfloat black, out nfloat alpha)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_nfloat_out_nfloat_out_nfloat_out_nfloat_out_nfloat(base.Handle, selGetCyan_Magenta_Yellow_Black_Alpha_Handle, out cyan, out magenta, out yellow, out black, out alpha);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_nfloat_out_nfloat_out_nfloat_out_nfloat_out_nfloat(base.SuperHandle, selGetCyan_Magenta_Yellow_Black_Alpha_Handle, out cyan, out magenta, out yellow, out black, out alpha);
		}
	}

	[Export("colorUsingType:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor? GetColor(NSColorType type)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selColorUsingType_Handle, (long)type));
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selColorUsingType_Handle, (long)type));
	}

	[Export("colorWithName:dynamicProvider:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSColor GetColor(string? colorName, [BlockProxy(typeof(Trampolines.NIDFuncArity2V0))] Func<NSAppearance, NSColor> dynamicProvider)
	{
		if (dynamicProvider == null)
		{
			throw new ArgumentNullException("dynamicProvider");
		}
		IntPtr arg = NSString.CreateNative(colorName);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity2V0.Handler, dynamicProvider);
		NSColor nSObject = Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selColorWithName_DynamicProvider_Handle, arg, (IntPtr)ptr));
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("getHue:saturation:brightness:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetHsba(out nfloat hue, out nfloat saturation, out nfloat brightness, out nfloat alpha)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_nfloat_out_nfloat_out_nfloat_out_nfloat(base.Handle, selGetHue_Saturation_Brightness_Alpha_Handle, out hue, out saturation, out brightness, out alpha);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_nfloat_out_nfloat_out_nfloat_out_nfloat(base.SuperHandle, selGetHue_Saturation_Brightness_Alpha_Handle, out hue, out saturation, out brightness, out alpha);
		}
	}

	[Export("pasteboardPropertyListForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetPasteboardPropertyListForType(string type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteboardPropertyListForType_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPasteboardPropertyListForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("readableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetReadableTypesForPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReadableTypesForPasteboard_Handle, pasteboard.Handle));
	}

	[Export("readingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPasteboardReadingOptions GetReadingOptionsForType(string type, NSPasteboard pasteboard)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardReadingOptions result = (NSPasteboardReadingOptions)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(class_ptr, selReadingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getRed:green:blue:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetRgba(out nfloat red, out nfloat green, out nfloat blue, out nfloat alpha)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_nfloat_out_nfloat_out_nfloat_out_nfloat(base.Handle, selGetRed_Green_Blue_Alpha_Handle, out red, out green, out blue, out alpha);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_nfloat_out_nfloat_out_nfloat_out_nfloat(base.SuperHandle, selGetRed_Green_Blue_Alpha_Handle, out red, out green, out blue, out alpha);
		}
	}

	[Export("getWhite:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetWhiteAlpha(out nfloat white, out nfloat alpha)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_nfloat_out_nfloat(base.Handle, selGetWhite_Alpha_Handle, out white, out alpha);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_nfloat_out_nfloat(base.SuperHandle, selGetWhite_Alpha_Handle, out white, out alpha);
		}
	}

	[Export("writableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetWritableTypesForPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
	}

	[Export("writingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPasteboardWritingOptions GetWritingOptionsForType(string type, NSPasteboard pasteboard)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardWritingOptions result = (NSPasteboardWritingOptions)((!base.IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle) : Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(base.Handle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("highlightWithLevel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor HighlightWithLevel(nfloat highlightLevel)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selHighlightWithLevel_Handle, highlightLevel));
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selHighlightWithLevel_Handle, highlightLevel));
	}

	[Export("xamarinselector:removed:")]
	[Obsolete("It will never be called.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject InitWithPasteboardPropertyList(NSObject propertyList, string type)
	{
		if (propertyList == null)
		{
			throw new ArgumentNullException("propertyList");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("set")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Set()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetHandle);
		}
	}

	[Export("setFill")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFill()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetFillHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetFillHandle);
		}
	}

	[Export("setStroke")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetStroke()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetStrokeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetStrokeHandle);
		}
	}

	[Export("shadowWithLevel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor ShadowWithLevel(nfloat shadowLevel)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selShadowWithLevel_Handle, shadowLevel));
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selShadowWithLevel_Handle, shadowLevel));
	}

	[Export("colorUsingColorSpaceName:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'GetColor' or 'UsingColorSpace' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor UsingColorSpace(string? colorSpaceName)
	{
		IntPtr arg = NSString.CreateNative(colorSpaceName);
		NSColor result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selColorUsingColorSpaceName_Handle, arg)) : Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selColorUsingColorSpaceName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("colorUsingColorSpaceName:device:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'GetColor' or 'UsingColorSpace' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor UsingColorSpace(string? colorSpaceName, NSDictionary? deviceDescription)
	{
		IntPtr arg = NSString.CreateNative(colorSpaceName);
		NSColor result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selColorUsingColorSpaceName_Device_Handle, arg, deviceDescription?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selColorUsingColorSpaceName_Device_Handle, arg, deviceDescription?.Handle ?? IntPtr.Zero)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("colorUsingColorSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor UsingColorSpace(NSColorSpace colorSpace)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selColorUsingColorSpace_Handle, colorSpace.Handle));
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selColorUsingColorSpace_Handle, colorSpace.Handle));
	}

	[Export("writeToPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteToPasteboard(NSPasteboard pasteBoard)
	{
		if (pasteBoard == null)
		{
			throw new ArgumentNullException("pasteBoard");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWriteToPasteboard_Handle, pasteBoard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToPasteboard_Handle, pasteBoard.Handle);
		}
	}

	[Export("colorWithColorSpace:components:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSColor _FromColorSpace(NSColorSpace space, IntPtr components, nint numberOfComponents)
	{
		if (space == null)
		{
			throw new ArgumentNullException("space");
		}
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(class_ptr, selColorWithColorSpace_Components_Count_Handle, space.Handle, components, numberOfComponents));
	}

	[Export("getComponents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _GetComponents(IntPtr components)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetComponents_Handle, components);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetComponents_Handle, components);
		}
	}
}

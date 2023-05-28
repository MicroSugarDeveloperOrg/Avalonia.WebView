using System.ComponentModel;
using CoreGraphics;
using CoreText;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSFont", true)]
public class NSFont : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	public static class Notifications
	{
		public static NSObject ObserveAntialiasThresholdChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AntialiasThresholdChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAntialiasThresholdChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AntialiasThresholdChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveFontSetChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FontSetChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveFontSetChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(FontSetChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdvancementForCGGlyph_ = "advancementForCGGlyph:";

	private static readonly IntPtr selAdvancementForCGGlyph_Handle = Selector.GetHandle("advancementForCGGlyph:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdvancementForGlyph_ = "advancementForGlyph:";

	private static readonly IntPtr selAdvancementForGlyph_Handle = Selector.GetHandle("advancementForGlyph:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAscender = "ascender";

	private static readonly IntPtr selAscenderHandle = Selector.GetHandle("ascender");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoldSystemFontOfSize_ = "boldSystemFontOfSize:";

	private static readonly IntPtr selBoldSystemFontOfSize_Handle = Selector.GetHandle("boldSystemFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingRectForCGGlyph_ = "boundingRectForCGGlyph:";

	private static readonly IntPtr selBoundingRectForCGGlyph_Handle = Selector.GetHandle("boundingRectForCGGlyph:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingRectForFont = "boundingRectForFont";

	private static readonly IntPtr selBoundingRectForFontHandle = Selector.GetHandle("boundingRectForFont");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingRectForGlyph_ = "boundingRectForGlyph:";

	private static readonly IntPtr selBoundingRectForGlyph_Handle = Selector.GetHandle("boundingRectForGlyph:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCapHeight = "capHeight";

	private static readonly IntPtr selCapHeightHandle = Selector.GetHandle("capHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlContentFontOfSize_ = "controlContentFontOfSize:";

	private static readonly IntPtr selControlContentFontOfSize_Handle = Selector.GetHandle("controlContentFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoveredCharacterSet = "coveredCharacterSet";

	private static readonly IntPtr selCoveredCharacterSetHandle = Selector.GetHandle("coveredCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescender = "descender";

	private static readonly IntPtr selDescenderHandle = Selector.GetHandle("descender");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayName = "displayName";

	private static readonly IntPtr selDisplayNameHandle = Selector.GetHandle("displayName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFamilyName = "familyName";

	private static readonly IntPtr selFamilyNameHandle = Selector.GetHandle("familyName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptor = "fontDescriptor";

	private static readonly IntPtr selFontDescriptorHandle = Selector.GetHandle("fontDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontName = "fontName";

	private static readonly IntPtr selFontNameHandle = Selector.GetHandle("fontName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontWithDescriptor_Size_ = "fontWithDescriptor:size:";

	private static readonly IntPtr selFontWithDescriptor_Size_Handle = Selector.GetHandle("fontWithDescriptor:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontWithDescriptor_TextTransform_ = "fontWithDescriptor:textTransform:";

	private static readonly IntPtr selFontWithDescriptor_TextTransform_Handle = Selector.GetHandle("fontWithDescriptor:textTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontWithName_Size_ = "fontWithName:size:";

	private static readonly IntPtr selFontWithName_Size_Handle = Selector.GetHandle("fontWithName:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetAdvancements_ForCGGlyphs_Count_ = "getAdvancements:forCGGlyphs:count:";

	private static readonly IntPtr selGetAdvancements_ForCGGlyphs_Count_Handle = Selector.GetHandle("getAdvancements:forCGGlyphs:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetBoundingRects_ForCGGlyphs_Count_ = "getBoundingRects:forCGGlyphs:count:";

	private static readonly IntPtr selGetBoundingRects_ForCGGlyphs_Count_Handle = Selector.GetHandle("getBoundingRects:forCGGlyphs:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlyphWithName_ = "glyphWithName:";

	private static readonly IntPtr selGlyphWithName_Handle = Selector.GetHandle("glyphWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFixedPitch = "isFixedPitch";

	private static readonly IntPtr selIsFixedPitchHandle = Selector.GetHandle("isFixedPitch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVertical = "isVertical";

	private static readonly IntPtr selIsVerticalHandle = Selector.GetHandle("isVertical");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItalicAngle = "italicAngle";

	private static readonly IntPtr selItalicAngleHandle = Selector.GetHandle("italicAngle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelFontOfSize_ = "labelFontOfSize:";

	private static readonly IntPtr selLabelFontOfSize_Handle = Selector.GetHandle("labelFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelFontSize = "labelFontSize";

	private static readonly IntPtr selLabelFontSizeHandle = Selector.GetHandle("labelFontSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeading = "leading";

	private static readonly IntPtr selLeadingHandle = Selector.GetHandle("leading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumAdvancement = "maximumAdvancement";

	private static readonly IntPtr selMaximumAdvancementHandle = Selector.GetHandle("maximumAdvancement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuBarFontOfSize_ = "menuBarFontOfSize:";

	private static readonly IntPtr selMenuBarFontOfSize_Handle = Selector.GetHandle("menuBarFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuFontOfSize_ = "menuFontOfSize:";

	private static readonly IntPtr selMenuFontOfSize_Handle = Selector.GetHandle("menuFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMessageFontOfSize_ = "messageFontOfSize:";

	private static readonly IntPtr selMessageFontOfSize_Handle = Selector.GetHandle("messageFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMonospacedDigitSystemFontOfSize_Weight_ = "monospacedDigitSystemFontOfSize:weight:";

	private static readonly IntPtr selMonospacedDigitSystemFontOfSize_Weight_Handle = Selector.GetHandle("monospacedDigitSystemFontOfSize:weight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMonospacedSystemFontOfSize_Weight_ = "monospacedSystemFontOfSize:weight:";

	private static readonly IntPtr selMonospacedSystemFontOfSize_Weight_Handle = Selector.GetHandle("monospacedSystemFontOfSize:weight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMostCompatibleStringEncoding = "mostCompatibleStringEncoding";

	private static readonly IntPtr selMostCompatibleStringEncodingHandle = Selector.GetHandle("mostCompatibleStringEncoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfGlyphs = "numberOfGlyphs";

	private static readonly IntPtr selNumberOfGlyphsHandle = Selector.GetHandle("numberOfGlyphs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaletteFontOfSize_ = "paletteFontOfSize:";

	private static readonly IntPtr selPaletteFontOfSize_Handle = Selector.GetHandle("paletteFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointSize = "pointSize";

	private static readonly IntPtr selPointSizeHandle = Selector.GetHandle("pointSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrinterFont = "printerFont";

	private static readonly IntPtr selPrinterFontHandle = Selector.GetHandle("printerFont");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderingMode = "renderingMode";

	private static readonly IntPtr selRenderingModeHandle = Selector.GetHandle("renderingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreenFont = "screenFont";

	private static readonly IntPtr selScreenFontHandle = Selector.GetHandle("screenFont");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreenFontWithRenderingMode_ = "screenFontWithRenderingMode:";

	private static readonly IntPtr selScreenFontWithRenderingMode_Handle = Selector.GetHandle("screenFontWithRenderingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSet = "set";

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInContext_ = "setInContext:";

	private static readonly IntPtr selSetInContext_Handle = Selector.GetHandle("setInContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserFixedPitchFont_ = "setUserFixedPitchFont:";

	private static readonly IntPtr selSetUserFixedPitchFont_Handle = Selector.GetHandle("setUserFixedPitchFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserFont_ = "setUserFont:";

	private static readonly IntPtr selSetUserFont_Handle = Selector.GetHandle("setUserFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSmallSystemFontSize = "smallSystemFontSize";

	private static readonly IntPtr selSmallSystemFontSizeHandle = Selector.GetHandle("smallSystemFontSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemFontOfSize_ = "systemFontOfSize:";

	private static readonly IntPtr selSystemFontOfSize_Handle = Selector.GetHandle("systemFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemFontOfSize_Weight_ = "systemFontOfSize:weight:";

	private static readonly IntPtr selSystemFontOfSize_Weight_Handle = Selector.GetHandle("systemFontOfSize:weight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemFontSize = "systemFontSize";

	private static readonly IntPtr selSystemFontSizeHandle = Selector.GetHandle("systemFontSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemFontSizeForControlSize_ = "systemFontSizeForControlSize:";

	private static readonly IntPtr selSystemFontSizeForControlSize_Handle = Selector.GetHandle("systemFontSizeForControlSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextTransform = "textTransform";

	private static readonly IntPtr selTextTransformHandle = Selector.GetHandle("textTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleBarFontOfSize_ = "titleBarFontOfSize:";

	private static readonly IntPtr selTitleBarFontOfSize_Handle = Selector.GetHandle("titleBarFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolTipsFontOfSize_ = "toolTipsFontOfSize:";

	private static readonly IntPtr selToolTipsFontOfSize_Handle = Selector.GetHandle("toolTipsFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnderlinePosition = "underlinePosition";

	private static readonly IntPtr selUnderlinePositionHandle = Selector.GetHandle("underlinePosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnderlineThickness = "underlineThickness";

	private static readonly IntPtr selUnderlineThicknessHandle = Selector.GetHandle("underlineThickness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserFixedPitchFontOfSize_ = "userFixedPitchFontOfSize:";

	private static readonly IntPtr selUserFixedPitchFontOfSize_Handle = Selector.GetHandle("userFixedPitchFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserFontOfSize_ = "userFontOfSize:";

	private static readonly IntPtr selUserFontOfSize_Handle = Selector.GetHandle("userFontOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalFont = "verticalFont";

	private static readonly IntPtr selVerticalFontHandle = Selector.GetHandle("verticalFont");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXHeight = "xHeight";

	private static readonly IntPtr selXHeightHandle = Selector.GetHandle("xHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFont");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AntialiasThresholdChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CascadeListAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CharacterSetAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FaceAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FamilyAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FeatureSelectorIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FeatureSettingsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FeatureTypeIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FixedAdvanceAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FontSetChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MatrixAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SizeAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SlantTrait;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SymbolicTrait;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TraitsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VariationAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VariationAxisDefaultValueKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VariationAxisIdentifierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VariationAxisMaximumValueKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VariationAxisMinimumValueKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VariationAxisNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VisibleNameAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WeightTrait;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WidthTrait;

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	public virtual NSFont PrinterFont
	{
		get
		{
			IntPtr printerFont = _PrinterFont;
			return (printerFont == IntPtr.Zero) ? null : new NSFont(printerFont);
		}
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	public virtual NSFont ScreenFont
	{
		get
		{
			IntPtr screenFont = _ScreenFont;
			return (screenFont == IntPtr.Zero) ? null : new NSFont(screenFont);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Ascender
	{
		[Export("ascender")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAscenderHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAscenderHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect BoundingRectForFont
	{
		[Export("boundingRectForFont")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBoundingRectForFontHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundingRectForFontHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat CapHeight
	{
		[Export("capHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selCapHeightHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selCapHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCharacterSet CoveredCharacterSet
	{
		[Export("coveredCharacterSet")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selCoveredCharacterSetHandle));
			}
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCoveredCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Descender
	{
		[Export("descender")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selDescenderHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDescenderHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DisplayName
	{
		[Export("displayName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FamilyName
	{
		[Export("familyName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFamilyNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFamilyNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor FontDescriptor
	{
		[Export("fontDescriptor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selFontDescriptorHandle));
			}
			return Runtime.GetNSObject<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontDescriptorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FontName
	{
		[Export("fontName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFontNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GlyphCount
	{
		[Export("numberOfGlyphs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfGlyphsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfGlyphsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFixedPitch
	{
		[Export("isFixedPitch")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFixedPitchHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFixedPitchHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsVertical
	{
		[Export("isVertical")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVerticalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVerticalHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ItalicAngle
	{
		[Export("italicAngle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selItalicAngleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selItalicAngleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat LabelFontSize
	{
		[Export("labelFontSize")]
		get
		{
			return Messaging.nfloat_objc_msgSend(class_ptr, selLabelFontSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Leading
	{
		[Export("leading")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLeadingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLeadingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MaximumAdvancement
	{
		[Export("maximumAdvancement")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaximumAdvancementHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaximumAdvancementHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSStringEncoding MostCompatibleStringEncoding
	{
		[Export("mostCompatibleStringEncoding")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSStringEncoding)Messaging.UInt64_objc_msgSend(base.Handle, selMostCompatibleStringEncodingHandle);
			}
			return (NSStringEncoding)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMostCompatibleStringEncodingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat PointSize
	{
		[Export("pointSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selPointSizeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selPointSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	public virtual NSFontRenderingMode RenderingMode
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Export("renderingMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSFontRenderingMode)Messaging.UInt64_objc_msgSend(base.Handle, selRenderingModeHandle);
			}
			return (NSFontRenderingMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRenderingModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat SmallSystemFontSize
	{
		[Export("smallSystemFontSize")]
		get
		{
			return Messaging.nfloat_objc_msgSend(class_ptr, selSmallSystemFontSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat SystemFontSize
	{
		[Export("systemFontSize")]
		get
		{
			return Messaging.nfloat_objc_msgSend(class_ptr, selSystemFontSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAffineTransform TextTransform
	{
		[Export("textTransform")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAffineTransform>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextTransformHandle));
			}
			return Runtime.GetNSObject<NSAffineTransform>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextTransformHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat UnderlinePosition
	{
		[Export("underlinePosition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selUnderlinePositionHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selUnderlinePositionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat UnderlineThickness
	{
		[Export("underlineThickness")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selUnderlineThicknessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selUnderlineThicknessHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat XHeight
	{
		[Export("xHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selXHeightHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selXHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	internal virtual IntPtr _PrinterFont
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Export("printerFont")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selPrinterFontHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrinterFontHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	internal virtual IntPtr _ScreenFont
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
		[Export("screenFont")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selScreenFontHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScreenFontHandle);
		}
	}

	[Field("NSAntialiasThresholdChangedNotification", "AppKit")]
	[Advice("Use NSFont.Notifications.ObserveAntialiasThresholdChanged helper method instead.")]
	public static NSString AntialiasThresholdChangedNotification
	{
		get
		{
			if (_AntialiasThresholdChangedNotification == null)
			{
				_AntialiasThresholdChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAntialiasThresholdChangedNotification");
			}
			return _AntialiasThresholdChangedNotification;
		}
	}

	[Field("NSFontCascadeListAttribute", "AppKit")]
	public static NSString CascadeListAttribute
	{
		get
		{
			if (_CascadeListAttribute == null)
			{
				_CascadeListAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCascadeListAttribute");
			}
			return _CascadeListAttribute;
		}
	}

	[Field("NSFontCharacterSetAttribute", "AppKit")]
	public static NSString CharacterSetAttribute
	{
		get
		{
			if (_CharacterSetAttribute == null)
			{
				_CharacterSetAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCharacterSetAttribute");
			}
			return _CharacterSetAttribute;
		}
	}

	[Field("NSFontFaceAttribute", "AppKit")]
	public static NSString FaceAttribute
	{
		get
		{
			if (_FaceAttribute == null)
			{
				_FaceAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontFaceAttribute");
			}
			return _FaceAttribute;
		}
	}

	[Field("NSFontFamilyAttribute", "AppKit")]
	public static NSString FamilyAttribute
	{
		get
		{
			if (_FamilyAttribute == null)
			{
				_FamilyAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontFamilyAttribute");
			}
			return _FamilyAttribute;
		}
	}

	[Field("NSFontFeatureSelectorIdentifierKey", "AppKit")]
	public static NSString FeatureSelectorIdentifierKey
	{
		get
		{
			if (_FeatureSelectorIdentifierKey == null)
			{
				_FeatureSelectorIdentifierKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontFeatureSelectorIdentifierKey");
			}
			return _FeatureSelectorIdentifierKey;
		}
	}

	[Field("NSFontFeatureSettingsAttribute", "AppKit")]
	public static NSString FeatureSettingsAttribute
	{
		get
		{
			if (_FeatureSettingsAttribute == null)
			{
				_FeatureSettingsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontFeatureSettingsAttribute");
			}
			return _FeatureSettingsAttribute;
		}
	}

	[Field("NSFontFeatureTypeIdentifierKey", "AppKit")]
	public static NSString FeatureTypeIdentifierKey
	{
		get
		{
			if (_FeatureTypeIdentifierKey == null)
			{
				_FeatureTypeIdentifierKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontFeatureTypeIdentifierKey");
			}
			return _FeatureTypeIdentifierKey;
		}
	}

	[Field("NSFontFixedAdvanceAttribute", "AppKit")]
	public static NSString FixedAdvanceAttribute
	{
		get
		{
			if (_FixedAdvanceAttribute == null)
			{
				_FixedAdvanceAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontFixedAdvanceAttribute");
			}
			return _FixedAdvanceAttribute;
		}
	}

	[Field("NSFontSetChangedNotification", "AppKit")]
	[Advice("Use NSFont.Notifications.ObserveFontSetChanged helper method instead.")]
	public static NSString FontSetChangedNotification
	{
		get
		{
			if (_FontSetChangedNotification == null)
			{
				_FontSetChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontSetChangedNotification");
			}
			return _FontSetChangedNotification;
		}
	}

	[Field("NSFontMatrixAttribute", "AppKit")]
	public static NSString MatrixAttribute
	{
		get
		{
			if (_MatrixAttribute == null)
			{
				_MatrixAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontMatrixAttribute");
			}
			return _MatrixAttribute;
		}
	}

	[Field("NSFontNameAttribute", "AppKit")]
	public static NSString NameAttribute
	{
		get
		{
			if (_NameAttribute == null)
			{
				_NameAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontNameAttribute");
			}
			return _NameAttribute;
		}
	}

	[Field("NSFontSizeAttribute", "AppKit")]
	public static NSString SizeAttribute
	{
		get
		{
			if (_SizeAttribute == null)
			{
				_SizeAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontSizeAttribute");
			}
			return _SizeAttribute;
		}
	}

	[Field("NSFontSlantTrait", "AppKit")]
	public static NSString SlantTrait
	{
		get
		{
			if (_SlantTrait == null)
			{
				_SlantTrait = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontSlantTrait");
			}
			return _SlantTrait;
		}
	}

	[Field("NSFontSymbolicTrait", "AppKit")]
	public static NSString SymbolicTrait
	{
		get
		{
			if (_SymbolicTrait == null)
			{
				_SymbolicTrait = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontSymbolicTrait");
			}
			return _SymbolicTrait;
		}
	}

	[Field("NSFontTraitsAttribute", "AppKit")]
	public static NSString TraitsAttribute
	{
		get
		{
			if (_TraitsAttribute == null)
			{
				_TraitsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontTraitsAttribute");
			}
			return _TraitsAttribute;
		}
	}

	[Field("NSFontVariationAttribute", "AppKit")]
	public static NSString VariationAttribute
	{
		get
		{
			if (_VariationAttribute == null)
			{
				_VariationAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontVariationAttribute");
			}
			return _VariationAttribute;
		}
	}

	[Field("NSFontVariationAxisDefaultValueKey", "AppKit")]
	public static NSString VariationAxisDefaultValueKey
	{
		get
		{
			if (_VariationAxisDefaultValueKey == null)
			{
				_VariationAxisDefaultValueKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontVariationAxisDefaultValueKey");
			}
			return _VariationAxisDefaultValueKey;
		}
	}

	[Field("NSFontVariationAxisIdentifierKey", "AppKit")]
	public static NSString VariationAxisIdentifierKey
	{
		get
		{
			if (_VariationAxisIdentifierKey == null)
			{
				_VariationAxisIdentifierKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontVariationAxisIdentifierKey");
			}
			return _VariationAxisIdentifierKey;
		}
	}

	[Field("NSFontVariationAxisMaximumValueKey", "AppKit")]
	public static NSString VariationAxisMaximumValueKey
	{
		get
		{
			if (_VariationAxisMaximumValueKey == null)
			{
				_VariationAxisMaximumValueKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontVariationAxisMaximumValueKey");
			}
			return _VariationAxisMaximumValueKey;
		}
	}

	[Field("NSFontVariationAxisMinimumValueKey", "AppKit")]
	public static NSString VariationAxisMinimumValueKey
	{
		get
		{
			if (_VariationAxisMinimumValueKey == null)
			{
				_VariationAxisMinimumValueKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontVariationAxisMinimumValueKey");
			}
			return _VariationAxisMinimumValueKey;
		}
	}

	[Field("NSFontVariationAxisNameKey", "AppKit")]
	public static NSString VariationAxisNameKey
	{
		get
		{
			if (_VariationAxisNameKey == null)
			{
				_VariationAxisNameKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontVariationAxisNameKey");
			}
			return _VariationAxisNameKey;
		}
	}

	[Field("NSFontVisibleNameAttribute", "AppKit")]
	public static NSString VisibleNameAttribute
	{
		get
		{
			if (_VisibleNameAttribute == null)
			{
				_VisibleNameAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontVisibleNameAttribute");
			}
			return _VisibleNameAttribute;
		}
	}

	[Field("NSFontWeightTrait", "AppKit")]
	public static NSString WeightTrait
	{
		get
		{
			if (_WeightTrait == null)
			{
				_WeightTrait = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontWeightTrait");
			}
			return _WeightTrait;
		}
	}

	[Field("NSFontWidthTrait", "AppKit")]
	public static NSString WidthTrait
	{
		get
		{
			if (_WidthTrait == null)
			{
				_WidthTrait = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontWidthTrait");
			}
			return _WidthTrait;
		}
	}

	public static NSFont FromCTFont(CTFont font)
	{
		if (font == null)
		{
			return null;
		}
		return new NSFont(font.Handle);
	}

	[Mac(10, 13)]
	public unsafe CGRect[] GetBoundingRects(ushort[] glyphs)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		if (glyphs.Length < 1)
		{
			throw new ArgumentException("glyphs array is empty");
		}
		CGRect[] array = new CGRect[glyphs.Length];
		fixed (CGRect* ptr = &array[0])
		{
			fixed (ushort* ptr2 = &glyphs[0])
			{
				_GetBoundingRects((IntPtr)ptr, (IntPtr)ptr2, (nuint)glyphs.Length);
			}
		}
		return array;
	}

	[Mac(10, 13)]
	public unsafe CGSize[] GetAdvancements(ushort[] glyphs)
	{
		if (glyphs == null)
		{
			throw new ArgumentNullException("glyphs");
		}
		if (glyphs.Length < 1)
		{
			throw new ArgumentException("glyphs array is empty");
		}
		CGSize[] array = new CGSize[glyphs.Length];
		fixed (CGSize* ptr = &array[0])
		{
			fixed (ushort* ptr2 = &glyphs[0])
			{
				_GetAdvancements((IntPtr)ptr, (IntPtr)ptr2, (nuint)glyphs.Length);
			}
		}
		return array;
	}

	public static NSFont FromFontName(string fontName, nfloat fontSize)
	{
		IntPtr intPtr = _FromFontName(fontName, fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont FromDescription(NSFontDescriptor fontDescriptor, nfloat fontSize)
	{
		IntPtr intPtr = _FromDescription(fontDescriptor, fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont FromDescription(NSFontDescriptor fontDescriptor, NSAffineTransform textTransform)
	{
		IntPtr intPtr = _FromDescription(fontDescriptor, textTransform);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont UserFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _UserFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont UserFixedPitchFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _UserFixedPitchFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont SystemFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _SystemFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont BoldSystemFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _BoldSystemFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont LabelFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _LabelFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont TitleBarFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _TitleBarFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont MenuFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _MenuFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont MenuBarFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _MenuBarFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont MessageFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _MessageFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont PaletteFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _PaletteFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont ToolTipsFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _ToolTipsFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public static NSFont ControlContentFontOfSize(nfloat fontSize)
	{
		IntPtr intPtr = _ControlContentFontOfSize(fontSize);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	public virtual NSFont ScreenFontWithRenderingMode(NSFontRenderingMode renderingMode)
	{
		IntPtr intPtr = _ScreenFontWithRenderingMode(renderingMode);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	public virtual NSFont GetVerticalFont()
	{
		IntPtr intPtr = _GetVerticalFont();
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	[Mac(10, 11)]
	public static NSFont SystemFontOfSize(nfloat fontSize, nfloat weight)
	{
		IntPtr intPtr = _SystemFontOfSize(fontSize, weight);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	[Mac(10, 11)]
	public static NSFont MonospacedDigitSystemFontOfSize(nfloat fontSize, nfloat weight)
	{
		IntPtr intPtr = _MonospacedDigitSystemFontOfSize(fontSize, weight);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	[Mac(10, 15)]
	public static NSFont MonospacedSystemFont(nfloat fontSize, nfloat weight)
	{
		IntPtr intPtr = _MonospacedSystemFont(fontSize, weight);
		return (intPtr == IntPtr.Zero) ? null : new NSFont(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFont(NSCoder coder)
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
	protected NSFont(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFont(IntPtr handle)
		: base(handle)
	{
	}

	[Export("advancementForGlyph:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use the 'CGGlyph' APIs instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize AdvancementForGlyph(uint aGlyph)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_UInt32(base.Handle, selAdvancementForGlyph_Handle, aGlyph);
		}
		return Messaging.CGSize_objc_msgSendSuper_UInt32(base.SuperHandle, selAdvancementForGlyph_Handle, aGlyph);
	}

	[Export("boundingRectForGlyph:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use the 'CGGlyph' APIs instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect BoundingRectForGlyph(uint aGlyph)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_UInt32(out retval, base.Handle, selBoundingRectForGlyph_Handle, aGlyph);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_UInt32(out retval, base.SuperHandle, selBoundingRectForGlyph_Handle, aGlyph);
		}
		return retval;
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

	[Export("advancementForCGGlyph:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize GetAdvancement(ushort glyph)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_UInt16(base.Handle, selAdvancementForCGGlyph_Handle, glyph);
		}
		return Messaging.CGSize_objc_msgSendSuper_UInt16(base.SuperHandle, selAdvancementForCGGlyph_Handle, glyph);
	}

	[Export("boundingRectForCGGlyph:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetBoundingRect(ushort glyph)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_UInt16(out retval, base.Handle, selBoundingRectForCGGlyph_Handle, glyph);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_UInt16(out retval, base.SuperHandle, selBoundingRectForCGGlyph_Handle, glyph);
		}
		return retval;
	}

	[Export("glyphWithName:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use the 'CGGlyph' APIs instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint GlyphWithName(string aName)
	{
		if (aName == null)
		{
			throw new ArgumentNullException("aName");
		}
		IntPtr arg = NSString.CreateNative(aName);
		uint result = ((!base.IsDirectBinding) ? Messaging.UInt32_objc_msgSendSuper_IntPtr(base.SuperHandle, selGlyphWithName_Handle, arg) : Messaging.UInt32_objc_msgSend_IntPtr(base.Handle, selGlyphWithName_Handle, arg));
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

	[Export("setInContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetInContext(NSGraphicsContext graphicsContext)
	{
		if (graphicsContext == null)
		{
			throw new ArgumentNullException("graphicsContext");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInContext_Handle, graphicsContext.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInContext_Handle, graphicsContext.Handle);
		}
	}

	[Export("setUserFixedPitchFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetUserFixedPitchFont(NSFont? aFont)
	{
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetUserFixedPitchFont_Handle, aFont?.Handle ?? IntPtr.Zero);
	}

	[Export("setUserFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetUserFont(NSFont? aFont)
	{
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetUserFont_Handle, aFont?.Handle ?? IntPtr.Zero);
	}

	[Export("systemFontSizeForControlSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat SystemFontSizeForControlSize(NSControlSize controlSize)
	{
		return Messaging.nfloat_objc_msgSend_UInt64(class_ptr, selSystemFontSizeForControlSize_Handle, (ulong)controlSize);
	}

	[Export("boldSystemFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _BoldSystemFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selBoldSystemFontOfSize_Handle, fontSize);
	}

	[Export("controlContentFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _ControlContentFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selControlContentFontOfSize_Handle, fontSize);
	}

	[Export("fontWithDescriptor:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _FromDescription(NSFontDescriptor fontDescriptor, nfloat fontSize)
	{
		if (fontDescriptor == null)
		{
			throw new ArgumentNullException("fontDescriptor");
		}
		return Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(class_ptr, selFontWithDescriptor_Size_Handle, fontDescriptor.Handle, fontSize);
	}

	[Export("fontWithDescriptor:textTransform:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _FromDescription(NSFontDescriptor fontDescriptor, NSAffineTransform? textTransform)
	{
		if (fontDescriptor == null)
		{
			throw new ArgumentNullException("fontDescriptor");
		}
		return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFontWithDescriptor_TextTransform_Handle, fontDescriptor.Handle, textTransform?.Handle ?? IntPtr.Zero);
	}

	[Export("fontWithName:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _FromFontName(string fontName, nfloat fontSize)
	{
		if (fontName == null)
		{
			throw new ArgumentNullException("fontName");
		}
		IntPtr arg = NSString.CreateNative(fontName);
		IntPtr result = Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(class_ptr, selFontWithName_Size_Handle, arg, fontSize);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getAdvancements:forCGGlyphs:count:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _GetAdvancements(IntPtr advancements, IntPtr glyphs, nuint glyphCount)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selGetAdvancements_ForCGGlyphs_Count_Handle, advancements, glyphs, glyphCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selGetAdvancements_ForCGGlyphs_Count_Handle, advancements, glyphs, glyphCount);
		}
	}

	[Export("getBoundingRects:forCGGlyphs:count:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _GetBoundingRects(IntPtr bounds, IntPtr glyphs, nuint glyphCount)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selGetBoundingRects_ForCGGlyphs_Count_Handle, bounds, glyphs, glyphCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selGetBoundingRects_ForCGGlyphs_Count_Handle, bounds, glyphs, glyphCount);
		}
	}

	[Export("verticalFont")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _GetVerticalFont()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selVerticalFontHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVerticalFontHandle);
	}

	[Export("labelFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _LabelFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selLabelFontOfSize_Handle, fontSize);
	}

	[Export("menuBarFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _MenuBarFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selMenuBarFontOfSize_Handle, fontSize);
	}

	[Export("menuFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _MenuFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selMenuFontOfSize_Handle, fontSize);
	}

	[Export("messageFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _MessageFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selMessageFontOfSize_Handle, fontSize);
	}

	[Export("monospacedDigitSystemFontOfSize:weight:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _MonospacedDigitSystemFontOfSize(nfloat fontSize, nfloat weight)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selMonospacedDigitSystemFontOfSize_Weight_Handle, fontSize, weight);
	}

	[Export("monospacedSystemFontOfSize:weight:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _MonospacedSystemFont(nfloat fontSize, nfloat weight)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selMonospacedSystemFontOfSize_Weight_Handle, fontSize, weight);
	}

	[Export("paletteFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _PaletteFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selPaletteFontOfSize_Handle, fontSize);
	}

	[Export("screenFontWithRenderingMode:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _ScreenFontWithRenderingMode(NSFontRenderingMode renderingMode)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selScreenFontWithRenderingMode_Handle, (ulong)renderingMode);
		}
		return Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selScreenFontWithRenderingMode_Handle, (ulong)renderingMode);
	}

	[Export("systemFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _SystemFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selSystemFontOfSize_Handle, fontSize);
	}

	[Export("systemFontOfSize:weight:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _SystemFontOfSize(nfloat fontSize, nfloat weight)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selSystemFontOfSize_Weight_Handle, fontSize, weight);
	}

	[Export("titleBarFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _TitleBarFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selTitleBarFontOfSize_Handle, fontSize);
	}

	[Export("toolTipsFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _ToolTipsFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selToolTipsFontOfSize_Handle, fontSize);
	}

	[Export("userFixedPitchFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _UserFixedPitchFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selUserFixedPitchFontOfSize_Handle, fontSize);
	}

	[Export("userFontOfSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr _UserFontOfSize(nfloat fontSize)
	{
		return Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selUserFontOfSize_Handle, fontSize);
	}
}

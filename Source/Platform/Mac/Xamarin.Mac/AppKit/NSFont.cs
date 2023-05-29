using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSFont", true)]
public class NSFont : NSObject
{
	private static readonly IntPtr selSystemFontSizeHandle = Selector.GetHandle("systemFontSize");

	private static readonly IntPtr selSmallSystemFontSizeHandle = Selector.GetHandle("smallSystemFontSize");

	private static readonly IntPtr selLabelFontSizeHandle = Selector.GetHandle("labelFontSize");

	private static readonly IntPtr selFontNameHandle = Selector.GetHandle("fontName");

	private static readonly IntPtr selPointSizeHandle = Selector.GetHandle("pointSize");

	private static readonly IntPtr selFamilyNameHandle = Selector.GetHandle("familyName");

	private static readonly IntPtr selDisplayNameHandle = Selector.GetHandle("displayName");

	private static readonly IntPtr selFontDescriptorHandle = Selector.GetHandle("fontDescriptor");

	private static readonly IntPtr selTextTransformHandle = Selector.GetHandle("textTransform");

	private static readonly IntPtr selNumberOfGlyphsHandle = Selector.GetHandle("numberOfGlyphs");

	private static readonly IntPtr selMostCompatibleStringEncodingHandle = Selector.GetHandle("mostCompatibleStringEncoding");

	private static readonly IntPtr selCoveredCharacterSetHandle = Selector.GetHandle("coveredCharacterSet");

	private static readonly IntPtr selBoundingRectForFontHandle = Selector.GetHandle("boundingRectForFont");

	private static readonly IntPtr selMaximumAdvancementHandle = Selector.GetHandle("maximumAdvancement");

	private static readonly IntPtr selAscenderHandle = Selector.GetHandle("ascender");

	private static readonly IntPtr selDescenderHandle = Selector.GetHandle("descender");

	private static readonly IntPtr selLeadingHandle = Selector.GetHandle("leading");

	private static readonly IntPtr selUnderlinePositionHandle = Selector.GetHandle("underlinePosition");

	private static readonly IntPtr selUnderlineThicknessHandle = Selector.GetHandle("underlineThickness");

	private static readonly IntPtr selItalicAngleHandle = Selector.GetHandle("italicAngle");

	private static readonly IntPtr selCapHeightHandle = Selector.GetHandle("capHeight");

	private static readonly IntPtr selXHeightHandle = Selector.GetHandle("xHeight");

	private static readonly IntPtr selIsFixedPitchHandle = Selector.GetHandle("isFixedPitch");

	private static readonly IntPtr selPrinterFontHandle = Selector.GetHandle("printerFont");

	private static readonly IntPtr selScreenFontHandle = Selector.GetHandle("screenFont");

	private static readonly IntPtr selRenderingModeHandle = Selector.GetHandle("renderingMode");

	private static readonly IntPtr selIsVerticalHandle = Selector.GetHandle("isVertical");

	private static readonly IntPtr selFontWithNameSize_Handle = Selector.GetHandle("fontWithName:size:");

	private static readonly IntPtr selFontWithDescriptorSize_Handle = Selector.GetHandle("fontWithDescriptor:size:");

	private static readonly IntPtr selFontWithDescriptorTextTransform_Handle = Selector.GetHandle("fontWithDescriptor:textTransform:");

	private static readonly IntPtr selUserFontOfSize_Handle = Selector.GetHandle("userFontOfSize:");

	private static readonly IntPtr selUserFixedPitchFontOfSize_Handle = Selector.GetHandle("userFixedPitchFontOfSize:");

	private static readonly IntPtr selSetUserFont_Handle = Selector.GetHandle("setUserFont:");

	private static readonly IntPtr selSetUserFixedPitchFont_Handle = Selector.GetHandle("setUserFixedPitchFont:");

	private static readonly IntPtr selSystemFontOfSize_Handle = Selector.GetHandle("systemFontOfSize:");

	private static readonly IntPtr selBoldSystemFontOfSize_Handle = Selector.GetHandle("boldSystemFontOfSize:");

	private static readonly IntPtr selLabelFontOfSize_Handle = Selector.GetHandle("labelFontOfSize:");

	private static readonly IntPtr selTitleBarFontOfSize_Handle = Selector.GetHandle("titleBarFontOfSize:");

	private static readonly IntPtr selMenuFontOfSize_Handle = Selector.GetHandle("menuFontOfSize:");

	private static readonly IntPtr selMenuBarFontOfSize_Handle = Selector.GetHandle("menuBarFontOfSize:");

	private static readonly IntPtr selMessageFontOfSize_Handle = Selector.GetHandle("messageFontOfSize:");

	private static readonly IntPtr selPaletteFontOfSize_Handle = Selector.GetHandle("paletteFontOfSize:");

	private static readonly IntPtr selToolTipsFontOfSize_Handle = Selector.GetHandle("toolTipsFontOfSize:");

	private static readonly IntPtr selControlContentFontOfSize_Handle = Selector.GetHandle("controlContentFontOfSize:");

	private static readonly IntPtr selSystemFontSizeForControlSize_Handle = Selector.GetHandle("systemFontSizeForControlSize:");

	private static readonly IntPtr selGlyphWithName_Handle = Selector.GetHandle("glyphWithName:");

	private static readonly IntPtr selBoundingRectForGlyph_Handle = Selector.GetHandle("boundingRectForGlyph:");

	private static readonly IntPtr selAdvancementForGlyph_Handle = Selector.GetHandle("advancementForGlyph:");

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	private static readonly IntPtr selSetInContext_Handle = Selector.GetHandle("setInContext:");

	private static readonly IntPtr selScreenFontWithRenderingMode_Handle = Selector.GetHandle("screenFontWithRenderingMode:");

	private static readonly IntPtr selVerticalFontHandle = Selector.GetHandle("verticalFont");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFont");

	private object __mt_FontDescriptor_var;

	private object __mt_TextTransform_var;

	private object __mt_CoveredCharacterSet_var;

	private object __mt_PrinterFont_var;

	private object __mt_ScreenFont_var;

	public override IntPtr ClassHandle => class_ptr;

	public static double SystemFontSize
	{
		[Export("systemFontSize")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selSystemFontSizeHandle);
		}
	}

	public static double SmallSystemFontSize
	{
		[Export("smallSystemFontSize")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selSmallSystemFontSizeHandle);
		}
	}

	public static double LabelFontSize
	{
		[Export("labelFontSize")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selLabelFontSizeHandle);
		}
	}

	public virtual string FontName
	{
		[Export("fontName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFontNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontNameHandle));
		}
	}

	public virtual double PointSize
	{
		[Export("pointSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPointSizeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPointSizeHandle);
		}
	}

	public virtual string FamilyName
	{
		[Export("familyName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFamilyNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFamilyNameHandle));
		}
	}

	public virtual string DisplayName
	{
		[Export("displayName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayNameHandle));
		}
	}

	public virtual NSFontDescriptor FontDescriptor
	{
		[Export("fontDescriptor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFontDescriptor)(__mt_FontDescriptor_var = ((!IsDirectBinding) ? ((NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontDescriptorHandle))) : ((NSFontDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFontDescriptorHandle)))));
		}
	}

	public virtual NSAffineTransform TextTransform
	{
		[Export("textTransform")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAffineTransform)(__mt_TextTransform_var = ((!IsDirectBinding) ? ((NSAffineTransform)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextTransformHandle))) : ((NSAffineTransform)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextTransformHandle)))));
		}
	}

	public virtual ulong GlyphCount
	{
		[Export("numberOfGlyphs")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selNumberOfGlyphsHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selNumberOfGlyphsHandle);
		}
	}

	public virtual NSStringEncoding MostCompatibleStringEncoding
	{
		[Export("mostCompatibleStringEncoding")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSStringEncoding)Messaging.UInt32_objc_msgSend(base.Handle, selMostCompatibleStringEncodingHandle);
			}
			return (NSStringEncoding)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selMostCompatibleStringEncodingHandle);
		}
	}

	public virtual NSCharacterSet CoveredCharacterSet
	{
		[Export("coveredCharacterSet")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCharacterSet)(__mt_CoveredCharacterSet_var = ((!IsDirectBinding) ? ((NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCoveredCharacterSetHandle))) : ((NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCoveredCharacterSetHandle)))));
		}
	}

	public virtual CGRect BoundingRectForFont
	{
		[Export("boundingRectForFont")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual CGSize MaximumAdvancement
	{
		[Export("maximumAdvancement")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaximumAdvancementHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaximumAdvancementHandle);
		}
	}

	public virtual double Ascender
	{
		[Export("ascender")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAscenderHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAscenderHandle);
		}
	}

	public virtual double Descender
	{
		[Export("descender")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDescenderHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDescenderHandle);
		}
	}

	public virtual double Leading
	{
		[Export("leading")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLeadingHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLeadingHandle);
		}
	}

	public virtual double UnderlinePosition
	{
		[Export("underlinePosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selUnderlinePositionHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selUnderlinePositionHandle);
		}
	}

	public virtual double UnderlineThickness
	{
		[Export("underlineThickness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selUnderlineThicknessHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selUnderlineThicknessHandle);
		}
	}

	public virtual double ItalicAngle
	{
		[Export("italicAngle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selItalicAngleHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selItalicAngleHandle);
		}
	}

	public virtual double CapHeight
	{
		[Export("capHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCapHeightHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCapHeightHandle);
		}
	}

	public virtual double XHeight
	{
		[Export("xHeight")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selXHeightHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selXHeightHandle);
		}
	}

	public virtual bool IsFixedPitch
	{
		[Export("isFixedPitch")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFixedPitchHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFixedPitchHandle);
		}
	}

	public virtual NSFont PrinterFont
	{
		[Export("printerFont")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFont)(__mt_PrinterFont_var = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrinterFontHandle))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPrinterFontHandle)))));
		}
	}

	public virtual NSFont ScreenFont
	{
		[Export("screenFont")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFont)(__mt_ScreenFont_var = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScreenFontHandle))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selScreenFontHandle)))));
		}
	}

	public virtual NSFontRenderingMode RenderingMode
	{
		[Export("renderingMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSFontRenderingMode)Messaging.UInt64_objc_msgSend(base.Handle, selRenderingModeHandle);
			}
			return (NSFontRenderingMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRenderingModeHandle);
		}
	}

	public virtual bool IsVertical
	{
		[Export("isVertical")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVerticalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVerticalHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFont(NSCoder coder)
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
	public NSFont(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFont(IntPtr handle)
		: base(handle)
	{
	}

	[Export("fontWithName:size:")]
	public static NSFont FromFontName(string fontName, double fontSize)
	{
		NSApplication.EnsureUIThread();
		if (fontName == null)
		{
			throw new ArgumentNullException("fontName");
		}
		IntPtr arg = NSString.CreateNative(fontName);
		NSFont result = (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selFontWithNameSize_Handle, arg, fontSize));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fontWithDescriptor:size:")]
	public static NSFont FromDescription(NSFontDescriptor fontDescriptor, double fontSize)
	{
		NSApplication.EnsureUIThread();
		if (fontDescriptor == null)
		{
			throw new ArgumentNullException("fontDescriptor");
		}
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selFontWithDescriptorSize_Handle, fontDescriptor.Handle, fontSize));
	}

	[Export("fontWithDescriptor:textTransform:")]
	public static NSFont FromDescription(NSFontDescriptor fontDescriptor, NSAffineTransform textTransform)
	{
		NSApplication.EnsureUIThread();
		if (fontDescriptor == null)
		{
			throw new ArgumentNullException("fontDescriptor");
		}
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFontWithDescriptorTextTransform_Handle, fontDescriptor.Handle, textTransform?.Handle ?? IntPtr.Zero));
	}

	[Export("userFontOfSize:")]
	public static NSFont UserFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selUserFontOfSize_Handle, fontSize));
	}

	[Export("userFixedPitchFontOfSize:")]
	public static NSFont UserFixedPitchFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selUserFixedPitchFontOfSize_Handle, fontSize));
	}

	[Export("setUserFont:")]
	public static void SetUserFont(NSFont aFont)
	{
		NSApplication.EnsureUIThread();
		if (aFont == null)
		{
			throw new ArgumentNullException("aFont");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetUserFont_Handle, aFont.Handle);
	}

	[Export("setUserFixedPitchFont:")]
	public static void SetUserFixedPitchFont(NSFont aFont)
	{
		NSApplication.EnsureUIThread();
		if (aFont == null)
		{
			throw new ArgumentNullException("aFont");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetUserFixedPitchFont_Handle, aFont.Handle);
	}

	[Export("systemFontOfSize:")]
	public static NSFont SystemFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selSystemFontOfSize_Handle, fontSize));
	}

	[Export("boldSystemFontOfSize:")]
	public static NSFont BoldSystemFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selBoldSystemFontOfSize_Handle, fontSize));
	}

	[Export("labelFontOfSize:")]
	public static NSFont LabelFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selLabelFontOfSize_Handle, fontSize));
	}

	[Export("titleBarFontOfSize:")]
	public static NSFont TitleBarFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selTitleBarFontOfSize_Handle, fontSize));
	}

	[Export("menuFontOfSize:")]
	public static NSFont MenuFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selMenuFontOfSize_Handle, fontSize));
	}

	[Export("menuBarFontOfSize:")]
	public static NSFont MenuBarFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selMenuBarFontOfSize_Handle, fontSize));
	}

	[Export("messageFontOfSize:")]
	public static NSFont MessageFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selMessageFontOfSize_Handle, fontSize));
	}

	[Export("paletteFontOfSize:")]
	public static NSFont PaletteFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selPaletteFontOfSize_Handle, fontSize));
	}

	[Export("toolTipsFontOfSize:")]
	public static NSFont ToolTipsFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selToolTipsFontOfSize_Handle, fontSize));
	}

	[Export("controlContentFontOfSize:")]
	public static NSFont ControlContentFontOfSize(double fontSize)
	{
		NSApplication.EnsureUIThread();
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selControlContentFontOfSize_Handle, fontSize));
	}

	[Export("systemFontSizeForControlSize:")]
	public static double SystemFontSizeForControlSize(NSControlSize controlSize)
	{
		NSApplication.EnsureUIThread();
		return Messaging.Double_objc_msgSend_UInt64(class_ptr, selSystemFontSizeForControlSize_Handle, (ulong)controlSize);
	}

	[Export("glyphWithName:")]
	public virtual uint GlyphWithName(string aName)
	{
		NSApplication.EnsureUIThread();
		if (aName == null)
		{
			throw new ArgumentNullException("aName");
		}
		IntPtr arg = NSString.CreateNative(aName);
		uint result = ((!IsDirectBinding) ? Messaging.UInt32_objc_msgSendSuper_IntPtr(base.SuperHandle, selGlyphWithName_Handle, arg) : Messaging.UInt32_objc_msgSend_IntPtr(base.Handle, selGlyphWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("boundingRectForGlyph:")]
	public virtual CGRect BoundingRectForGlyph(uint aGlyph)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_UInt32(out retval, base.Handle, selBoundingRectForGlyph_Handle, aGlyph);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_UInt32(out retval, base.SuperHandle, selBoundingRectForGlyph_Handle, aGlyph);
		}
		return retval;
	}

	[Export("advancementForGlyph:")]
	public virtual CGSize AdvancementForGlyph(uint ag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_UInt32(base.Handle, selAdvancementForGlyph_Handle, ag);
		}
		return Messaging.CGSize_objc_msgSendSuper_UInt32(base.SuperHandle, selAdvancementForGlyph_Handle, ag);
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

	[Export("setInContext:")]
	public virtual void SetInContext(NSGraphicsContext graphicsContext)
	{
		NSApplication.EnsureUIThread();
		if (graphicsContext == null)
		{
			throw new ArgumentNullException("graphicsContext");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInContext_Handle, graphicsContext.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInContext_Handle, graphicsContext.Handle);
		}
	}

	[Export("screenFontWithRenderingMode:")]
	public virtual NSFont ScreenFontWithRenderingMode(NSFontRenderingMode renderingMode)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selScreenFontWithRenderingMode_Handle, (ulong)renderingMode));
		}
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selScreenFontWithRenderingMode_Handle, (ulong)renderingMode));
	}

	[Export("verticalFont")]
	public virtual NSFont GetVerticalFont()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVerticalFontHandle));
		}
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVerticalFontHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_FontDescriptor_var = null;
			__mt_TextTransform_var = null;
			__mt_CoveredCharacterSet_var = null;
			__mt_PrinterFont_var = null;
			__mt_ScreenFont_var = null;
		}
	}
}

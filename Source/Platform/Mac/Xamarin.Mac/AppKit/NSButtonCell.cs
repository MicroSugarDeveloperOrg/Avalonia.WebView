using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSButtonCell", true)]
public class NSButtonCell : NSActionCell
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternateImage = "alternateImage";

	private static readonly IntPtr selAlternateImageHandle = Selector.GetHandle("alternateImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternateMnemonic = "alternateMnemonic";

	private static readonly IntPtr selAlternateMnemonicHandle = Selector.GetHandle("alternateMnemonic");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternateMnemonicLocation = "alternateMnemonicLocation";

	private static readonly IntPtr selAlternateMnemonicLocationHandle = Selector.GetHandle("alternateMnemonicLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternateTitle = "alternateTitle";

	private static readonly IntPtr selAlternateTitleHandle = Selector.GetHandle("alternateTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedAlternateTitle = "attributedAlternateTitle";

	private static readonly IntPtr selAttributedAlternateTitleHandle = Selector.GetHandle("attributedAlternateTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedTitle = "attributedTitle";

	private static readonly IntPtr selAttributedTitleHandle = Selector.GetHandle("attributedTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBezelStyle = "bezelStyle";

	private static readonly IntPtr selBezelStyleHandle = Selector.GetHandle("bezelStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawBezelWithFrame_InView_ = "drawBezelWithFrame:inView:";

	private static readonly IntPtr selDrawBezelWithFrame_InView_Handle = Selector.GetHandle("drawBezelWithFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawImage_WithFrame_InView_ = "drawImage:withFrame:inView:";

	private static readonly IntPtr selDrawImage_WithFrame_InView_Handle = Selector.GetHandle("drawImage:withFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawTitle_WithFrame_InView_ = "drawTitle:withFrame:inView:";

	private static readonly IntPtr selDrawTitle_WithFrame_InView_Handle = Selector.GetHandle("drawTitle:withFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetPeriodicDelay_Interval_ = "getPeriodicDelay:interval:";

	private static readonly IntPtr selGetPeriodicDelay_Interval_Handle = Selector.GetHandle("getPeriodicDelay:interval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlightsBy = "highlightsBy";

	private static readonly IntPtr selHighlightsByHandle = Selector.GetHandle("highlightsBy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageDimsWhenDisabled = "imageDimsWhenDisabled";

	private static readonly IntPtr selImageDimsWhenDisabledHandle = Selector.GetHandle("imageDimsWhenDisabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImagePosition = "imagePosition";

	private static readonly IntPtr selImagePositionHandle = Selector.GetHandle("imagePosition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageScaling = "imageScaling";

	private static readonly IntPtr selImageScalingHandle = Selector.GetHandle("imageScaling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitImageCell_ = "initImageCell:";

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_ = "initTextCell:";

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOpaque = "isOpaque";

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTransparent = "isTransparent";

	private static readonly IntPtr selIsTransparentHandle = Selector.GetHandle("isTransparent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyEquivalent = "keyEquivalent";

	private static readonly IntPtr selKeyEquivalentHandle = Selector.GetHandle("keyEquivalent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyEquivalentFont = "keyEquivalentFont";

	private static readonly IntPtr selKeyEquivalentFontHandle = Selector.GetHandle("keyEquivalentFont");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyEquivalentModifierMask = "keyEquivalentModifierMask";

	private static readonly IntPtr selKeyEquivalentModifierMaskHandle = Selector.GetHandle("keyEquivalentModifierMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseEntered_ = "mouseEntered:";

	private static readonly IntPtr selMouseEntered_Handle = Selector.GetHandle("mouseEntered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseExited_ = "mouseExited:";

	private static readonly IntPtr selMouseExited_Handle = Selector.GetHandle("mouseExited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformClick_ = "performClick:";

	private static readonly IntPtr selPerformClick_Handle = Selector.GetHandle("performClick:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlternateImage_ = "setAlternateImage:";

	private static readonly IntPtr selSetAlternateImage_Handle = Selector.GetHandle("setAlternateImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlternateMnemonicLocation_ = "setAlternateMnemonicLocation:";

	private static readonly IntPtr selSetAlternateMnemonicLocation_Handle = Selector.GetHandle("setAlternateMnemonicLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlternateTitle_ = "setAlternateTitle:";

	private static readonly IntPtr selSetAlternateTitle_Handle = Selector.GetHandle("setAlternateTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlternateTitleWithMnemonic_ = "setAlternateTitleWithMnemonic:";

	private static readonly IntPtr selSetAlternateTitleWithMnemonic_Handle = Selector.GetHandle("setAlternateTitleWithMnemonic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributedAlternateTitle_ = "setAttributedAlternateTitle:";

	private static readonly IntPtr selSetAttributedAlternateTitle_Handle = Selector.GetHandle("setAttributedAlternateTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributedTitle_ = "setAttributedTitle:";

	private static readonly IntPtr selSetAttributedTitle_Handle = Selector.GetHandle("setAttributedTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBezelStyle_ = "setBezelStyle:";

	private static readonly IntPtr selSetBezelStyle_Handle = Selector.GetHandle("setBezelStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetButtonType_ = "setButtonType:";

	private static readonly IntPtr selSetButtonType_Handle = Selector.GetHandle("setButtonType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFont_ = "setFont:";

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGradientType_ = "setGradientType:";

	private static readonly IntPtr selSetGradientType_Handle = Selector.GetHandle("setGradientType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHighlightsBy_ = "setHighlightsBy:";

	private static readonly IntPtr selSetHighlightsBy_Handle = Selector.GetHandle("setHighlightsBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageDimsWhenDisabled_ = "setImageDimsWhenDisabled:";

	private static readonly IntPtr selSetImageDimsWhenDisabled_Handle = Selector.GetHandle("setImageDimsWhenDisabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImagePosition_ = "setImagePosition:";

	private static readonly IntPtr selSetImagePosition_Handle = Selector.GetHandle("setImagePosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageScaling_ = "setImageScaling:";

	private static readonly IntPtr selSetImageScaling_Handle = Selector.GetHandle("setImageScaling:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyEquivalent_ = "setKeyEquivalent:";

	private static readonly IntPtr selSetKeyEquivalent_Handle = Selector.GetHandle("setKeyEquivalent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyEquivalentFont_ = "setKeyEquivalentFont:";

	private static readonly IntPtr selSetKeyEquivalentFont_Handle = Selector.GetHandle("setKeyEquivalentFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyEquivalentFont_Size_ = "setKeyEquivalentFont:size:";

	private static readonly IntPtr selSetKeyEquivalentFont_Size_Handle = Selector.GetHandle("setKeyEquivalentFont:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyEquivalentModifierMask_ = "setKeyEquivalentModifierMask:";

	private static readonly IntPtr selSetKeyEquivalentModifierMask_Handle = Selector.GetHandle("setKeyEquivalentModifierMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPeriodicDelay_Interval_ = "setPeriodicDelay:interval:";

	private static readonly IntPtr selSetPeriodicDelay_Interval_Handle = Selector.GetHandle("setPeriodicDelay:interval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsBorderOnlyWhileMouseInside_ = "setShowsBorderOnlyWhileMouseInside:";

	private static readonly IntPtr selSetShowsBorderOnlyWhileMouseInside_Handle = Selector.GetHandle("setShowsBorderOnlyWhileMouseInside:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsStateBy_ = "setShowsStateBy:";

	private static readonly IntPtr selSetShowsStateBy_Handle = Selector.GetHandle("setShowsStateBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSound_ = "setSound:";

	private static readonly IntPtr selSetSound_Handle = Selector.GetHandle("setSound:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransparent_ = "setTransparent:";

	private static readonly IntPtr selSetTransparent_Handle = Selector.GetHandle("setTransparent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsBorderOnlyWhileMouseInside = "showsBorderOnlyWhileMouseInside";

	private static readonly IntPtr selShowsBorderOnlyWhileMouseInsideHandle = Selector.GetHandle("showsBorderOnlyWhileMouseInside");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsStateBy = "showsStateBy";

	private static readonly IntPtr selShowsStateByHandle = Selector.GetHandle("showsStateBy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSound = "sound";

	private static readonly IntPtr selSoundHandle = Selector.GetHandle("sound");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSButtonCell");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage AlternateImage
	{
		[Export("alternateImage", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateImageHandle));
		}
		[Export("setAlternateImage:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlternateImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlternateImage_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, "This method still will set Title with the ampersand stripped from the value, but does nothing else. Set the Title directly.")]
	public virtual string AlternateMnemonic
	{
		[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, "This method still will set Title with the ampersand stripped from the value, but does nothing else. Set the Title directly.")]
		[Export("alternateMnemonic")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateMnemonicHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateMnemonicHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, "This method still will set Title with the ampersand stripped from the value, but does nothing else. Set the Title directly.")]
		[Export("setAlternateTitleWithMnemonic:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlternateTitleWithMnemonic_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlternateTitleWithMnemonic_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, "This method no longer does anything and should not be called.")]
	public virtual nint AlternateMnemonicLocation
	{
		[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, "This method no longer does anything and should not be called.")]
		[Export("alternateMnemonicLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAlternateMnemonicLocationHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAlternateMnemonicLocationHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.All, "This method no longer does anything and should not be called.")]
		[Export("setAlternateMnemonicLocation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetAlternateMnemonicLocation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetAlternateMnemonicLocation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string AlternateTitle
	{
		[Export("alternateTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateTitleHandle));
		}
		[Export("setAlternateTitle:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlternateTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlternateTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString AttributedAlternateTitle
	{
		[Export("attributedAlternateTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedAlternateTitleHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedAlternateTitleHandle));
		}
		[Export("setAttributedAlternateTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedAlternateTitle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedAlternateTitle_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString AttributedTitle
	{
		[Export("attributedTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedTitleHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedTitleHandle));
		}
		[Export("setAttributedTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedTitle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedTitle_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBezelStyle BezelStyle
	{
		[Export("bezelStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSBezelStyle)Messaging.UInt64_objc_msgSend(base.Handle, selBezelStyleHandle);
			}
			return (NSBezelStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBezelStyleHandle);
		}
		[Export("setBezelStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBezelStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBezelStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint HighlightsBy
	{
		[Export("highlightsBy")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selHighlightsByHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selHighlightsByHandle);
		}
		[Export("setHighlightsBy:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetHighlightsBy_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetHighlightsBy_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ImageDimsWhenDisabled
	{
		[Export("imageDimsWhenDisabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selImageDimsWhenDisabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selImageDimsWhenDisabledHandle);
		}
		[Export("setImageDimsWhenDisabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetImageDimsWhenDisabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetImageDimsWhenDisabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCellImagePosition ImagePosition
	{
		[Export("imagePosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSCellImagePosition)Messaging.UInt64_objc_msgSend(base.Handle, selImagePositionHandle);
			}
			return (NSCellImagePosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImagePositionHandle);
		}
		[Export("setImagePosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImagePosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImagePosition_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImageScale ImageScale
	{
		[Export("imageScaling")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSImageScale)Messaging.UInt64_objc_msgSend(base.Handle, selImageScalingHandle);
			}
			return (NSImageScale)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImageScalingHandle);
		}
		[Export("setImageScaling:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImageScaling_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImageScaling_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool IsOpaque
	{
		[Export("isOpaque")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpaqueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpaqueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string KeyEquivalent
	{
		[Export("keyEquivalent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyEquivalentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentHandle));
		}
		[Export("setKeyEquivalent:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeyEquivalent_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeyEquivalent_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "It always returns the NSButtonCell's font.")]
	public virtual NSFont? KeyEquivalentFont
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "It always returns the NSButtonCell's font.")]
		[Export("keyEquivalentFont", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyEquivalentFontHandle));
			}
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentFontHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "It always returns the NSButtonCell's font.")]
		[Export("setKeyEquivalentFont:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeyEquivalentFont_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeyEquivalentFont_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEventModifierMask KeyEquivalentModifierMask
	{
		[Export("keyEquivalentModifierMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSEventModifierMask)Messaging.UInt64_objc_msgSend(base.Handle, selKeyEquivalentModifierMaskHandle);
			}
			return (NSEventModifierMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentModifierMaskHandle);
		}
		[Export("setKeyEquivalentModifierMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetKeyEquivalentModifierMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetKeyEquivalentModifierMask_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsBorderOnlyWhileMouseInside
	{
		[Export("showsBorderOnlyWhileMouseInside")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsBorderOnlyWhileMouseInsideHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsBorderOnlyWhileMouseInsideHandle);
		}
		[Export("setShowsBorderOnlyWhileMouseInside:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsBorderOnlyWhileMouseInside_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsBorderOnlyWhileMouseInside_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ShowsStateBy
	{
		[Export("showsStateBy")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selShowsStateByHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selShowsStateByHandle);
		}
		[Export("setShowsStateBy:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetShowsStateBy_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetShowsStateBy_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSound Sound
	{
		[Export("sound")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSound>(Messaging.IntPtr_objc_msgSend(base.Handle, selSoundHandle));
			}
			return Runtime.GetNSObject<NSSound>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSoundHandle));
		}
		[Export("setSound:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSound_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSound_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string Title
	{
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
	public virtual bool Transparent
	{
		[Export("isTransparent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTransparentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTransparentHandle);
		}
		[Export("setTransparent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTransparent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTransparent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSButtonCell()
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
	public NSButtonCell(NSCoder coder)
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
	protected NSButtonCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSButtonCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSButtonCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSButtonCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
	}

	[Export("drawBezelWithFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawBezelWithFrame(CGRect frame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawBezelWithFrame_InView_Handle, frame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawBezelWithFrame_InView_Handle, frame, controlView.Handle);
		}
	}

	[Export("drawImage:withFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawImage(NSImage image, CGRect frame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr(base.Handle, selDrawImage_WithFrame_InView_Handle, image.Handle, frame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_IntPtr(base.SuperHandle, selDrawImage_WithFrame_InView_Handle, image.Handle, frame, controlView.Handle);
		}
	}

	[Export("drawTitle:withFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect DrawTitle(NSAttributedString title, CGRect frame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect_IntPtr(out retval, base.Handle, selDrawTitle_WithFrame_InView_Handle, title.Handle, frame, controlView.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_IntPtr(out retval, base.SuperHandle, selDrawTitle_WithFrame_InView_Handle, title.Handle, frame, controlView.Handle);
		}
		return retval;
	}

	[Export("getPeriodicDelay:interval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetPeriodicDelay(out float delay, out float interval)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_Single_out_Single(base.Handle, selGetPeriodicDelay_Interval_Handle, out delay, out interval);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_Single_out_Single(base.SuperHandle, selGetPeriodicDelay_Interval_Handle, out delay, out interval);
		}
	}

	[Export("mouseEntered:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseEntered(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseEntered_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseEntered_Handle, theEvent.Handle);
		}
	}

	[Export("mouseExited:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseExited(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseExited_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseExited_Handle, theEvent.Handle);
		}
	}

	[Export("performClick:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void PerformClick(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformClick_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformClick_Handle, sender.Handle);
		}
	}

	[Export("setButtonType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetButtonType(NSButtonType aType)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetButtonType_Handle, (ulong)aType);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetButtonType_Handle, (ulong)aType);
		}
	}

	[Export("setFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFont_Handle, fontObj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFont_Handle, fontObj.Handle);
		}
	}

	[Export("setGradientType:")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, "The GradientType property is unused, and setting it has no effect.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetGradientType(NSGradientType type)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetGradientType_Handle, (ulong)type);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetGradientType_Handle, (ulong)type);
		}
	}

	[Export("setKeyEquivalentFont:size:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetKeyEquivalentFont(string fontName, nfloat fontSize)
	{
		NSApplication.EnsureUIThread();
		if (fontName == null)
		{
			throw new ArgumentNullException("fontName");
		}
		IntPtr arg = NSString.CreateNative(fontName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, selSetKeyEquivalentFont_Size_Handle, arg, fontSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selSetKeyEquivalentFont_Size_Handle, arg, fontSize);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setPeriodicDelay:interval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetPeriodicDelay(float delay, float interval)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_float(base.Handle, selSetPeriodicDelay_Interval_Handle, delay, interval);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_float(base.SuperHandle, selSetPeriodicDelay_Interval_Handle, delay, interval);
		}
	}
}

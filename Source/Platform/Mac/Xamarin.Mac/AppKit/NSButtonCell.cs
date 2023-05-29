using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSButtonCell", true)]
public class NSButtonCell : NSActionCell
{
	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selAlternateTitleHandle = Selector.GetHandle("alternateTitle");

	private static readonly IntPtr selSetAlternateTitle_Handle = Selector.GetHandle("setAlternateTitle:");

	private static readonly IntPtr selAlternateImageHandle = Selector.GetHandle("alternateImage");

	private static readonly IntPtr selSetAlternateImage_Handle = Selector.GetHandle("setAlternateImage:");

	private static readonly IntPtr selImagePositionHandle = Selector.GetHandle("imagePosition");

	private static readonly IntPtr selSetImagePosition_Handle = Selector.GetHandle("setImagePosition:");

	private static readonly IntPtr selImageScalingHandle = Selector.GetHandle("imageScaling");

	private static readonly IntPtr selSetImageScaling_Handle = Selector.GetHandle("setImageScaling:");

	private static readonly IntPtr selHighlightsByHandle = Selector.GetHandle("highlightsBy");

	private static readonly IntPtr selSetHighlightsBy_Handle = Selector.GetHandle("setHighlightsBy:");

	private static readonly IntPtr selShowsStateByHandle = Selector.GetHandle("showsStateBy");

	private static readonly IntPtr selSetShowsStateBy_Handle = Selector.GetHandle("setShowsStateBy:");

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	private static readonly IntPtr selIsTransparentHandle = Selector.GetHandle("isTransparent");

	private static readonly IntPtr selSetTransparent_Handle = Selector.GetHandle("setTransparent:");

	private static readonly IntPtr selKeyEquivalentHandle = Selector.GetHandle("keyEquivalent");

	private static readonly IntPtr selSetKeyEquivalent_Handle = Selector.GetHandle("setKeyEquivalent:");

	private static readonly IntPtr selKeyEquivalentModifierMaskHandle = Selector.GetHandle("keyEquivalentModifierMask");

	private static readonly IntPtr selSetKeyEquivalentModifierMask_Handle = Selector.GetHandle("setKeyEquivalentModifierMask:");

	private static readonly IntPtr selKeyEquivalentFontHandle = Selector.GetHandle("keyEquivalentFont");

	private static readonly IntPtr selSetKeyEquivalentFont_Handle = Selector.GetHandle("setKeyEquivalentFont:");

	private static readonly IntPtr selAlternateMnemonicLocationHandle = Selector.GetHandle("alternateMnemonicLocation");

	private static readonly IntPtr selSetAlternateMnemonicLocation_Handle = Selector.GetHandle("setAlternateMnemonicLocation:");

	private static readonly IntPtr selAlternateMnemonicHandle = Selector.GetHandle("alternateMnemonic");

	private static readonly IntPtr selSetAlternateTitleWithMnemonic_Handle = Selector.GetHandle("setAlternateTitleWithMnemonic:");

	private static readonly IntPtr selImageDimsWhenDisabledHandle = Selector.GetHandle("imageDimsWhenDisabled");

	private static readonly IntPtr selSetImageDimsWhenDisabled_Handle = Selector.GetHandle("setImageDimsWhenDisabled:");

	private static readonly IntPtr selShowsBorderOnlyWhileMouseInsideHandle = Selector.GetHandle("showsBorderOnlyWhileMouseInside");

	private static readonly IntPtr selSetShowsBorderOnlyWhileMouseInside_Handle = Selector.GetHandle("setShowsBorderOnlyWhileMouseInside:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selAttributedTitleHandle = Selector.GetHandle("attributedTitle");

	private static readonly IntPtr selSetAttributedTitle_Handle = Selector.GetHandle("setAttributedTitle:");

	private static readonly IntPtr selAttributedAlternateTitleHandle = Selector.GetHandle("attributedAlternateTitle");

	private static readonly IntPtr selSetAttributedAlternateTitle_Handle = Selector.GetHandle("setAttributedAlternateTitle:");

	private static readonly IntPtr selBezelStyleHandle = Selector.GetHandle("bezelStyle");

	private static readonly IntPtr selSetBezelStyle_Handle = Selector.GetHandle("setBezelStyle:");

	private static readonly IntPtr selSoundHandle = Selector.GetHandle("sound");

	private static readonly IntPtr selSetSound_Handle = Selector.GetHandle("setSound:");

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	private static readonly IntPtr selSetButtonType_Handle = Selector.GetHandle("setButtonType:");

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	private static readonly IntPtr selSetPeriodicDelayInterval_Handle = Selector.GetHandle("setPeriodicDelay:interval:");

	private static readonly IntPtr selGetPeriodicDelayInterval_Handle = Selector.GetHandle("getPeriodicDelay:interval:");

	private static readonly IntPtr selSetKeyEquivalentFontSize_Handle = Selector.GetHandle("setKeyEquivalentFont:size:");

	private static readonly IntPtr selPerformClick_Handle = Selector.GetHandle("performClick:");

	private static readonly IntPtr selDrawImageWithFrameInView_Handle = Selector.GetHandle("drawImage:withFrame:inView:");

	private static readonly IntPtr selDrawTitleWithFrameInView_Handle = Selector.GetHandle("drawTitle:withFrame:inView:");

	private static readonly IntPtr selDrawBezelWithFrameInView_Handle = Selector.GetHandle("drawBezelWithFrame:inView:");

	private static readonly IntPtr selSetGradientType_Handle = Selector.GetHandle("setGradientType:");

	private static readonly IntPtr selMouseEntered_Handle = Selector.GetHandle("mouseEntered:");

	private static readonly IntPtr selMouseExited_Handle = Selector.GetHandle("mouseExited:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSButtonCell");

	private object __mt_AlternateImage_var;

	private object __mt_KeyEquivalentFont_var;

	private object __mt_BackgroundColor_var;

	private object __mt_AttributedTitle_var;

	private object __mt_AttributedAlternateTitle_var;

	private object __mt_Sound_var;

	public override IntPtr ClassHandle => class_ptr;

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

	public virtual string AlternateTitle
	{
		[Export("alternateTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual NSImage AlternateImage
	{
		[Export("alternateImage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_AlternateImage_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateImageHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateImageHandle)))));
		}
		[Export("setAlternateImage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlternateImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlternateImage_Handle, value.Handle);
			}
			__mt_AlternateImage_var = value;
		}
	}

	public virtual NSCellImagePosition ImagePosition
	{
		[Export("imagePosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSCellImagePosition)Messaging.UInt64_objc_msgSend(base.Handle, selImagePositionHandle);
			}
			return (NSCellImagePosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImagePositionHandle);
		}
		[Export("setImagePosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImagePosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImagePosition_Handle, (ulong)value);
			}
		}
	}

	public virtual NSImageScale ImageScale
	{
		[Export("imageScaling")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSImageScale)Messaging.UInt64_objc_msgSend(base.Handle, selImageScalingHandle);
			}
			return (NSImageScale)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selImageScalingHandle);
		}
		[Export("setImageScaling:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetImageScaling_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetImageScaling_Handle, (ulong)value);
			}
		}
	}

	public virtual long HighlightsBy
	{
		[Export("highlightsBy")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selHighlightsByHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selHighlightsByHandle);
		}
		[Export("setHighlightsBy:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetHighlightsBy_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetHighlightsBy_Handle, value);
			}
		}
	}

	public virtual long ShowsStateBy
	{
		[Export("showsStateBy")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selShowsStateByHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selShowsStateByHandle);
		}
		[Export("setShowsStateBy:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetShowsStateBy_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetShowsStateBy_Handle, value);
			}
		}
	}

	public new virtual bool IsOpaque
	{
		[Export("isOpaque")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpaqueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpaqueHandle);
		}
	}

	public virtual bool Transparent
	{
		[Export("isTransparent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTransparentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTransparentHandle);
		}
		[Export("setTransparent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTransparent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTransparent_Handle, value);
			}
		}
	}

	public new virtual string KeyEquivalent
	{
		[Export("keyEquivalent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual NSEventModifierMask KeyEquivalentModifierMask
	{
		[Export("keyEquivalentModifierMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSEventModifierMask)Messaging.UInt64_objc_msgSend(base.Handle, selKeyEquivalentModifierMaskHandle);
			}
			return (NSEventModifierMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentModifierMaskHandle);
		}
		[Export("setKeyEquivalentModifierMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetKeyEquivalentModifierMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetKeyEquivalentModifierMask_Handle, (ulong)value);
			}
		}
	}

	public virtual NSFont KeyEquivalentFont
	{
		[Export("keyEquivalentFont")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFont)(__mt_KeyEquivalentFont_var = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyEquivalentFontHandle))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyEquivalentFontHandle)))));
		}
		[Export("setKeyEquivalentFont:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeyEquivalentFont_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeyEquivalentFont_Handle, value.Handle);
			}
			__mt_KeyEquivalentFont_var = value;
		}
	}

	public virtual int AlternateMnemonicLocation
	{
		[Export("alternateMnemonicLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selAlternateMnemonicLocationHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selAlternateMnemonicLocationHandle);
		}
		[Export("setAlternateMnemonicLocation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetAlternateMnemonicLocation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetAlternateMnemonicLocation_Handle, value);
			}
		}
	}

	public virtual string AlternateMnemonic
	{
		[Export("alternateMnemonic")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternateMnemonicHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternateMnemonicHandle));
		}
		[Export("setAlternateTitleWithMnemonic:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlternateTitleWithMnemonic_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlternateTitleWithMnemonic_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool ImageDimsWhenDisabled
	{
		[Export("imageDimsWhenDisabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selImageDimsWhenDisabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selImageDimsWhenDisabledHandle);
		}
		[Export("setImageDimsWhenDisabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetImageDimsWhenDisabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetImageDimsWhenDisabled_Handle, value);
			}
		}
	}

	public virtual bool ShowsBorderOnlyWhileMouseInside
	{
		[Export("showsBorderOnlyWhileMouseInside")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsBorderOnlyWhileMouseInsideHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsBorderOnlyWhileMouseInsideHandle);
		}
		[Export("setShowsBorderOnlyWhileMouseInside:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsBorderOnlyWhileMouseInside_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsBorderOnlyWhileMouseInside_Handle, value);
			}
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			__mt_BackgroundColor_var = value;
		}
	}

	public virtual NSAttributedString AttributedTitle
	{
		[Export("attributedTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAttributedString)(__mt_AttributedTitle_var = ((!IsDirectBinding) ? ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedTitleHandle))) : ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedTitleHandle)))));
		}
		[Export("setAttributedTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedTitle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedTitle_Handle, value.Handle);
			}
			__mt_AttributedTitle_var = value;
		}
	}

	public virtual NSAttributedString AttributedAlternateTitle
	{
		[Export("attributedAlternateTitle")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAttributedString)(__mt_AttributedAlternateTitle_var = ((!IsDirectBinding) ? ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedAlternateTitleHandle))) : ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedAlternateTitleHandle)))));
		}
		[Export("setAttributedAlternateTitle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedAlternateTitle_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedAlternateTitle_Handle, value.Handle);
			}
			__mt_AttributedAlternateTitle_var = value;
		}
	}

	public virtual NSBezelStyle BezelStyle
	{
		[Export("bezelStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSBezelStyle)Messaging.UInt64_objc_msgSend(base.Handle, selBezelStyleHandle);
			}
			return (NSBezelStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBezelStyleHandle);
		}
		[Export("setBezelStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBezelStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBezelStyle_Handle, (ulong)value);
			}
		}
	}

	public virtual NSSound Sound
	{
		[Export("sound")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSSound)(__mt_Sound_var = ((!IsDirectBinding) ? ((NSSound)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSoundHandle))) : ((NSSound)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSoundHandle)))));
		}
		[Export("setSound:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSound_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSound_Handle, value.Handle);
			}
			__mt_Sound_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSButtonCell()
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
	public NSButtonCell(NSCoder coder)
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
	public NSButtonCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSButtonCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	public NSButtonCell(string aString)
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
	public NSButtonCell(NSImage image)
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

	[Export("setShowsStateBy:")]
	public virtual void SetShowsStateBy(long aType)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetShowsStateBy_Handle, aType);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetShowsStateBy_Handle, aType);
		}
	}

	[Export("setButtonType:")]
	public virtual void SetButtonType(NSButtonType aType)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetButtonType_Handle, (ulong)aType);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetButtonType_Handle, (ulong)aType);
		}
	}

	[Export("setFont:")]
	public virtual void SetFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFont_Handle, fontObj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFont_Handle, fontObj.Handle);
		}
	}

	[Export("setPeriodicDelay:interval:")]
	public virtual void SetPeriodicDelay(float delay, float interval)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_float(base.Handle, selSetPeriodicDelayInterval_Handle, delay, interval);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_float(base.SuperHandle, selSetPeriodicDelayInterval_Handle, delay, interval);
		}
	}

	[Export("getPeriodicDelay:interval:")]
	public virtual void GetPeriodicDelay(out float delay, out float interval)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_Single_out_Single(base.Handle, selGetPeriodicDelayInterval_Handle, out delay, out interval);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_Single_out_Single(base.SuperHandle, selGetPeriodicDelayInterval_Handle, out delay, out interval);
		}
	}

	[Export("setKeyEquivalentFont:size:")]
	public virtual void SetKeyEquivalentFont(string fontName, double fontSize)
	{
		NSApplication.EnsureUIThread();
		if (fontName == null)
		{
			throw new ArgumentNullException("fontName");
		}
		IntPtr arg = NSString.CreateNative(fontName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Double(base.Handle, selSetKeyEquivalentFontSize_Handle, arg, fontSize);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selSetKeyEquivalentFontSize_Handle, arg, fontSize);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("performClick:")]
	public new virtual void PerformClick(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformClick_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformClick_Handle, sender.Handle);
		}
	}

	[Export("drawImage:withFrame:inView:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_CGRect_IntPtr(base.Handle, selDrawImageWithFrameInView_Handle, image.Handle, frame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_CGRect_IntPtr(base.SuperHandle, selDrawImageWithFrameInView_Handle, image.Handle, frame, controlView.Handle);
		}
	}

	[Export("drawTitle:withFrame:inView:")]
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
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect_IntPtr(out retval, base.Handle, selDrawTitleWithFrameInView_Handle, title.Handle, frame, controlView.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_IntPtr(out retval, base.SuperHandle, selDrawTitleWithFrameInView_Handle, title.Handle, frame, controlView.Handle);
		}
		return retval;
	}

	[Export("drawBezelWithFrame:inView:")]
	public virtual void DrawBezelWithFrame(CGRect frame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawBezelWithFrameInView_Handle, frame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selDrawBezelWithFrameInView_Handle, frame, controlView.Handle);
		}
	}

	[Export("setGradientType:")]
	public virtual void SetGradientType(NSGradientType type)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetGradientType_Handle, (ulong)type);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetGradientType_Handle, (ulong)type);
		}
	}

	[Export("mouseEntered:")]
	public virtual void MouseEntered(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseEntered_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseEntered_Handle, theEvent.Handle);
		}
	}

	[Export("mouseExited:")]
	public virtual void MouseExited(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseExited_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseExited_Handle, theEvent.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AlternateImage_var = null;
			__mt_KeyEquivalentFont_var = null;
			__mt_BackgroundColor_var = null;
			__mt_AttributedTitle_var = null;
			__mt_AttributedAlternateTitle_var = null;
			__mt_Sound_var = null;
		}
	}
}

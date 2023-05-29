using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSFormCell", true)]
public class NSFormCell : NSActionCell
{
	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	private static readonly IntPtr selTitleWidthHandle = Selector.GetHandle("titleWidth");

	private static readonly IntPtr selSetTitleWidth_Handle = Selector.GetHandle("setTitleWidth:");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selTitleFontHandle = Selector.GetHandle("titleFont");

	private static readonly IntPtr selSetTitleFont_Handle = Selector.GetHandle("setTitleFont:");

	private static readonly IntPtr selTitleAlignmentHandle = Selector.GetHandle("titleAlignment");

	private static readonly IntPtr selSetTitleAlignment_Handle = Selector.GetHandle("setTitleAlignment:");

	private static readonly IntPtr selPlaceholderStringHandle = Selector.GetHandle("placeholderString");

	private static readonly IntPtr selSetPlaceholderString_Handle = Selector.GetHandle("setPlaceholderString:");

	private static readonly IntPtr selPlaceholderAttributedStringHandle = Selector.GetHandle("placeholderAttributedString");

	private static readonly IntPtr selSetPlaceholderAttributedString_Handle = Selector.GetHandle("setPlaceholderAttributedString:");

	private static readonly IntPtr selTitleBaseWritingDirectionHandle = Selector.GetHandle("titleBaseWritingDirection");

	private static readonly IntPtr selSetTitleBaseWritingDirection_Handle = Selector.GetHandle("setTitleBaseWritingDirection:");

	private static readonly IntPtr selAttributedTitleHandle = Selector.GetHandle("attributedTitle");

	private static readonly IntPtr selSetAttributedTitle_Handle = Selector.GetHandle("setAttributedTitle:");

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	private static readonly IntPtr selSetTitleWithMnemonic_Handle = Selector.GetHandle("setTitleWithMnemonic:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFormCell");

	private object __mt_TitleFont_var;

	private object __mt_PlaceholderAttributedString_var;

	private object __mt_AttributedTitle_var;

	public override IntPtr ClassHandle => class_ptr;

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

	public virtual double TitleWidth
	{
		[Export("titleWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTitleWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTitleWidthHandle);
		}
		[Export("setTitleWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTitleWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTitleWidth_Handle, value);
			}
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

	public virtual NSTextAlignment TitleAlignment
	{
		[Export("titleAlignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextAlignment)Messaging.UInt64_objc_msgSend(base.Handle, selTitleAlignmentHandle);
			}
			return (NSTextAlignment)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTitleAlignmentHandle);
		}
		[Export("setTitleAlignment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTitleAlignment_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTitleAlignment_Handle, (ulong)value);
			}
		}
	}

	public virtual string PlaceholderString
	{
		[Export("placeholderString")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaceholderStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaceholderStringHandle));
		}
		[Export("setPlaceholderString:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlaceholderString_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlaceholderString_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSAttributedString PlaceholderAttributedString
	{
		[Export("placeholderAttributedString")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAttributedString)(__mt_PlaceholderAttributedString_var = ((!IsDirectBinding) ? ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaceholderAttributedStringHandle))) : ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaceholderAttributedStringHandle)))));
		}
		[Export("setPlaceholderAttributedString:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlaceholderAttributedString_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlaceholderAttributedString_Handle, value.Handle);
			}
			__mt_PlaceholderAttributedString_var = value;
		}
	}

	public virtual NSWritingDirection TitleBaseWritingDirection
	{
		[Export("titleBaseWritingDirection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWritingDirection)Messaging.Int64_objc_msgSend(base.Handle, selTitleBaseWritingDirectionHandle);
			}
			return (NSWritingDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTitleBaseWritingDirectionHandle);
		}
		[Export("setTitleBaseWritingDirection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTitleBaseWritingDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTitleBaseWritingDirection_Handle, (long)value);
			}
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFormCell()
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
	public NSFormCell(NSCoder coder)
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
	public NSFormCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFormCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	public NSFormCell(string aString)
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
	public NSFormCell(NSImage image)
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

	[Export("initTextCell:")]
	public virtual IntPtr ConstrainScrollPoint(string aString)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		IntPtr result = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setTitleWithMnemonic:")]
	public new virtual void SetTitleWithMnemonic(string stringWithAmpersand)
	{
		NSApplication.EnsureUIThread();
		if (stringWithAmpersand == null)
		{
			throw new ArgumentNullException("stringWithAmpersand");
		}
		IntPtr arg = NSString.CreateNative(stringWithAmpersand);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitleWithMnemonic_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitleWithMnemonic_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TitleFont_var = null;
			__mt_PlaceholderAttributedString_var = null;
			__mt_AttributedTitle_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using AppKit;
using CoreFoundation;
using CoreGraphics;
using CoreText;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CATextLayer", true)]
public class CATextLayer : CALayer
{
	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	private static readonly IntPtr selSetString_Handle = Selector.GetHandle("setString:");

	private static readonly IntPtr selFontSizeHandle = Selector.GetHandle("fontSize");

	private static readonly IntPtr selSetFontSize_Handle = Selector.GetHandle("setFontSize:");

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	private static readonly IntPtr selForegroundColorHandle = Selector.GetHandle("foregroundColor");

	private static readonly IntPtr selSetForegroundColor_Handle = Selector.GetHandle("setForegroundColor:");

	private static readonly IntPtr selIsWrappedHandle = Selector.GetHandle("isWrapped");

	private static readonly IntPtr selSetWrapped_Handle = Selector.GetHandle("setWrapped:");

	private static readonly IntPtr selTruncationModeHandle = Selector.GetHandle("truncationMode");

	private static readonly IntPtr selSetTruncationMode_Handle = Selector.GetHandle("setTruncationMode:");

	private static readonly IntPtr selAlignmentModeHandle = Selector.GetHandle("alignmentMode");

	private static readonly IntPtr selSetAlignmentMode_Handle = Selector.GetHandle("setAlignmentMode:");

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	private static readonly IntPtr class_ptr = Class.GetHandle("CATextLayer");

	private static NSString _TruncationNone;

	private static NSString _TruncantionStart;

	private static NSString _TruncantionEnd;

	private static NSString _TruncantionMiddle;

	private static NSString _AlignmentNatural;

	private static NSString _AlignmentLeft;

	private static NSString _AlignmentRight;

	private static NSString _AlignmentCenter;

	private static NSString _AlignmentJustified;

	public virtual NSAttributedString AttributedString
	{
		get
		{
			IntPtr ptr = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			return Runtime.GetNSObject(ptr) as NSAttributedString;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetString_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetString_Handle, value.Handle);
			}
		}
	}

	public object WeakFont
	{
		get
		{
			IntPtr font = _Font;
			int typeID = CFType.GetTypeID(font);
			if (typeID == CTFont.GetTypeID())
			{
				return new CTFont(font);
			}
			if (typeID == CGFont.GetTypeID())
			{
				return new CGFont(font, owns: false);
			}
			if (typeID == CFString.GetTypeID())
			{
				return CFString.FetchString(font);
			}
			return (NSFont)Runtime.GetNSObject(font);
		}
		set
		{
			if (value is NSFont nSFont)
			{
				_Font = nSFont.Handle;
				return;
			}
			if (value is CTFont cTFont)
			{
				_Font = cTFont.Handle;
				return;
			}
			if (value is CGFont cGFont)
			{
				_Font = cGFont.Handle;
				return;
			}
			NSString nSString = value as NSString;
			if (nSString != null)
			{
				_Font = nSString.Handle;
			}
			else if (value is string str)
			{
				nSString = new NSString(str);
				_Font = nSString.Handle;
			}
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual string String
	{
		[Export("string", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle));
		}
		[Export("setString:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetString_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetString_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual float FontSize
	{
		[Export("fontSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFontSizeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFontSizeHandle);
		}
		[Export("setFontSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFontSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFontSize_Handle, value);
			}
		}
	}

	internal virtual IntPtr _Font
	{
		[Export("font")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selFontHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontHandle);
		}
		[Export("setFont:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFont_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFont_Handle, value);
			}
		}
	}

	public virtual CGColor ForegroundColor
	{
		[Export("foregroundColor")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGColor(Messaging.IntPtr_objc_msgSend(base.Handle, selForegroundColorHandle));
			}
			return new CGColor(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selForegroundColorHandle));
		}
		[Export("setForegroundColor:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetForegroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetForegroundColor_Handle, value.Handle);
			}
		}
	}

	public virtual bool Wrapped
	{
		[Export("isWrapped")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsWrappedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsWrappedHandle);
		}
		[Export("setWrapped:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWrapped_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWrapped_Handle, value);
			}
		}
	}

	public virtual string TruncationMode
	{
		[Export("truncationMode", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTruncationModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTruncationModeHandle));
		}
		[Export("setTruncationMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTruncationMode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTruncationMode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string AlignmentMode
	{
		[Export("alignmentMode", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAlignmentModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlignmentModeHandle));
		}
		[Export("setAlignmentMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlignmentMode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlignmentMode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Field("kCATruncationNone", "CoreAnimation")]
	public static NSString TruncationNone
	{
		get
		{
			if (_TruncationNone == null)
			{
				_TruncationNone = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATruncationNone");
			}
			return _TruncationNone;
		}
	}

	[Field("kCATruncationStart", "CoreAnimation")]
	public static NSString TruncantionStart
	{
		get
		{
			if (_TruncantionStart == null)
			{
				_TruncantionStart = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATruncationStart");
			}
			return _TruncantionStart;
		}
	}

	[Field("kCATruncationEnd", "CoreAnimation")]
	public static NSString TruncantionEnd
	{
		get
		{
			if (_TruncantionEnd == null)
			{
				_TruncantionEnd = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATruncationEnd");
			}
			return _TruncantionEnd;
		}
	}

	[Field("kCATruncationMiddle", "CoreAnimation")]
	public static NSString TruncantionMiddle
	{
		get
		{
			if (_TruncantionMiddle == null)
			{
				_TruncantionMiddle = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCATruncationMiddle");
			}
			return _TruncantionMiddle;
		}
	}

	[Field("kCAAlignmentNatural", "CoreAnimation")]
	public static NSString AlignmentNatural
	{
		get
		{
			if (_AlignmentNatural == null)
			{
				_AlignmentNatural = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAlignmentNatural");
			}
			return _AlignmentNatural;
		}
	}

	[Field("kCAAlignmentLeft", "CoreAnimation")]
	public static NSString AlignmentLeft
	{
		get
		{
			if (_AlignmentLeft == null)
			{
				_AlignmentLeft = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAlignmentLeft");
			}
			return _AlignmentLeft;
		}
	}

	[Field("kCAAlignmentRight", "CoreAnimation")]
	public static NSString AlignmentRight
	{
		get
		{
			if (_AlignmentRight == null)
			{
				_AlignmentRight = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAlignmentRight");
			}
			return _AlignmentRight;
		}
	}

	[Field("kCAAlignmentCenter", "CoreAnimation")]
	public static NSString AlignmentCenter
	{
		get
		{
			if (_AlignmentCenter == null)
			{
				_AlignmentCenter = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAlignmentCenter");
			}
			return _AlignmentCenter;
		}
	}

	[Field("kCAAlignmentJustified", "CoreAnimation")]
	public static NSString AlignmentJustified
	{
		get
		{
			if (_AlignmentJustified == null)
			{
				_AlignmentJustified = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAAlignmentJustified");
			}
			return _AlignmentJustified;
		}
	}

	public void SetFont(string fontName)
	{
		if (fontName == null)
		{
			throw new ArgumentNullException("fontName");
		}
		using NSString nSString = new NSString(fontName);
		_Font = nSString.Handle;
	}

	public void SetFont(CGFont font)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		_Font = font.Handle;
	}

	public void SetFont(CTFont font)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		_Font = font.Handle;
	}

	public void SetFont(NSFont font)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		_Font = font.Handle;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CATextLayer()
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
	public CATextLayer(NSCoder coder)
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
	public CATextLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CATextLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	public new static CALayer Create()
	{
		return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}
}

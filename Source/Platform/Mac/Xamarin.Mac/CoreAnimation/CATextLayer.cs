using System.ComponentModel;
using AppKit;
using CoreFoundation;
using CoreGraphics;
using CoreText;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreAnimation;

[Register("CATextLayer", true)]
public class CATextLayer : CALayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignmentMode = "alignmentMode";

	private static readonly IntPtr selAlignmentModeHandle = Selector.GetHandle("alignmentMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsFontSubpixelQuantization = "allowsFontSubpixelQuantization";

	private static readonly IntPtr selAllowsFontSubpixelQuantizationHandle = Selector.GetHandle("allowsFontSubpixelQuantization");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFont = "font";

	private static readonly IntPtr selFontHandle = Selector.GetHandle("font");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontSize = "fontSize";

	private static readonly IntPtr selFontSizeHandle = Selector.GetHandle("fontSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForegroundColor = "foregroundColor";

	private static readonly IntPtr selForegroundColorHandle = Selector.GetHandle("foregroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsWrapped = "isWrapped";

	private static readonly IntPtr selIsWrappedHandle = Selector.GetHandle("isWrapped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayer = "layer";

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlignmentMode_ = "setAlignmentMode:";

	private static readonly IntPtr selSetAlignmentMode_Handle = Selector.GetHandle("setAlignmentMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsFontSubpixelQuantization_ = "setAllowsFontSubpixelQuantization:";

	private static readonly IntPtr selSetAllowsFontSubpixelQuantization_Handle = Selector.GetHandle("setAllowsFontSubpixelQuantization:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFont_ = "setFont:";

	private static readonly IntPtr selSetFont_Handle = Selector.GetHandle("setFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFontSize_ = "setFontSize:";

	private static readonly IntPtr selSetFontSize_Handle = Selector.GetHandle("setFontSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetForegroundColor_ = "setForegroundColor:";

	private static readonly IntPtr selSetForegroundColor_Handle = Selector.GetHandle("setForegroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetString_ = "setString:";

	private static readonly IntPtr selSetString_Handle = Selector.GetHandle("setString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTruncationMode_ = "setTruncationMode:";

	private static readonly IntPtr selSetTruncationMode_Handle = Selector.GetHandle("setTruncationMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWrapped_ = "setWrapped:";

	private static readonly IntPtr selSetWrapped_Handle = Selector.GetHandle("setWrapped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selString = "string";

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTruncationMode = "truncationMode";

	private static readonly IntPtr selTruncationModeHandle = Selector.GetHandle("truncationMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CATextLayer");

	public NSAttributedString AttributedString
	{
		get
		{
			return Runtime.GetNSObject(_AttributedString) as NSAttributedString;
		}
		set
		{
			_AttributedString = value?.Handle ?? IntPtr.Zero;
		}
	}

	public object WeakFont
	{
		get
		{
			IntPtr font = _Font;
			nint typeID = CFType.GetTypeID(font);
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

	[Obsolete("Use 'TextTruncationMode' instead.")]
	public virtual string TruncationMode
	{
		get
		{
			return WeakTruncationMode;
		}
		set
		{
			WeakTruncationMode = (NSString)value;
		}
	}

	[Obsolete("Use 'TextAlignmentMode' instead.")]
	public virtual string AlignmentMode
	{
		get
		{
			return WeakAlignmentMode;
		}
		set
		{
			WeakAlignmentMode = (NSString)value;
		}
	}

	public CATextLayerTruncationMode TextTruncationMode
	{
		get
		{
			return CATextLayerTruncationModeExtensions.GetValue(WeakTruncationMode);
		}
		set
		{
			WeakTruncationMode = value.GetConstant();
		}
	}

	public CATextLayerAlignmentMode TextAlignmentMode
	{
		get
		{
			return CATextLayerAlignmentModeExtensions.GetValue(WeakAlignmentMode);
		}
		set
		{
			WeakAlignmentMode = value.GetConstant();
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'CATextLayerAlignmentMode.Center.GetConstant ()' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static NSString AlignmentCenter => CATextLayerAlignmentMode.Center.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'CATextLayerAlignmentMode.Justified.GetConstant ()' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static NSString AlignmentJustified => CATextLayerAlignmentMode.Justified.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'CATextLayerAlignmentMode.Left.GetConstant ()' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static NSString AlignmentLeft => CATextLayerAlignmentMode.Left.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'CATextLayerAlignmentMode.Natural.GetConstant ()' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static NSString AlignmentNatural => CATextLayerAlignmentMode.Natural.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'CATextLayerAlignmentMode.Right.GetConstant ()' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static NSString AlignmentRight => CATextLayerAlignmentMode.Right.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual bool AllowsFontSubpixelQuantization
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("allowsFontSubpixelQuantization")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsFontSubpixelQuantizationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsFontSubpixelQuantizationHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("setAllowsFontSubpixelQuantization:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsFontSubpixelQuantization_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsFontSubpixelQuantization_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat FontSize
	{
		[Export("fontSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selFontSizeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selFontSizeHandle);
		}
		[Export("setFontSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetFontSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetFontSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor ForegroundColor
	{
		[Export("foregroundColor")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selForegroundColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selForegroundColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setForegroundColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetForegroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetForegroundColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? String
	{
		[Export("string", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle));
		}
		[Export("setString:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'CATextLayerTruncationMode.End.GetConstant ()' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static NSString TruncantionEnd => CATextLayerTruncationMode.End.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'CATextLayerTruncationMode.Middle.GetConstant ()' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static NSString TruncantionMiddle => CATextLayerTruncationMode.Middle.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'CATextLayerTruncationMode.Start.GetConstant ()' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static NSString TruncantionStart => CATextLayerTruncationMode.Start.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'CATextLayerTruncationMode.None.GetConstant ()' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static NSString TruncationNone => CATextLayerTruncationMode.None.GetConstant();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSString WeakAlignmentMode
	{
		[Export("alignmentMode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAlignmentModeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlignmentModeHandle));
		}
		[Export("setAlignmentMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlignmentMode_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlignmentMode_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSString WeakTruncationMode
	{
		[Export("truncationMode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selTruncationModeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTruncationModeHandle));
		}
		[Export("setTruncationMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTruncationMode_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTruncationMode_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Wrapped
	{
		[Export("isWrapped")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsWrappedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsWrappedHandle);
		}
		[Export("setWrapped:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWrapped_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWrapped_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr _AttributedString
	{
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle);
		}
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetString_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetString_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _Font
	{
		[Export("font")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selFontHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFontHandle);
		}
		[Export("setFont:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFont_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFont_Handle, value);
			}
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CATextLayer()
		: base(NSObjectFlag.Empty)
	{
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
	public CATextLayer(NSCoder coder)
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
	protected CATextLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CATextLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static CALayer Create()
	{
		return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}
}

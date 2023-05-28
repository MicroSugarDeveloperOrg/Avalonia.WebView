using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIColor", true)]
public class CIColor : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlpha = "alpha";

	private static readonly IntPtr selAlphaHandle = Selector.GetHandle("alpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlackColor = "blackColor";

	private static readonly IntPtr selBlackColorHandle = Selector.GetHandle("blackColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlue = "blue";

	private static readonly IntPtr selBlueHandle = Selector.GetHandle("blue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlueColor = "blueColor";

	private static readonly IntPtr selBlueColorHandle = Selector.GetHandle("blueColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearColor = "clearColor";

	private static readonly IntPtr selClearColorHandle = Selector.GetHandle("clearColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpace = "colorSpace";

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithCGColor_ = "colorWithCGColor:";

	private static readonly IntPtr selColorWithCGColor_Handle = Selector.GetHandle("colorWithCGColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithRed_Green_Blue_ = "colorWithRed:green:blue:";

	private static readonly IntPtr selColorWithRed_Green_Blue_Handle = Selector.GetHandle("colorWithRed:green:blue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithRed_Green_Blue_Alpha_ = "colorWithRed:green:blue:alpha:";

	private static readonly IntPtr selColorWithRed_Green_Blue_Alpha_Handle = Selector.GetHandle("colorWithRed:green:blue:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithRed_Green_Blue_Alpha_ColorSpace_ = "colorWithRed:green:blue:alpha:colorSpace:";

	private static readonly IntPtr selColorWithRed_Green_Blue_Alpha_ColorSpace_Handle = Selector.GetHandle("colorWithRed:green:blue:alpha:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithRed_Green_Blue_ColorSpace_ = "colorWithRed:green:blue:colorSpace:";

	private static readonly IntPtr selColorWithRed_Green_Blue_ColorSpace_Handle = Selector.GetHandle("colorWithRed:green:blue:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorWithString_ = "colorWithString:";

	private static readonly IntPtr selColorWithString_Handle = Selector.GetHandle("colorWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponents = "components";

	private static readonly IntPtr selComponentsHandle = Selector.GetHandle("components");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCyanColor = "cyanColor";

	private static readonly IntPtr selCyanColorHandle = Selector.GetHandle("cyanColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGrayColor = "grayColor";

	private static readonly IntPtr selGrayColorHandle = Selector.GetHandle("grayColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGreen = "green";

	private static readonly IntPtr selGreenHandle = Selector.GetHandle("green");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGreenColor = "greenColor";

	private static readonly IntPtr selGreenColorHandle = Selector.GetHandle("greenColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGColor_ = "initWithCGColor:";

	private static readonly IntPtr selInitWithCGColor_Handle = Selector.GetHandle("initWithCGColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithColor_ = "initWithColor:";

	private static readonly IntPtr selInitWithColor_Handle = Selector.GetHandle("initWithColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRed_Green_Blue_ = "initWithRed:green:blue:";

	private static readonly IntPtr selInitWithRed_Green_Blue_Handle = Selector.GetHandle("initWithRed:green:blue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRed_Green_Blue_Alpha_ = "initWithRed:green:blue:alpha:";

	private static readonly IntPtr selInitWithRed_Green_Blue_Alpha_Handle = Selector.GetHandle("initWithRed:green:blue:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRed_Green_Blue_Alpha_ColorSpace_ = "initWithRed:green:blue:alpha:colorSpace:";

	private static readonly IntPtr selInitWithRed_Green_Blue_Alpha_ColorSpace_Handle = Selector.GetHandle("initWithRed:green:blue:alpha:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRed_Green_Blue_ColorSpace_ = "initWithRed:green:blue:colorSpace:";

	private static readonly IntPtr selInitWithRed_Green_Blue_ColorSpace_Handle = Selector.GetHandle("initWithRed:green:blue:colorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagentaColor = "magentaColor";

	private static readonly IntPtr selMagentaColorHandle = Selector.GetHandle("magentaColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfComponents = "numberOfComponents";

	private static readonly IntPtr selNumberOfComponentsHandle = Selector.GetHandle("numberOfComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRed = "red";

	private static readonly IntPtr selRedHandle = Selector.GetHandle("red");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedColor = "redColor";

	private static readonly IntPtr selRedColorHandle = Selector.GetHandle("redColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringRepresentation = "stringRepresentation";

	private static readonly IntPtr selStringRepresentationHandle = Selector.GetHandle("stringRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWhiteColor = "whiteColor";

	private static readonly IntPtr selWhiteColorHandle = Selector.GetHandle("whiteColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYellowColor = "yellowColor";

	private static readonly IntPtr selYellowColorHandle = Selector.GetHandle("yellowColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIColor");

	public unsafe nfloat[] Components
	{
		get
		{
			nint numberOfComponents = NumberOfComponents;
			nfloat[] array = new nfloat[(long)numberOfComponents];
			nfloat* ptr = (nfloat*)(void*)GetComponents();
			for (int i = 0; i < numberOfComponents; i++)
			{
				array[i] = ptr[i];
			}
			return array;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Alpha
	{
		[Export("alpha")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAlphaHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAlphaHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static CIColor BlackColor
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("blackColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selBlackColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Blue
	{
		[Export("blue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selBlueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selBlueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static CIColor BlueColor
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("blueColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selBlueColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static CIColor ClearColor
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("clearColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selClearColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColorSpace ColorSpace
	{
		[Export("colorSpace")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static CIColor CyanColor
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("cyanColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selCyanColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static CIColor GrayColor
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("grayColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selGrayColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Green
	{
		[Export("green")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selGreenHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selGreenHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static CIColor GreenColor
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("greenColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selGreenColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static CIColor MagentaColor
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("magentaColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selMagentaColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfComponents
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
	public virtual nfloat Red
	{
		[Export("red")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static CIColor RedColor
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("redColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selRedColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static CIColor WhiteColor
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("whiteColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selWhiteColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static CIColor YellowColor
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("yellowColor", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(class_ptr, selYellowColorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIColor(NSCoder coder)
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
	protected CIColor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIColor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCGColor:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor(CGColor c)
		: base(NSObjectFlag.Empty)
	{
		if (c == null)
		{
			throw new ArgumentNullException("c");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCGColor_Handle, c.Handle), "initWithCGColor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCGColor_Handle, c.Handle), "initWithCGColor:");
		}
	}

	[Export("initWithRed:green:blue:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor(nfloat red, nfloat green, nfloat blue)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat(base.Handle, selInitWithRed_Green_Blue_Handle, red, green, blue), "initWithRed:green:blue:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nfloat_nfloat_nfloat(base.SuperHandle, selInitWithRed_Green_Blue_Handle, red, green, blue), "initWithRed:green:blue:");
		}
	}

	[Export("initWithRed:green:blue:colorSpace:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor(nfloat red, nfloat green, nfloat blue, CGColorSpace colorSpace)
		: base(NSObjectFlag.Empty)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_IntPtr(base.Handle, selInitWithRed_Green_Blue_ColorSpace_Handle, red, green, blue, colorSpace.Handle), "initWithRed:green:blue:colorSpace:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nfloat_nfloat_nfloat_IntPtr(base.SuperHandle, selInitWithRed_Green_Blue_ColorSpace_Handle, red, green, blue, colorSpace.Handle), "initWithRed:green:blue:colorSpace:");
		}
	}

	[Export("initWithRed:green:blue:alpha:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor(nfloat red, nfloat green, nfloat blue, nfloat alpha)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(base.Handle, selInitWithRed_Green_Blue_Alpha_Handle, red, green, blue, alpha), "initWithRed:green:blue:alpha:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nfloat_nfloat_nfloat_nfloat(base.SuperHandle, selInitWithRed_Green_Blue_Alpha_Handle, red, green, blue, alpha), "initWithRed:green:blue:alpha:");
		}
	}

	[Export("initWithRed:green:blue:alpha:colorSpace:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor(nfloat red, nfloat green, nfloat blue, nfloat alpha, CGColorSpace colorSpace)
		: base(NSObjectFlag.Empty)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat_IntPtr(base.Handle, selInitWithRed_Green_Blue_Alpha_ColorSpace_Handle, red, green, blue, alpha, colorSpace.Handle), "initWithRed:green:blue:alpha:colorSpace:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nfloat_nfloat_nfloat_nfloat_IntPtr(base.SuperHandle, selInitWithRed_Green_Blue_Alpha_ColorSpace_Handle, red, green, blue, alpha, colorSpace.Handle), "initWithRed:green:blue:alpha:colorSpace:");
		}
	}

	[Export("initWithColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor(NSColor color)
		: base(NSObjectFlag.Empty)
	{
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithColor_Handle, color.Handle), "initWithColor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithColor_Handle, color.Handle), "initWithColor:");
		}
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

	[Export("colorWithCGColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIColor FromCGColor(CGColor c)
	{
		if (c == null)
		{
			throw new ArgumentNullException("c");
		}
		return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorWithCGColor_Handle, c.Handle));
	}

	[Export("colorWithRed:green:blue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIColor FromRgb(nfloat red, nfloat green, nfloat blue)
	{
		return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat(class_ptr, selColorWithRed_Green_Blue_Handle, red, green, blue));
	}

	[Export("colorWithRed:green:blue:colorSpace:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIColor? FromRgb(nfloat red, nfloat green, nfloat blue, CGColorSpace colorSpace)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_IntPtr(class_ptr, selColorWithRed_Green_Blue_ColorSpace_Handle, red, green, blue, colorSpace.Handle));
	}

	[Export("colorWithRed:green:blue:alpha:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIColor FromRgba(nfloat red, nfloat green, nfloat blue, nfloat alpha)
	{
		return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat(class_ptr, selColorWithRed_Green_Blue_Alpha_Handle, red, green, blue, alpha));
	}

	[Export("colorWithRed:green:blue:alpha:colorSpace:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIColor? FromRgba(nfloat red, nfloat green, nfloat blue, nfloat alpha, CGColorSpace colorSpace)
	{
		if (colorSpace == null)
		{
			throw new ArgumentNullException("colorSpace");
		}
		return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat_IntPtr(class_ptr, selColorWithRed_Green_Blue_Alpha_ColorSpace_Handle, red, green, blue, alpha, colorSpace.Handle));
	}

	[Export("colorWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIColor FromString(string representation)
	{
		if (representation == null)
		{
			throw new ArgumentNullException("representation");
		}
		IntPtr arg = NSString.CreateNative(representation);
		CIColor nSObject = Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("components")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr GetComponents()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selComponentsHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComponentsHandle);
	}

	[Export("stringRepresentation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringRepresentation()
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringRepresentationHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringRepresentationHandle));
	}
}

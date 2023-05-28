using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CISampler", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public class CISampler : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefinition = "definition";

	private static readonly IntPtr selDefinitionHandle = Selector.GetHandle("definition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtent = "extent";

	private static readonly IntPtr selExtentHandle = Selector.GetHandle("extent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithImage_ = "initWithImage:";

	private static readonly IntPtr selInitWithImage_Handle = Selector.GetHandle("initWithImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithImage_Options_ = "initWithImage:options:";

	private static readonly IntPtr selInitWithImage_Options_Handle = Selector.GetHandle("initWithImage:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSamplerWithImage_ = "samplerWithImage:";

	private static readonly IntPtr selSamplerWithImage_Handle = Selector.GetHandle("samplerWithImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSamplerWithImage_Options_ = "samplerWithImage:options:";

	private static readonly IntPtr selSamplerWithImage_Options_Handle = Selector.GetHandle("samplerWithImage:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CISampler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AffineMatrix;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorSpace;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterLinear;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterNearest;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WrapBlack;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WrapClamp;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WrapMode;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilterShape Definition
	{
		[Export("definition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefinitionHandle));
			}
			return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefinitionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Extent
	{
		[Export("extent")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selExtentHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selExtentHandle);
			}
			return retval;
		}
	}

	[Field("kCISamplerAffineMatrix", "Quartz")]
	internal static NSString AffineMatrix
	{
		get
		{
			if (_AffineMatrix == null)
			{
				_AffineMatrix = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCISamplerAffineMatrix");
			}
			return _AffineMatrix;
		}
	}

	[Field("kCISamplerColorSpace", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	internal static NSString ColorSpace
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ColorSpace == null)
			{
				_ColorSpace = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCISamplerColorSpace");
			}
			return _ColorSpace;
		}
	}

	[Field("kCISamplerFilterLinear", "Quartz")]
	internal static NSString FilterLinear
	{
		get
		{
			if (_FilterLinear == null)
			{
				_FilterLinear = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCISamplerFilterLinear");
			}
			return _FilterLinear;
		}
	}

	[Field("kCISamplerFilterMode", "Quartz")]
	internal static NSString FilterMode
	{
		get
		{
			if (_FilterMode == null)
			{
				_FilterMode = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCISamplerFilterMode");
			}
			return _FilterMode;
		}
	}

	[Field("kCISamplerFilterNearest", "Quartz")]
	internal static NSString FilterNearest
	{
		get
		{
			if (_FilterNearest == null)
			{
				_FilterNearest = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCISamplerFilterNearest");
			}
			return _FilterNearest;
		}
	}

	[Field("kCISamplerWrapBlack", "Quartz")]
	internal static NSString WrapBlack
	{
		get
		{
			if (_WrapBlack == null)
			{
				_WrapBlack = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCISamplerWrapBlack");
			}
			return _WrapBlack;
		}
	}

	[Field("kCISamplerWrapClamp", "Quartz")]
	internal static NSString WrapClamp
	{
		get
		{
			if (_WrapClamp == null)
			{
				_WrapClamp = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCISamplerWrapClamp");
			}
			return _WrapClamp;
		}
	}

	[Field("kCISamplerWrapMode", "Quartz")]
	internal static NSString WrapMode
	{
		get
		{
			if (_WrapMode == null)
			{
				_WrapMode = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCISamplerWrapMode");
			}
			return _WrapMode;
		}
	}

	[Obsolete("This default constructor does not provide a valid instance")]
	public CISampler()
	{
	}

	public CISampler FromImage(CIImage sourceImage, CISamplerOptions options)
	{
		if (options == null)
		{
			return FromImage(sourceImage);
		}
		return FromImage(sourceImage, options.ToDictionary());
	}

	[DesignatedInitializer]
	public CISampler(CIImage sourceImage, CISamplerOptions options)
		: this(sourceImage, options?.ToDictionary())
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CISampler(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CISampler(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CISampler(CIImage sourceImage)
		: base(NSObjectFlag.Empty)
	{
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithImage_Handle, sourceImage.Handle), "initWithImage:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithImage_Handle, sourceImage.Handle), "initWithImage:");
		}
	}

	[Export("initWithImage:options:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal CISampler(CIImage image, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithImage_Options_Handle, image.Handle, options.Handle), "initWithImage:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithImage_Options_Handle, image.Handle, options.Handle), "initWithImage:options:");
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

	[Export("samplerWithImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CISampler FromImage(CIImage sourceImage)
	{
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		return Runtime.GetNSObject<CISampler>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSamplerWithImage_Handle, sourceImage.Handle));
	}

	[Export("samplerWithImage:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static CISampler FromImage(CIImage sourceImag, NSDictionary options)
	{
		if (sourceImag == null)
		{
			throw new ArgumentNullException("sourceImag");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return Runtime.GetNSObject<CISampler>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selSamplerWithImage_Options_Handle, sourceImag.Handle, options.Handle));
	}
}

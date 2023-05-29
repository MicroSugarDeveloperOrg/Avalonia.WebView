using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CISampler", true)]
public class CISampler : NSObject
{
	private static readonly IntPtr selDefinitionHandle = Selector.GetHandle("definition");

	private static readonly IntPtr selExtentHandle = Selector.GetHandle("extent");

	private static readonly IntPtr selSamplerWithImage_Handle = Selector.GetHandle("samplerWithImage:");

	private static readonly IntPtr selSamplerWithImageOptions_Handle = Selector.GetHandle("samplerWithImage:options:");

	private static readonly IntPtr selInitWithImage_Handle = Selector.GetHandle("initWithImage:");

	private static readonly IntPtr selInitWithImageOptions_Handle = Selector.GetHandle("initWithImage:options:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CISampler");

	private object __mt_Definition_var;

	private static NSString _AffineMatrix;

	private static NSString _WrapMode;

	private static NSString _FilterMode;

	private static NSString _WrapBlack;

	private static NSString _WrapClamp;

	private static NSString _FilterNearest;

	private static NSString _FilterLinear;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CIFilterShape Definition
	{
		[Export("definition")]
		get
		{
			return (CIFilterShape)(__mt_Definition_var = ((!IsDirectBinding) ? ((CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefinitionHandle))) : ((CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDefinitionHandle)))));
		}
	}

	public virtual CGRect Extent
	{
		[Export("extent")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
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

	public CISampler FromImage(CIImage sourceImage, CISamplerOptions options)
	{
		if (options == null)
		{
			return FromImage(sourceImage);
		}
		return FromImage(sourceImage, options.ToDictionary());
	}

	public CISampler(CIImage sourceImage, CISamplerOptions options)
		: this(sourceImage, options?.ToDictionary())
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CISampler()
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
	public CISampler(NSCoder coder)
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
	public CISampler(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CISampler(IntPtr handle)
		: base(handle)
	{
	}

	[Export("samplerWithImage:")]
	public static CISampler FromImage(CIImage sourceImage)
	{
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		return (CISampler)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSamplerWithImage_Handle, sourceImage.Handle));
	}

	[Export("samplerWithImage:options:")]
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
		return (CISampler)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selSamplerWithImageOptions_Handle, sourceImag.Handle, options.Handle));
	}

	[Export("initWithImage:")]
	public CISampler(CIImage sourceImage)
		: base(NSObjectFlag.Empty)
	{
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithImage_Handle, sourceImage.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithImage_Handle, sourceImage.Handle);
		}
	}

	[Export("initWithImage:options:")]
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithImageOptions_Handle, image.Handle, options.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithImageOptions_Handle, image.Handle, options.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Definition_var = null;
		}
	}
}

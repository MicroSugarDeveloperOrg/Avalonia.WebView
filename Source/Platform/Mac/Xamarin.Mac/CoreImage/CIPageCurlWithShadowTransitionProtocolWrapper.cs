using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIPageCurlWithShadowTransitionProtocolWrapper : BaseWrapper, ICIPageCurlWithShadowTransitionProtocol, INativeObject, IDisposable, ICIFilterProtocol, ICITransitionFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? BacksideImage
	{
		[Export("backsideImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("backsideImage")));
		}
		[Export("setBacksideImage:", ArgumentSemantic.Retain)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setBacksideImage:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect InputExtent
	{
		[Export("extent", ArgumentSemantic.Assign)]
		get
		{
			Messaging.CGRect_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("extent"));
			return retval;
		}
		[Export("setExtent:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, Selector.GetHandle("setExtent:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Angle
	{
		[Export("angle")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("angle"));
		}
		[Export("setAngle:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setAngle:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Radius
	{
		[Export("radius")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("radius"));
		}
		[Export("setRadius:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setRadius:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float ShadowSize
	{
		[Export("shadowSize")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("shadowSize"));
		}
		[Export("setShadowSize:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setShadowSize:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float ShadowAmount
	{
		[Export("shadowAmount")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("shadowAmount"));
		}
		[Export("setShadowAmount:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setShadowAmount:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect InputShadowExtent
	{
		[Export("shadowExtent", ArgumentSemantic.Assign)]
		get
		{
			Messaging.CGRect_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("shadowExtent"));
			return retval;
		}
		[Export("setShadowExtent:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, Selector.GetHandle("setShadowExtent:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public CIImage? OutputImage
	{
		[Export("outputImage")]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("outputImage")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public CIImage? InputImage
	{
		[Export("inputImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("inputImage")));
		}
		[Export("setInputImage:", ArgumentSemantic.Retain)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setInputImage:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public CIImage? TargetImage
	{
		[Export("targetImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("targetImage")));
		}
		[Export("setTargetImage:", ArgumentSemantic.Retain)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setTargetImage:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public float Time
	{
		[Export("time")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("time"));
		}
		[Export("setTime:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setTime:"), value);
		}
	}

	[Preserve(Conditional = true)]
	public CIPageCurlWithShadowTransitionProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

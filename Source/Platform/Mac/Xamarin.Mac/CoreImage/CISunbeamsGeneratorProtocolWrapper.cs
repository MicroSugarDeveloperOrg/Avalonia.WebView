using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CISunbeamsGeneratorProtocolWrapper : BaseWrapper, ICISunbeamsGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputCenter
	{
		[Export("center", ArgumentSemantic.Assign)]
		get
		{
			return Messaging.CGPoint_objc_msgSend(base.Handle, Selector.GetHandle("center"));
		}
		[Export("setCenter:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("setCenter:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor Color
	{
		[Export("color", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("color")));
		}
		[Export("setColor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setColor:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float SunRadius
	{
		[Export("sunRadius")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("sunRadius"));
		}
		[Export("setSunRadius:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setSunRadius:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MaxStriationRadius
	{
		[Export("maxStriationRadius")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("maxStriationRadius"));
		}
		[Export("setMaxStriationRadius:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setMaxStriationRadius:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float StriationStrength
	{
		[Export("striationStrength")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("striationStrength"));
		}
		[Export("setStriationStrength:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setStriationStrength:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float StriationContrast
	{
		[Export("striationContrast")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("striationContrast"));
		}
		[Export("setStriationContrast:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setStriationContrast:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Preserve(Conditional = true)]
	public CISunbeamsGeneratorProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

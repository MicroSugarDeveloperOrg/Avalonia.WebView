using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIStarShineGeneratorProtocolWrapper : BaseWrapper, ICIStarShineGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public float CrossScale
	{
		[Export("crossScale")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("crossScale"));
		}
		[Export("setCrossScale:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCrossScale:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float CrossAngle
	{
		[Export("crossAngle")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("crossAngle"));
		}
		[Export("setCrossAngle:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCrossAngle:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float CrossOpacity
	{
		[Export("crossOpacity")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("crossOpacity"));
		}
		[Export("setCrossOpacity:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCrossOpacity:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float CrossWidth
	{
		[Export("crossWidth")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("crossWidth"));
		}
		[Export("setCrossWidth:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCrossWidth:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Epsilon
	{
		[Export("epsilon")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("epsilon"));
		}
		[Export("setEpsilon:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setEpsilon:"), value);
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
	public CIStarShineGeneratorProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

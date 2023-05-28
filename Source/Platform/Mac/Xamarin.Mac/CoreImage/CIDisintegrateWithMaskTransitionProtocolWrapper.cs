using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIDisintegrateWithMaskTransitionProtocolWrapper : BaseWrapper, ICIDisintegrateWithMaskTransitionProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? MaskImage
	{
		[Export("maskImage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("maskImage")));
		}
		[Export("setMaskImage:", ArgumentSemantic.Retain)]
		set
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setMaskImage:"), value?.Handle ?? IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float ShadowRadius
	{
		[Export("shadowRadius")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("shadowRadius"));
		}
		[Export("setShadowRadius:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setShadowRadius:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float ShadowDensity
	{
		[Export("shadowDensity")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("shadowDensity"));
		}
		[Export("setShadowDensity:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setShadowDensity:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputShadowOffset
	{
		[Export("shadowOffset", ArgumentSemantic.Assign)]
		get
		{
			return Messaging.CGPoint_objc_msgSend(base.Handle, Selector.GetHandle("shadowOffset"));
		}
		[Export("setShadowOffset:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("setShadowOffset:"), value);
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
	public CIDisintegrateWithMaskTransitionProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CILineOverlayProtocolWrapper : BaseWrapper, ICILineOverlayProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	public float NRNoiseLevel
	{
		[Export("NRNoiseLevel")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("NRNoiseLevel"));
		}
		[Export("setNRNoiseLevel:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setNRNoiseLevel:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float NRSharpness
	{
		[Export("NRSharpness")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("NRSharpness"));
		}
		[Export("setNRSharpness:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setNRSharpness:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float EdgeIntensity
	{
		[Export("edgeIntensity")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("edgeIntensity"));
		}
		[Export("setEdgeIntensity:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setEdgeIntensity:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Threshold
	{
		[Export("threshold")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("threshold"));
		}
		[Export("setThreshold:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setThreshold:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Contrast
	{
		[Export("contrast")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("contrast"));
		}
		[Export("setContrast:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setContrast:"), value);
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
	public CILineOverlayProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

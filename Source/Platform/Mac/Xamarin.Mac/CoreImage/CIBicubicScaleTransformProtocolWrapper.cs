using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIBicubicScaleTransformProtocolWrapper : BaseWrapper, ICIBicubicScaleTransformProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public float Scale
	{
		[Export("scale")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("scale"));
		}
		[Export("setScale:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setScale:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float AspectRatio
	{
		[Export("aspectRatio")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("aspectRatio"));
		}
		[Export("setAspectRatio:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setAspectRatio:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float ParameterB
	{
		[Export("parameterB")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("parameterB"));
		}
		[Export("setParameterB:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setParameterB:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float ParameterC
	{
		[Export("parameterC")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("parameterC"));
		}
		[Export("setParameterC:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setParameterC:"), value);
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
	public CIBicubicScaleTransformProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

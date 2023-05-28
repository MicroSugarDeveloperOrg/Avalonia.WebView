using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIPerspectiveRotateProtocolWrapper : BaseWrapper, ICIPerspectiveRotateProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public float FocalLength
	{
		[Export("focalLength")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("focalLength"));
		}
		[Export("setFocalLength:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setFocalLength:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Pitch
	{
		[Export("pitch")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("pitch"));
		}
		[Export("setPitch:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setPitch:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Yaw
	{
		[Export("yaw")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("yaw"));
		}
		[Export("setYaw:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setYaw:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Roll
	{
		[Export("roll")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("roll"));
		}
		[Export("setRoll:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setRoll:"), value);
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
	public CIPerspectiveRotateProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

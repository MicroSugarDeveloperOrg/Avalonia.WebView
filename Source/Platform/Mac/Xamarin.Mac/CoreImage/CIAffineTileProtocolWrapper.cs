using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIAffineTileProtocolWrapper : BaseWrapper, ICIAffineTileProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public CGAffineTransform Transform
	{
		[Export("transform", ArgumentSemantic.Assign)]
		get
		{
			Messaging.CGAffineTransform_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("transform"));
			return retval;
		}
		[Export("setTransform:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, Selector.GetHandle("setTransform:"), value);
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
	public CIAffineTileProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

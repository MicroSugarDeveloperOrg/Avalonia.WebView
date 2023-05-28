using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIFourCoordinateGeometryFilterProtocolWrapper : BaseWrapper, ICIFourCoordinateGeometryFilterProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public CGPoint InputTopLeft
	{
		[Export("topLeft", ArgumentSemantic.Assign)]
		get
		{
			return Messaging.CGPoint_objc_msgSend(base.Handle, Selector.GetHandle("topLeft"));
		}
		[Export("setTopLeft:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("setTopLeft:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputTopRight
	{
		[Export("topRight", ArgumentSemantic.Assign)]
		get
		{
			return Messaging.CGPoint_objc_msgSend(base.Handle, Selector.GetHandle("topRight"));
		}
		[Export("setTopRight:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("setTopRight:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputBottomRight
	{
		[Export("bottomRight", ArgumentSemantic.Assign)]
		get
		{
			return Messaging.CGPoint_objc_msgSend(base.Handle, Selector.GetHandle("bottomRight"));
		}
		[Export("setBottomRight:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("setBottomRight:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputBottomLeft
	{
		[Export("bottomLeft", ArgumentSemantic.Assign)]
		get
		{
			return Messaging.CGPoint_objc_msgSend(base.Handle, Selector.GetHandle("bottomLeft"));
		}
		[Export("setBottomLeft:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("setBottomLeft:"), value);
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
	public CIFourCoordinateGeometryFilterProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CILinearGradientProtocolWrapper : BaseWrapper, ICILinearGradientProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputPoint0
	{
		[Export("point0", ArgumentSemantic.Assign)]
		get
		{
			return Messaging.CGPoint_objc_msgSend(base.Handle, Selector.GetHandle("point0"));
		}
		[Export("setPoint0:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("setPoint0:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputPoint1
	{
		[Export("point1", ArgumentSemantic.Assign)]
		get
		{
			return Messaging.CGPoint_objc_msgSend(base.Handle, Selector.GetHandle("point1"));
		}
		[Export("setPoint1:", ArgumentSemantic.Assign)]
		set
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("setPoint1:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor Color0
	{
		[Export("color0", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("color0")));
		}
		[Export("setColor0:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setColor0:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIColor Color1
	{
		[Export("color1", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIColor>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("color1")));
		}
		[Export("setColor1:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setColor1:"), value.Handle);
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
	public CILinearGradientProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIFalseColorProtocolWrapper : BaseWrapper, ICIFalseColorProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public CIFalseColorProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIAztecCodeGeneratorProtocolWrapper : BaseWrapper, ICIAztecCodeGeneratorProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData Message
	{
		[Export("message", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("message")));
		}
		[Export("setMessage:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setMessage:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float CorrectionLevel
	{
		[Export("correctionLevel")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("correctionLevel"));
		}
		[Export("setCorrectionLevel:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCorrectionLevel:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputLayers
	{
		[Export("layers")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("layers"));
		}
		[Export("setLayers:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setLayers:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputCompactStyle
	{
		[Export("compactStyle")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("compactStyle"));
		}
		[Export("setCompactStyle:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setCompactStyle:"), value);
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
	public CIAztecCodeGeneratorProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIColorMatrixProtocolWrapper : BaseWrapper, ICIColorMatrixProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public CIVector RVector
	{
		[Export("RVector", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIVector>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("RVector")));
		}
		[Export("setRVector:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setRVector:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector GVector
	{
		[Export("GVector", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIVector>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("GVector")));
		}
		[Export("setGVector:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setGVector:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector BVector
	{
		[Export("BVector", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIVector>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("BVector")));
		}
		[Export("setBVector:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setBVector:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector AVector
	{
		[Export("AVector", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIVector>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("AVector")));
		}
		[Export("setAVector:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setAVector:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector BiasVector
	{
		[Export("biasVector", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CIVector>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("biasVector")));
		}
		[Export("setBiasVector:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setBiasVector:"), value.Handle);
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
	public CIColorMatrixProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

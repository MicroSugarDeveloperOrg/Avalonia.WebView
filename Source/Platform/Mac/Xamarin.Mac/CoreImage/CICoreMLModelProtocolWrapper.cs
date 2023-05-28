using System;
using CoreML;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CICoreMLModelProtocolWrapper : BaseWrapper, ICICoreMLModelProtocol, INativeObject, IDisposable, ICIFilterProtocol
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
	public MLModel Model
	{
		[Export("model", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<MLModel>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("model")));
		}
		[Export("setModel:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setModel:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float HeadIndex
	{
		[Export("headIndex")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("headIndex"));
		}
		[Export("setHeadIndex:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setHeadIndex:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool SoftmaxNormalization
	{
		[Export("softmaxNormalization")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("softmaxNormalization"));
		}
		[Export("setSoftmaxNormalization:")]
		set
		{
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setSoftmaxNormalization:"), value);
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
	public CICoreMLModelProtocolWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

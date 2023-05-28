using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIBokehBlur : CILinearBlur, ICIBokehBlurProtocol, INativeObject, IDisposable, ICIFilterProtocol
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? InputImage
	{
		[Export("inputImage", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputImage") as CIImage;
		}
		[Export("setInputImage:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputImage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new float Radius
	{
		[Export("radius")]
		get
		{
			return GetFloat("inputRadius");
		}
		[Export("setRadius:")]
		set
		{
			SetFloat("inputRadius", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float RingAmount
	{
		[Export("ringAmount")]
		get
		{
			return GetFloat("inputRingAmount");
		}
		[Export("setRingAmount:")]
		set
		{
			SetFloat("inputRingAmount", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float RingSize
	{
		[Export("ringSize")]
		get
		{
			return GetFloat("inputRingSize");
		}
		[Export("setRingSize:")]
		set
		{
			SetFloat("inputRingSize", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Softness
	{
		[Export("softness")]
		get
		{
			return GetFloat("inputSoftness");
		}
		[Export("setSoftness:")]
		set
		{
			SetFloat("inputSoftness", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CIImage? OutputImage
	{
		[Export("outputImage")]
		get
		{
			return ValueForKey("outputImage") as CIImage;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIBokehBlur()
		: base("CIBokehBlur")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIBokehBlur(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIBokehBlur(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIBokehBlur(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}

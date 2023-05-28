using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public class CIPageCurlWithShadowTransition : CIFilter, ICIPageCurlWithShadowTransitionProtocol, INativeObject, IDisposable, ICIFilterProtocol, ICITransitionFilterProtocol
{
	[Obsolete("Use 'Time' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float InputTime
	{
		get
		{
			return GetFloat("inputTime");
		}
		set
		{
			SetFloat("inputTime", value);
		}
	}

	[Obsolete("Use 'InputShadowExtent' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? ShadowExtent
	{
		get
		{
			return ValueForKey("inputShadowExtent") as CIVector;
		}
		set
		{
			SetValue("inputShadowExtent", value);
		}
	}

	[Obsolete("Use 'InputExtent' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Extent
	{
		get
		{
			return ValueForKey("inputExtent") as CIVector;
		}
		set
		{
			SetValue("inputExtent", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? BacksideImage
	{
		[Export("backsideImage", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputBacksideImage") as CIImage;
		}
		[Export("setBacksideImage:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputBacksideImage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect InputExtent
	{
		[Export("extent", ArgumentSemantic.Assign)]
		get
		{
			return GetRect("inputExtent");
		}
		[Export("setExtent:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputExtent", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Angle
	{
		[Export("angle")]
		get
		{
			return GetFloat("inputAngle");
		}
		[Export("setAngle:")]
		set
		{
			SetFloat("inputAngle", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Radius
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
	public float ShadowSize
	{
		[Export("shadowSize")]
		get
		{
			return GetFloat("inputShadowSize");
		}
		[Export("setShadowSize:")]
		set
		{
			SetFloat("inputShadowSize", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float ShadowAmount
	{
		[Export("shadowAmount")]
		get
		{
			return GetFloat("inputShadowAmount");
		}
		[Export("setShadowAmount:")]
		set
		{
			SetFloat("inputShadowAmount", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect InputShadowExtent
	{
		[Export("shadowExtent", ArgumentSemantic.Assign)]
		get
		{
			return GetRect("inputShadowExtent");
		}
		[Export("setShadowExtent:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputShadowExtent", value);
		}
	}

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
	public CIImage? TargetImage
	{
		[Export("targetImage", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputTargetImage") as CIImage;
		}
		[Export("setTargetImage:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputTargetImage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Time
	{
		[Export("time")]
		get
		{
			return GetFloat("inputTime");
		}
		[Export("setTime:")]
		set
		{
			SetFloat("inputTime", value);
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
	public CIPageCurlWithShadowTransition()
		: base("CIPageCurlWithShadowTransition")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIPageCurlWithShadowTransition(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIPageCurlWithShadowTransition(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIPageCurlWithShadowTransition(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}

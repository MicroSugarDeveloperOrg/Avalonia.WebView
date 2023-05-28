using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public class CIFlashTransition : CITransitionFilter, ICIFlashTransitionProtocol, INativeObject, IDisposable, ICIFilterProtocol, ICITransitionFilterProtocol
{
	[Obsolete("Use 'StriationContrast' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MaxStriationContrast
	{
		get
		{
			return GetFloat("inputStriationContrast");
		}
		set
		{
			SetFloat("inputStriationContrast", value);
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

	[Obsolete("Use 'InputCenter' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? Center
	{
		get
		{
			return ValueForKey("inputCenter") as CIVector;
		}
		set
		{
			SetValue("inputCenter", value);
		}
	}

	[Obsolete("Use 'StriationStrength' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MaxStriationStrength
	{
		get
		{
			return GetFloat("inputStriationStrength");
		}
		set
		{
			SetFloat("inputStriationStrength", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputCenter
	{
		[Export("center", ArgumentSemantic.Assign)]
		get
		{
			return GetPoint("inputCenter");
		}
		[Export("setCenter:", ArgumentSemantic.Assign)]
		set
		{
			SetValue("inputCenter", value);
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
	public CIColor Color
	{
		[Export("color", ArgumentSemantic.Retain)]
		get
		{
			return ValueForKey("inputColor") as CIColor;
		}
		[Export("setColor:", ArgumentSemantic.Retain)]
		set
		{
			SetValue("inputColor", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float MaxStriationRadius
	{
		[Export("maxStriationRadius")]
		get
		{
			return GetFloat("inputMaxStriationRadius");
		}
		[Export("setMaxStriationRadius:")]
		set
		{
			SetFloat("inputMaxStriationRadius", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float StriationStrength
	{
		[Export("striationStrength")]
		get
		{
			return GetFloat("inputStriationStrength");
		}
		[Export("setStriationStrength:")]
		set
		{
			SetFloat("inputStriationStrength", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float StriationContrast
	{
		[Export("striationContrast")]
		get
		{
			return GetFloat("inputStriationContrast");
		}
		[Export("setStriationContrast:")]
		set
		{
			SetFloat("inputStriationContrast", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float FadeThreshold
	{
		[Export("fadeThreshold")]
		get
		{
			return GetFloat("inputFadeThreshold");
		}
		[Export("setFadeThreshold:")]
		set
		{
			SetFloat("inputFadeThreshold", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new CIImage? InputImage
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
	public new CIImage? TargetImage
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
	public new float Time
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
	public CIFlashTransition()
		: base("CIFlashTransition")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIFlashTransition(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIFlashTransition(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIFlashTransition(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}

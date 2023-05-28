using System;
using System.ComponentModel;
using AVFoundation;
using Foundation;
using ImageIO;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIDepthBlurEffect : CIFilter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? InputImage
	{
		get
		{
			return ValueForKey("inputImage") as CIImage;
		}
		set
		{
			SetValue("inputImage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Aperture
	{
		get
		{
			return GetFloat("inputAperture");
		}
		set
		{
			SetFloat("inputAperture", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVCameraCalibrationData CalibrationData
	{
		get
		{
			return Runtime.GetINativeObject<AVCameraCalibrationData>(GetHandle("inputCalibrationData"), owns: false);
		}
		set
		{
			SetHandle("inputCalibrationData", value.GetHandle());
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? NosePositions
	{
		get
		{
			return ValueForKey("inputNosePositions") as CIVector;
		}
		set
		{
			SetValue("inputNosePositions", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float LumaNoiseScale
	{
		get
		{
			return GetFloat("inputLumaNoiseScale");
		}
		set
		{
			SetFloat("inputLumaNoiseScale", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? ChinPositions
	{
		get
		{
			return ValueForKey("inputChinPositions") as CIVector;
		}
		set
		{
			SetValue("inputChinPositions", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? DisparityImage
	{
		get
		{
			return ValueForKey("inputDisparityImage") as CIImage;
		}
		set
		{
			SetValue("inputDisparityImage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float ScaleFactor
	{
		get
		{
			return GetFloat("inputScaleFactor");
		}
		set
		{
			SetFloat("inputScaleFactor", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? RightEyePositions
	{
		get
		{
			return ValueForKey("inputRightEyePositions") as CIVector;
		}
		set
		{
			SetValue("inputRightEyePositions", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? LeftEyePositions
	{
		get
		{
			return ValueForKey("inputLeftEyePositions") as CIVector;
		}
		set
		{
			SetValue("inputLeftEyePositions", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? FocusRect
	{
		get
		{
			return ValueForKey("inputFocusRect") as CIVector;
		}
		set
		{
			SetValue("inputFocusRect", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? MatteImage
	{
		get
		{
			return ValueForKey("inputMatteImage") as CIImage;
		}
		set
		{
			SetValue("inputMatteImage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage? HairImage
	{
		get
		{
			return ValueForKey("inputHairImage") as CIImage;
		}
		set
		{
			SetValue("inputHairImage", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Shape
	{
		get
		{
			return ValueForKey("inputShape") as NSString;
		}
		set
		{
			using NSString value2 = new NSString(value);
			SetValue("inputShape", value2);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGImageMetadata AuxDataMetadata
	{
		get
		{
			return Runtime.GetINativeObject<CGImageMetadata>(GetHandle("inputAuxDataMetadata"), owns: false);
		}
		set
		{
			SetHandle("inputAuxDataMetadata", value.GetHandle());
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIDepthBlurEffect()
		: base("CIDepthBlurEffect")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIDepthBlurEffect(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIDepthBlurEffect(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIDepthBlurEffect(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}

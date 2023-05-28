using Foundation;
using ObjCRuntime;

namespace CoreImage;

public static class CIFilterInputKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Amount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Angle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AspectRatio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BackgroundImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BiasKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Brightness;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Center;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Color;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Contrast;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DepthImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisparityImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EV;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Extent;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GradientImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Image;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Intensity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaskImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MatteImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Radius;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Refraction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Saturation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Scale;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ShadingImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Sharpness;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TargetImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Time;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Transform;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Version;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WeightsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Width;

	[Field("kCIInputAmountKey", "Quartz")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSString Amount
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_Amount == null)
			{
				_Amount = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputAmountKey");
			}
			return _Amount;
		}
	}

	[Field("kCIInputAngleKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Angle
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Angle == null)
			{
				_Angle = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputAngleKey");
			}
			return _Angle;
		}
	}

	[Field("kCIInputAspectRatioKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString AspectRatio
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AspectRatio == null)
			{
				_AspectRatio = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputAspectRatioKey");
			}
			return _AspectRatio;
		}
	}

	[Field("kCIInputBackgroundImageKey", "Quartz")]
	public static NSString BackgroundImage
	{
		get
		{
			if (_BackgroundImage == null)
			{
				_BackgroundImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputBackgroundImageKey");
			}
			return _BackgroundImage;
		}
	}

	[Field("kCIInputBiasKey", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString BiasKey
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_BiasKey == null)
			{
				_BiasKey = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputBiasKey");
			}
			return _BiasKey;
		}
	}

	[Field("kCIInputBrightnessKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Brightness
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Brightness == null)
			{
				_Brightness = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputBrightnessKey");
			}
			return _Brightness;
		}
	}

	[Field("kCIInputCenterKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Center
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Center == null)
			{
				_Center = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputCenterKey");
			}
			return _Center;
		}
	}

	[Field("kCIInputColorKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Color
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Color == null)
			{
				_Color = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputColorKey");
			}
			return _Color;
		}
	}

	[Field("kCIInputContrastKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Contrast
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Contrast == null)
			{
				_Contrast = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputContrastKey");
			}
			return _Contrast;
		}
	}

	[Field("kCIInputDepthImageKey", "Quartz")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString DepthImage
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_DepthImage == null)
			{
				_DepthImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputDepthImageKey");
			}
			return _DepthImage;
		}
	}

	[Field("kCIInputDisparityImageKey", "Quartz")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString DisparityImage
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_DisparityImage == null)
			{
				_DisparityImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputDisparityImageKey");
			}
			return _DisparityImage;
		}
	}

	[Field("kCIInputEVKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString EV
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_EV == null)
			{
				_EV = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputEVKey");
			}
			return _EV;
		}
	}

	[Field("kCIInputExtentKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Extent
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Extent == null)
			{
				_Extent = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputExtentKey");
			}
			return _Extent;
		}
	}

	[Field("kCIInputGradientImageKey", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString GradientImage
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_GradientImage == null)
			{
				_GradientImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputGradientImageKey");
			}
			return _GradientImage;
		}
	}

	[Field("kCIInputImageKey", "Quartz")]
	public static NSString Image
	{
		get
		{
			if (_Image == null)
			{
				_Image = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputImageKey");
			}
			return _Image;
		}
	}

	[Field("kCIInputIntensityKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Intensity
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Intensity == null)
			{
				_Intensity = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputIntensityKey");
			}
			return _Intensity;
		}
	}

	[Field("kCIInputMaskImageKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString MaskImage
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MaskImage == null)
			{
				_MaskImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputMaskImageKey");
			}
			return _MaskImage;
		}
	}

	[Field("kCIInputMatteImageKey", "Quartz")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSString MatteImage
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_MatteImage == null)
			{
				_MatteImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputMatteImageKey");
			}
			return _MatteImage;
		}
	}

	[Field("kCIInputRadiusKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Radius
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Radius == null)
			{
				_Radius = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputRadiusKey");
			}
			return _Radius;
		}
	}

	[Field("kCIInputRefractionKey", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString Refraction
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Refraction == null)
			{
				_Refraction = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputRefractionKey");
			}
			return _Refraction;
		}
	}

	[Field("kCIInputSaturationKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Saturation
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Saturation == null)
			{
				_Saturation = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputSaturationKey");
			}
			return _Saturation;
		}
	}

	[Field("kCIInputScaleKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Scale
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Scale == null)
			{
				_Scale = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputScaleKey");
			}
			return _Scale;
		}
	}

	[Field("kCIInputShadingImageKey", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString ShadingImage
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ShadingImage == null)
			{
				_ShadingImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputShadingImageKey");
			}
			return _ShadingImage;
		}
	}

	[Field("kCIInputSharpnessKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Sharpness
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Sharpness == null)
			{
				_Sharpness = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputSharpnessKey");
			}
			return _Sharpness;
		}
	}

	[Field("kCIInputTargetImageKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString TargetImage
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_TargetImage == null)
			{
				_TargetImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputTargetImageKey");
			}
			return _TargetImage;
		}
	}

	[Field("kCIInputTimeKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Time
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Time == null)
			{
				_Time = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputTimeKey");
			}
			return _Time;
		}
	}

	[Field("kCIInputTransformKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Transform
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Transform == null)
			{
				_Transform = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputTransformKey");
			}
			return _Transform;
		}
	}

	[Field("kCIInputVersionKey", "Quartz")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString Version
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_Version == null)
			{
				_Version = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputVersionKey");
			}
			return _Version;
		}
	}

	[Field("kCIInputWeightsKey", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString WeightsKey
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_WeightsKey == null)
			{
				_WeightsKey = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputWeightsKey");
			}
			return _WeightsKey;
		}
	}

	[Field("kCIInputWidthKey", "Quartz")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString Width
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_Width == null)
			{
				_Width = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputWidthKey");
			}
			return _Width;
		}
	}
}

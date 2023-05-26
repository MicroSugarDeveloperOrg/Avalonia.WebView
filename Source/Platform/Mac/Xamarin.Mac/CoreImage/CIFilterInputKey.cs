using Foundation;
using ObjCRuntime;

namespace CoreImage;

public static class CIFilterInputKey
{
	private static NSString _BackgroundImage;

	private static NSString _Image;

	private static NSString _Time;

	private static NSString _Transform;

	private static NSString _Scale;

	private static NSString _AspectRatio;

	private static NSString _Center;

	private static NSString _Radius;

	private static NSString _Angle;

	private static NSString _Refraction;

	private static NSString _Width;

	private static NSString _Sharpness;

	private static NSString _Intensity;

	private static NSString _EV;

	private static NSString _Saturation;

	private static NSString _Color;

	private static NSString _Brightness;

	private static NSString _Contrast;

	private static NSString _GradientImage;

	private static NSString _MaskImage;

	private static NSString _ShadingImage;

	private static NSString _TargetImage;

	private static NSString _Extent;

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

	[Field("kCIInputTimeKey", "Quartz")]
	public static NSString Time
	{
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
	public static NSString Transform
	{
		get
		{
			if (_Transform == null)
			{
				_Transform = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputTransformKey");
			}
			return _Transform;
		}
	}

	[Field("kCIInputScaleKey", "Quartz")]
	public static NSString Scale
	{
		get
		{
			if (_Scale == null)
			{
				_Scale = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputScaleKey");
			}
			return _Scale;
		}
	}

	[Field("kCIInputAspectRatioKey", "Quartz")]
	public static NSString AspectRatio
	{
		get
		{
			if (_AspectRatio == null)
			{
				_AspectRatio = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputAspectRatioKey");
			}
			return _AspectRatio;
		}
	}

	[Field("kCIInputCenterKey", "Quartz")]
	public static NSString Center
	{
		get
		{
			if (_Center == null)
			{
				_Center = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputCenterKey");
			}
			return _Center;
		}
	}

	[Field("kCIInputRadiusKey", "Quartz")]
	public static NSString Radius
	{
		get
		{
			if (_Radius == null)
			{
				_Radius = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputRadiusKey");
			}
			return _Radius;
		}
	}

	[Field("kCIInputAngleKey", "Quartz")]
	public static NSString Angle
	{
		get
		{
			if (_Angle == null)
			{
				_Angle = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputAngleKey");
			}
			return _Angle;
		}
	}

	[Field("kCIInputRefractionKey", "Quartz")]
	public static NSString Refraction
	{
		get
		{
			if (_Refraction == null)
			{
				_Refraction = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputRefractionKey");
			}
			return _Refraction;
		}
	}

	[Field("kCIInputWidthKey", "Quartz")]
	public static NSString Width
	{
		get
		{
			if (_Width == null)
			{
				_Width = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputWidthKey");
			}
			return _Width;
		}
	}

	[Field("kCIInputSharpnessKey", "Quartz")]
	public static NSString Sharpness
	{
		get
		{
			if (_Sharpness == null)
			{
				_Sharpness = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputSharpnessKey");
			}
			return _Sharpness;
		}
	}

	[Field("kCIInputIntensityKey", "Quartz")]
	public static NSString Intensity
	{
		get
		{
			if (_Intensity == null)
			{
				_Intensity = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputIntensityKey");
			}
			return _Intensity;
		}
	}

	[Field("kCIInputEVKey", "Quartz")]
	public static NSString EV
	{
		get
		{
			if (_EV == null)
			{
				_EV = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputEVKey");
			}
			return _EV;
		}
	}

	[Field("kCIInputSaturationKey", "Quartz")]
	public static NSString Saturation
	{
		get
		{
			if (_Saturation == null)
			{
				_Saturation = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputSaturationKey");
			}
			return _Saturation;
		}
	}

	[Field("kCIInputColorKey", "Quartz")]
	public static NSString Color
	{
		get
		{
			if (_Color == null)
			{
				_Color = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputColorKey");
			}
			return _Color;
		}
	}

	[Field("kCIInputBrightnessKey", "Quartz")]
	public static NSString Brightness
	{
		get
		{
			if (_Brightness == null)
			{
				_Brightness = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputBrightnessKey");
			}
			return _Brightness;
		}
	}

	[Field("kCIInputContrastKey", "Quartz")]
	public static NSString Contrast
	{
		get
		{
			if (_Contrast == null)
			{
				_Contrast = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputContrastKey");
			}
			return _Contrast;
		}
	}

	[Field("kCIInputGradientImageKey", "Quartz")]
	public static NSString GradientImage
	{
		get
		{
			if (_GradientImage == null)
			{
				_GradientImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputGradientImageKey");
			}
			return _GradientImage;
		}
	}

	[Field("kCIInputMaskImageKey", "Quartz")]
	public static NSString MaskImage
	{
		get
		{
			if (_MaskImage == null)
			{
				_MaskImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputMaskImageKey");
			}
			return _MaskImage;
		}
	}

	[Field("kCIInputShadingImageKey", "Quartz")]
	public static NSString ShadingImage
	{
		get
		{
			if (_ShadingImage == null)
			{
				_ShadingImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputShadingImageKey");
			}
			return _ShadingImage;
		}
	}

	[Field("kCIInputTargetImageKey", "Quartz")]
	public static NSString TargetImage
	{
		get
		{
			if (_TargetImage == null)
			{
				_TargetImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputTargetImageKey");
			}
			return _TargetImage;
		}
	}

	[Field("kCIInputExtentKey", "Quartz")]
	public static NSString Extent
	{
		get
		{
			if (_Extent == null)
			{
				_Extent = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIInputExtentKey");
			}
			return _Extent;
		}
	}
}

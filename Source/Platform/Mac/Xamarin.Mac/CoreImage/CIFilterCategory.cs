using Foundation;
using ObjCRuntime;

namespace CoreImage;

public static class CIFilterCategory
{
	private static NSString _DistortionEffect;

	private static NSString _GeometryAdjustment;

	private static NSString _CompositeOperation;

	private static NSString _HalftoneEffect;

	private static NSString _ColorAdjustment;

	private static NSString _ColorEffect;

	private static NSString _Transition;

	private static NSString _TileEffect;

	private static NSString _Generator;

	private static NSString _Reduction;

	private static NSString _Gradient;

	private static NSString _Stylize;

	private static NSString _Sharpen;

	private static NSString _Blur;

	private static NSString _Video;

	private static NSString _StillImage;

	private static NSString _Interlaced;

	private static NSString _NonSquarePixels;

	private static NSString _HighDynamicRange;

	private static NSString _BuiltIn;

	private static NSString _FilterGenerator;

	[Field("kCICategoryDistortionEffect", "Quartz")]
	public static NSString DistortionEffect
	{
		get
		{
			if (_DistortionEffect == null)
			{
				_DistortionEffect = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryDistortionEffect");
			}
			return _DistortionEffect;
		}
	}

	[Field("kCICategoryGeometryAdjustment", "Quartz")]
	public static NSString GeometryAdjustment
	{
		get
		{
			if (_GeometryAdjustment == null)
			{
				_GeometryAdjustment = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryGeometryAdjustment");
			}
			return _GeometryAdjustment;
		}
	}

	[Field("kCICategoryCompositeOperation", "Quartz")]
	public static NSString CompositeOperation
	{
		get
		{
			if (_CompositeOperation == null)
			{
				_CompositeOperation = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryCompositeOperation");
			}
			return _CompositeOperation;
		}
	}

	[Field("kCICategoryHalftoneEffect", "Quartz")]
	public static NSString HalftoneEffect
	{
		get
		{
			if (_HalftoneEffect == null)
			{
				_HalftoneEffect = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryHalftoneEffect");
			}
			return _HalftoneEffect;
		}
	}

	[Field("kCICategoryColorAdjustment", "Quartz")]
	public static NSString ColorAdjustment
	{
		get
		{
			if (_ColorAdjustment == null)
			{
				_ColorAdjustment = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryColorAdjustment");
			}
			return _ColorAdjustment;
		}
	}

	[Field("kCICategoryColorEffect", "Quartz")]
	public static NSString ColorEffect
	{
		get
		{
			if (_ColorEffect == null)
			{
				_ColorEffect = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryColorEffect");
			}
			return _ColorEffect;
		}
	}

	[Field("kCICategoryTransition", "Quartz")]
	public static NSString Transition
	{
		get
		{
			if (_Transition == null)
			{
				_Transition = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryTransition");
			}
			return _Transition;
		}
	}

	[Field("kCICategoryTileEffect", "Quartz")]
	public static NSString TileEffect
	{
		get
		{
			if (_TileEffect == null)
			{
				_TileEffect = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryTileEffect");
			}
			return _TileEffect;
		}
	}

	[Field("kCICategoryGenerator", "Quartz")]
	public static NSString Generator
	{
		get
		{
			if (_Generator == null)
			{
				_Generator = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryGenerator");
			}
			return _Generator;
		}
	}

	[Field("kCICategoryReduction", "Quartz")]
	public static NSString Reduction
	{
		get
		{
			if (_Reduction == null)
			{
				_Reduction = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryReduction");
			}
			return _Reduction;
		}
	}

	[Field("kCICategoryGradient", "Quartz")]
	public static NSString Gradient
	{
		get
		{
			if (_Gradient == null)
			{
				_Gradient = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryGradient");
			}
			return _Gradient;
		}
	}

	[Field("kCICategoryStylize", "Quartz")]
	public static NSString Stylize
	{
		get
		{
			if (_Stylize == null)
			{
				_Stylize = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryStylize");
			}
			return _Stylize;
		}
	}

	[Field("kCICategorySharpen", "Quartz")]
	public static NSString Sharpen
	{
		get
		{
			if (_Sharpen == null)
			{
				_Sharpen = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategorySharpen");
			}
			return _Sharpen;
		}
	}

	[Field("kCICategoryBlur", "Quartz")]
	public static NSString Blur
	{
		get
		{
			if (_Blur == null)
			{
				_Blur = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryBlur");
			}
			return _Blur;
		}
	}

	[Field("kCICategoryVideo", "Quartz")]
	public static NSString Video
	{
		get
		{
			if (_Video == null)
			{
				_Video = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryVideo");
			}
			return _Video;
		}
	}

	[Field("kCICategoryStillImage", "Quartz")]
	public static NSString StillImage
	{
		get
		{
			if (_StillImage == null)
			{
				_StillImage = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryStillImage");
			}
			return _StillImage;
		}
	}

	[Field("kCICategoryInterlaced", "Quartz")]
	public static NSString Interlaced
	{
		get
		{
			if (_Interlaced == null)
			{
				_Interlaced = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryInterlaced");
			}
			return _Interlaced;
		}
	}

	[Field("kCICategoryNonSquarePixels", "Quartz")]
	public static NSString NonSquarePixels
	{
		get
		{
			if (_NonSquarePixels == null)
			{
				_NonSquarePixels = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryNonSquarePixels");
			}
			return _NonSquarePixels;
		}
	}

	[Field("kCICategoryHighDynamicRange", "Quartz")]
	public static NSString HighDynamicRange
	{
		get
		{
			if (_HighDynamicRange == null)
			{
				_HighDynamicRange = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryHighDynamicRange");
			}
			return _HighDynamicRange;
		}
	}

	[Field("kCICategoryBuiltIn", "Quartz")]
	public static NSString BuiltIn
	{
		get
		{
			if (_BuiltIn == null)
			{
				_BuiltIn = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryBuiltIn");
			}
			return _BuiltIn;
		}
	}

	[Field("kCICategoryFilterGenerator", "Quartz")]
	public static NSString FilterGenerator
	{
		get
		{
			if (_FilterGenerator == null)
			{
				_FilterGenerator = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryFilterGenerator");
			}
			return _FilterGenerator;
		}
	}
}

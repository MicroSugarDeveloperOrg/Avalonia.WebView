using Foundation;
using ObjCRuntime;

namespace CoreImage;

public static class CIFilterCategory
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Blur;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BuiltIn;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorAdjustment;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorEffect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CompositeOperation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DistortionEffect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FilterGenerator;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Generator;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GeometryAdjustment;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Gradient;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HalftoneEffect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HighDynamicRange;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Interlaced;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NonSquarePixels;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Reduction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Sharpen;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _StillImage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Stylize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TileEffect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Transition;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Video;

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

	[Field("kCICategoryFilterGenerator", "Quartz")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public static NSString FilterGenerator
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FilterGenerator == null)
			{
				_FilterGenerator = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCICategoryFilterGenerator");
			}
			return _FilterGenerator;
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
}

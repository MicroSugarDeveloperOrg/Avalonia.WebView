using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal static class CIImageInitializationOptionsKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplyOrientationPropertyKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuxiliaryDepthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuxiliaryDisparityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuxiliaryPortraitEffectsMatteKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuxiliarySemanticSegmentationHairMatteKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuxiliarySemanticSegmentationSkinMatteKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuxiliarySemanticSegmentationTeethMatteKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorSpaceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NearestSamplingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertiesKey;

	[Field("kCIImageApplyOrientationProperty", "CoreImage")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString ApplyOrientationPropertyKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_ApplyOrientationPropertyKey == null)
			{
				_ApplyOrientationPropertyKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageApplyOrientationProperty");
			}
			return _ApplyOrientationPropertyKey;
		}
	}

	[Field("kCIImageAuxiliaryDepth", "CoreImage")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString AuxiliaryDepthKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_AuxiliaryDepthKey == null)
			{
				_AuxiliaryDepthKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAuxiliaryDepth");
			}
			return _AuxiliaryDepthKey;
		}
	}

	[Field("kCIImageAuxiliaryDisparity", "CoreImage")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString AuxiliaryDisparityKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_AuxiliaryDisparityKey == null)
			{
				_AuxiliaryDisparityKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAuxiliaryDisparity");
			}
			return _AuxiliaryDisparityKey;
		}
	}

	[Field("kCIImageAuxiliaryPortraitEffectsMatte", "CoreImage")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSString AuxiliaryPortraitEffectsMatteKey
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_AuxiliaryPortraitEffectsMatteKey == null)
			{
				_AuxiliaryPortraitEffectsMatteKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAuxiliaryPortraitEffectsMatte");
			}
			return _AuxiliaryPortraitEffectsMatteKey;
		}
	}

	[Field("kCIImageAuxiliarySemanticSegmentationHairMatte", "CoreImage")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString AuxiliarySemanticSegmentationHairMatteKey
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_AuxiliarySemanticSegmentationHairMatteKey == null)
			{
				_AuxiliarySemanticSegmentationHairMatteKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAuxiliarySemanticSegmentationHairMatte");
			}
			return _AuxiliarySemanticSegmentationHairMatteKey;
		}
	}

	[Field("kCIImageAuxiliarySemanticSegmentationSkinMatte", "CoreImage")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString AuxiliarySemanticSegmentationSkinMatteKey
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_AuxiliarySemanticSegmentationSkinMatteKey == null)
			{
				_AuxiliarySemanticSegmentationSkinMatteKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAuxiliarySemanticSegmentationSkinMatte");
			}
			return _AuxiliarySemanticSegmentationSkinMatteKey;
		}
	}

	[Field("kCIImageAuxiliarySemanticSegmentationTeethMatte", "CoreImage")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString AuxiliarySemanticSegmentationTeethMatteKey
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_AuxiliarySemanticSegmentationTeethMatteKey == null)
			{
				_AuxiliarySemanticSegmentationTeethMatteKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageAuxiliarySemanticSegmentationTeethMatte");
			}
			return _AuxiliarySemanticSegmentationTeethMatteKey;
		}
	}

	[Field("kCIImageColorSpace", "CoreImage")]
	public static NSString ColorSpaceKey
	{
		get
		{
			if (_ColorSpaceKey == null)
			{
				_ColorSpaceKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageColorSpace");
			}
			return _ColorSpaceKey;
		}
	}

	[Field("kCIImageNearestSampling", "CoreImage")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString NearestSamplingKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_NearestSamplingKey == null)
			{
				_NearestSamplingKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageNearestSampling");
			}
			return _NearestSamplingKey;
		}
	}

	[Field("kCIImageProperties", "CoreImage")]
	public static NSString PropertiesKey
	{
		get
		{
			if (_PropertiesKey == null)
			{
				_PropertiesKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageProperties");
			}
			return _PropertiesKey;
		}
	}
}

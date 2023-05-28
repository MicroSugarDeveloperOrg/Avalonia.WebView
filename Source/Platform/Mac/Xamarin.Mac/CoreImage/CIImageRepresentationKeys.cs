using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
internal static class CIImageRepresentationKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVDepthDataKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AVPortraitEffectsMatteKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DepthImageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisparityImageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LossyCompressionQualityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PortraitEffectsMatteImageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SemanticSegmentationHairMatteImageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SemanticSegmentationMattesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SemanticSegmentationSkinMatteImageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SemanticSegmentationTeethMatteImageKey;

	[Field("kCIImageRepresentationAVDepthData", "CoreImage")]
	public static NSString AVDepthDataKey
	{
		get
		{
			if (_AVDepthDataKey == null)
			{
				_AVDepthDataKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageRepresentationAVDepthData");
			}
			return _AVDepthDataKey;
		}
	}

	[Field("kCIImageRepresentationAVPortraitEffectsMatte", "CoreImage")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSString AVPortraitEffectsMatteKey
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_AVPortraitEffectsMatteKey == null)
			{
				_AVPortraitEffectsMatteKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageRepresentationAVPortraitEffectsMatte");
			}
			return _AVPortraitEffectsMatteKey;
		}
	}

	[Field("kCIImageRepresentationDepthImage", "CoreImage")]
	public static NSString DepthImageKey
	{
		get
		{
			if (_DepthImageKey == null)
			{
				_DepthImageKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageRepresentationDepthImage");
			}
			return _DepthImageKey;
		}
	}

	[Field("kCIImageRepresentationDisparityImage", "CoreImage")]
	public static NSString DisparityImageKey
	{
		get
		{
			if (_DisparityImageKey == null)
			{
				_DisparityImageKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageRepresentationDisparityImage");
			}
			return _DisparityImageKey;
		}
	}

	[Field("kCGImageDestinationLossyCompressionQuality", "ImageIO")]
	public static NSString LossyCompressionQualityKey
	{
		get
		{
			if (_LossyCompressionQualityKey == null)
			{
				_LossyCompressionQualityKey = Dlfcn.GetStringConstant(Libraries.ImageIO.Handle, "kCGImageDestinationLossyCompressionQuality");
			}
			return _LossyCompressionQualityKey;
		}
	}

	[Field("kCIImageRepresentationPortraitEffectsMatteImage", "CoreImage")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static NSString PortraitEffectsMatteImageKey
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			if (_PortraitEffectsMatteImageKey == null)
			{
				_PortraitEffectsMatteImageKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageRepresentationPortraitEffectsMatteImage");
			}
			return _PortraitEffectsMatteImageKey;
		}
	}

	[Field("kCIImageRepresentationSemanticSegmentationHairMatteImage", "CoreImage")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString SemanticSegmentationHairMatteImageKey
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_SemanticSegmentationHairMatteImageKey == null)
			{
				_SemanticSegmentationHairMatteImageKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageRepresentationSemanticSegmentationHairMatteImage");
			}
			return _SemanticSegmentationHairMatteImageKey;
		}
	}

	[Field("kCIImageRepresentationAVSemanticSegmentationMattes", "CoreImage")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString SemanticSegmentationMattesKey
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_SemanticSegmentationMattesKey == null)
			{
				_SemanticSegmentationMattesKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageRepresentationAVSemanticSegmentationMattes");
			}
			return _SemanticSegmentationMattesKey;
		}
	}

	[Field("kCIImageRepresentationSemanticSegmentationSkinMatteImage", "CoreImage")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString SemanticSegmentationSkinMatteImageKey
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_SemanticSegmentationSkinMatteImageKey == null)
			{
				_SemanticSegmentationSkinMatteImageKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageRepresentationSemanticSegmentationSkinMatteImage");
			}
			return _SemanticSegmentationSkinMatteImageKey;
		}
	}

	[Field("kCIImageRepresentationSemanticSegmentationTeethMatteImage", "CoreImage")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString SemanticSegmentationTeethMatteImageKey
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_SemanticSegmentationTeethMatteImageKey == null)
			{
				_SemanticSegmentationTeethMatteImageKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIImageRepresentationSemanticSegmentationTeethMatteImage");
			}
			return _SemanticSegmentationTeethMatteImageKey;
		}
	}
}

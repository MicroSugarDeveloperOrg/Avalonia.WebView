using AVFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class CIImageRepresentationOptions : DictionaryContainer
{
	public float? LossyCompressionQuality
	{
		get
		{
			return GetFloatValue(CIImageRepresentationKeys.LossyCompressionQualityKey);
		}
		set
		{
			SetNumberValue(CIImageRepresentationKeys.LossyCompressionQualityKey, value);
		}
	}

	public AVDepthData? AVDepthData
	{
		get
		{
			return base.Dictionary[CIImageRepresentationKeys.AVDepthDataKey] as AVDepthData;
		}
		set
		{
			SetNativeValue(CIImageRepresentationKeys.AVDepthDataKey, value);
		}
	}

	public CIImage? DepthImage
	{
		get
		{
			return base.Dictionary[CIImageRepresentationKeys.DepthImageKey] as CIImage;
		}
		set
		{
			SetNativeValue(CIImageRepresentationKeys.DepthImageKey, value);
		}
	}

	public CIImage? DisparityImage
	{
		get
		{
			return base.Dictionary[CIImageRepresentationKeys.DisparityImageKey] as CIImage;
		}
		set
		{
			SetNativeValue(CIImageRepresentationKeys.DisparityImageKey, value);
		}
	}

	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public CIImage? PortraitEffectsMatteImage
	{
		get
		{
			return base.Dictionary[CIImageRepresentationKeys.PortraitEffectsMatteImageKey] as CIImage;
		}
		set
		{
			SetNativeValue(CIImageRepresentationKeys.PortraitEffectsMatteImageKey, value);
		}
	}

	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public AVPortraitEffectsMatte? AVPortraitEffectsMatte
	{
		get
		{
			return base.Dictionary[CIImageRepresentationKeys.AVPortraitEffectsMatteKey] as AVPortraitEffectsMatte;
		}
		set
		{
			SetNativeValue(CIImageRepresentationKeys.AVPortraitEffectsMatteKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public AVSemanticSegmentationMatte[]? SemanticSegmentationMattes
	{
		get
		{
			return GetArray<AVSemanticSegmentationMatte>(CIImageRepresentationKeys.SemanticSegmentationMattesKey);
		}
		set
		{
			SetArrayValue(CIImageRepresentationKeys.SemanticSegmentationMattesKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public CIImage? SemanticSegmentationSkinMatteImage
	{
		get
		{
			return base.Dictionary[CIImageRepresentationKeys.SemanticSegmentationSkinMatteImageKey] as CIImage;
		}
		set
		{
			SetNativeValue(CIImageRepresentationKeys.SemanticSegmentationSkinMatteImageKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public CIImage? SemanticSegmentationHairMatteImage
	{
		get
		{
			return base.Dictionary[CIImageRepresentationKeys.SemanticSegmentationHairMatteImageKey] as CIImage;
		}
		set
		{
			SetNativeValue(CIImageRepresentationKeys.SemanticSegmentationHairMatteImageKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public CIImage? SemanticSegmentationTeethMatteImage
	{
		get
		{
			return base.Dictionary[CIImageRepresentationKeys.SemanticSegmentationTeethMatteImageKey] as CIImage;
		}
		set
		{
			SetNativeValue(CIImageRepresentationKeys.SemanticSegmentationTeethMatteImageKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public CIImageRepresentationOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CIImageRepresentationOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}

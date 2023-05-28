using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public class CIImageInitializationOptions : DictionaryContainer
{
	public CGColorSpace ColorSpace
	{
		get
		{
			return GetNativeValue<CGColorSpace>(CIImageInitializationOptionsKeys.ColorSpaceKey);
		}
		set
		{
			SetNativeValue(CIImageInitializationOptionsKeys.ColorSpaceKey, (value == null) ? null : value);
		}
	}

	public CGImageProperties? Properties
	{
		get
		{
			return GetStrongDictionary<CGImageProperties>(CIImageInitializationOptionsKeys.PropertiesKey);
		}
		set
		{
			SetNativeValue(CIImageInitializationOptionsKeys.PropertiesKey, value.GetDictionary());
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public bool? ApplyOrientationProperty
	{
		get
		{
			return GetBoolValue(CIImageInitializationOptionsKeys.ApplyOrientationPropertyKey);
		}
		set
		{
			SetBooleanValue(CIImageInitializationOptionsKeys.ApplyOrientationPropertyKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public bool? NearestSampling
	{
		get
		{
			return GetBoolValue(CIImageInitializationOptionsKeys.NearestSamplingKey);
		}
		set
		{
			SetBooleanValue(CIImageInitializationOptionsKeys.NearestSamplingKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public bool? AuxiliaryDepth
	{
		get
		{
			return GetBoolValue(CIImageInitializationOptionsKeys.AuxiliaryDepthKey);
		}
		set
		{
			SetBooleanValue(CIImageInitializationOptionsKeys.AuxiliaryDepthKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public bool? AuxiliaryDisparity
	{
		get
		{
			return GetBoolValue(CIImageInitializationOptionsKeys.AuxiliaryDisparityKey);
		}
		set
		{
			SetBooleanValue(CIImageInitializationOptionsKeys.AuxiliaryDisparityKey, value);
		}
	}

	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public bool? AuxiliaryPortraitEffectsMatte
	{
		get
		{
			return GetBoolValue(CIImageInitializationOptionsKeys.AuxiliaryPortraitEffectsMatteKey);
		}
		set
		{
			SetBooleanValue(CIImageInitializationOptionsKeys.AuxiliaryPortraitEffectsMatteKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public bool? AuxiliarySemanticSegmentationSkinMatte
	{
		get
		{
			return GetBoolValue(CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationSkinMatteKey);
		}
		set
		{
			SetBooleanValue(CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationSkinMatteKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public bool? AuxiliarySemanticSegmentationHairMatte
	{
		get
		{
			return GetBoolValue(CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationHairMatteKey);
		}
		set
		{
			SetBooleanValue(CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationHairMatteKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public bool? AuxiliarySemanticSegmentationTeethMatte
	{
		get
		{
			return GetBoolValue(CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationTeethMatteKey);
		}
		set
		{
			SetBooleanValue(CIImageInitializationOptionsKeys.AuxiliarySemanticSegmentationTeethMatteKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public CIImageInitializationOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CIImageInitializationOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}

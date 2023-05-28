using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
public class CIRawFilterOptions : DictionaryContainer
{
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public bool? AllowDraftMode
	{
		get
		{
			return GetBoolValue(CIRawFilterKeys.AllowDraftModeKey);
		}
		set
		{
			SetBooleanValue(CIRawFilterKeys.AllowDraftModeKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public string? Version
	{
		get
		{
			return GetStringValue(CIRawFilterKeys.VersionKey);
		}
		set
		{
			SetStringValue(CIRawFilterKeys.VersionKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public NSDictionary[]? SupportedDecoderVersions
	{
		get
		{
			return GetArray<NSDictionary>(CIRawFilterKeys.SupportedDecoderVersionsKey);
		}
		set
		{
			SetArrayValue(CIRawFilterKeys.SupportedDecoderVersionsKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public float? BaselineExposure
	{
		get
		{
			return GetFloatValue(CIRawFilterKeys.BaselineExposureKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.BaselineExposureKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public float? Boost
	{
		get
		{
			return GetFloatValue(CIRawFilterKeys.BoostKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.BoostKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public float? BoostShadowAmount
	{
		get
		{
			return GetFloatValue(CIRawFilterKeys.BoostShadowAmountKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.BoostShadowAmountKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public bool? DisableGamutMap
	{
		get
		{
			return GetBoolValue(CIRawFilterKeys.DisableGamutMapKey);
		}
		set
		{
			SetBooleanValue(CIRawFilterKeys.DisableGamutMapKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public float? NeutralChromaticityX
	{
		get
		{
			return GetFloatValue(CIRawFilterKeys.NeutralChromaticityXKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.NeutralChromaticityXKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public float? NeutralChromaticityY
	{
		get
		{
			return GetFloatValue(CIRawFilterKeys.NeutralChromaticityYKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.NeutralChromaticityYKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public float? NeutralTemperature
	{
		get
		{
			return GetFloatValue(CIRawFilterKeys.NeutralTemperatureKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.NeutralTemperatureKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public float? NeutralTint
	{
		get
		{
			return GetFloatValue(CIRawFilterKeys.NeutralTintKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.NeutralTintKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public CIVector? NeutralLocation
	{
		get
		{
			return base.Dictionary[CIRawFilterKeys.NeutralLocationKey] as CIVector;
		}
		set
		{
			SetNativeValue(CIRawFilterKeys.NeutralLocationKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public float? ScaleFactor
	{
		get
		{
			return GetFloatValue(CIRawFilterKeys.ScaleFactorKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.ScaleFactorKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public bool? IgnoreImageOrientation
	{
		get
		{
			return GetBoolValue(CIRawFilterKeys.IgnoreImageOrientationKey);
		}
		set
		{
			SetBooleanValue(CIRawFilterKeys.IgnoreImageOrientationKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public int? ImageOrientation
	{
		get
		{
			return GetInt32Value(CIRawFilterKeys.ImageOrientationKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.ImageOrientationKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public bool? EnableSharpening
	{
		get
		{
			return GetBoolValue(CIRawFilterKeys.EnableSharpeningKey);
		}
		set
		{
			SetBooleanValue(CIRawFilterKeys.EnableSharpeningKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public bool? EnableChromaticNoiseTracking
	{
		get
		{
			return GetBoolValue(CIRawFilterKeys.EnableChromaticNoiseTrackingKey);
		}
		set
		{
			SetBooleanValue(CIRawFilterKeys.EnableChromaticNoiseTrackingKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public double? NoiseReductionAmount
	{
		get
		{
			return GetDoubleValue(CIRawFilterKeys.NoiseReductionAmountKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.NoiseReductionAmountKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public bool? EnableVendorLensCorrection
	{
		get
		{
			return GetBoolValue(CIRawFilterKeys.EnableVendorLensCorrectionKey);
		}
		set
		{
			SetBooleanValue(CIRawFilterKeys.EnableVendorLensCorrectionKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public double? LuminanceNoiseReductionAmount
	{
		get
		{
			return GetDoubleValue(CIRawFilterKeys.LuminanceNoiseReductionAmountKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.LuminanceNoiseReductionAmountKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public double? ColorNoiseReductionAmount
	{
		get
		{
			return GetDoubleValue(CIRawFilterKeys.ColorNoiseReductionAmountKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.ColorNoiseReductionAmountKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public double? NoiseReductionSharpnessAmount
	{
		get
		{
			return GetDoubleValue(CIRawFilterKeys.NoiseReductionSharpnessAmountKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.NoiseReductionSharpnessAmountKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public double? NoiseReductionContrastAmount
	{
		get
		{
			return GetDoubleValue(CIRawFilterKeys.NoiseReductionContrastAmountKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.NoiseReductionContrastAmountKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public double? NoiseReductionDetailAmount
	{
		get
		{
			return GetDoubleValue(CIRawFilterKeys.NoiseReductionDetailAmountKey);
		}
		set
		{
			SetNumberValue(CIRawFilterKeys.NoiseReductionDetailAmountKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public CIFilter? LinearSpaceFilter
	{
		get
		{
			return base.Dictionary[CIRawFilterKeys.LinearSpaceFilterKey] as CIFilter;
		}
		set
		{
			SetNativeValue(CIRawFilterKeys.LinearSpaceFilterKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public CIVector? OutputNativeSize
	{
		get
		{
			return base.Dictionary[CIRawFilterKeys.OutputNativeSizeKey] as CIVector;
		}
		set
		{
			SetNativeValue(CIRawFilterKeys.OutputNativeSizeKey, value);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public NSSet? ActiveKeys => base.Dictionary[CIRawFilterKeys.ActiveKeysKey] as NSSet;

	[Preserve(Conditional = true)]
	public CIRawFilterOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CIRawFilterOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}

using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
internal static class CIRawFilterKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ActiveKeysKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowDraftModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BaselineExposureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BoostKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BoostShadowAmountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorNoiseReductionAmountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisableGamutMapKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EnableChromaticNoiseTrackingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EnableEdrModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EnableSharpeningKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EnableVendorLensCorrectionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IgnoreImageOrientationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ImageOrientationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LinearSpaceFilterKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LuminanceNoiseReductionAmountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MoireAmountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NeutralChromaticityXKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NeutralChromaticityYKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NeutralLocationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NeutralTemperatureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NeutralTintKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NoiseReductionAmountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NoiseReductionContrastAmountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NoiseReductionDetailAmountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NoiseReductionSharpnessAmountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OutputNativeSizeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScaleFactorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SupportedDecoderVersionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VersionKey;

	[Field("kCIActiveKeys", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString ActiveKeysKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ActiveKeysKey == null)
			{
				_ActiveKeysKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIActiveKeys");
			}
			return _ActiveKeysKey;
		}
	}

	[Field("kCIInputAllowDraftModeKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString AllowDraftModeKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AllowDraftModeKey == null)
			{
				_AllowDraftModeKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputAllowDraftModeKey");
			}
			return _AllowDraftModeKey;
		}
	}

	[Field("kCIInputBaselineExposureKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString BaselineExposureKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_BaselineExposureKey == null)
			{
				_BaselineExposureKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputBaselineExposureKey");
			}
			return _BaselineExposureKey;
		}
	}

	[Field("kCIInputBoostKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString BoostKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_BoostKey == null)
			{
				_BoostKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputBoostKey");
			}
			return _BoostKey;
		}
	}

	[Field("kCIInputBoostShadowAmountKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString BoostShadowAmountKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_BoostShadowAmountKey == null)
			{
				_BoostShadowAmountKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputBoostShadowAmountKey");
			}
			return _BoostShadowAmountKey;
		}
	}

	[Field("kCIInputColorNoiseReductionAmountKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString ColorNoiseReductionAmountKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_ColorNoiseReductionAmountKey == null)
			{
				_ColorNoiseReductionAmountKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputColorNoiseReductionAmountKey");
			}
			return _ColorNoiseReductionAmountKey;
		}
	}

	[Field("kCIInputDisableGamutMapKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString DisableGamutMapKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_DisableGamutMapKey == null)
			{
				_DisableGamutMapKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputDisableGamutMapKey");
			}
			return _DisableGamutMapKey;
		}
	}

	[Field("kCIInputEnableChromaticNoiseTrackingKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString EnableChromaticNoiseTrackingKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_EnableChromaticNoiseTrackingKey == null)
			{
				_EnableChromaticNoiseTrackingKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputEnableChromaticNoiseTrackingKey");
			}
			return _EnableChromaticNoiseTrackingKey;
		}
	}

	[Field("kCIInputEnableEDRModeKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString EnableEdrModeKey
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_EnableEdrModeKey == null)
			{
				_EnableEdrModeKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputEnableEDRModeKey");
			}
			return _EnableEdrModeKey;
		}
	}

	[Field("kCIInputEnableSharpeningKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString EnableSharpeningKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_EnableSharpeningKey == null)
			{
				_EnableSharpeningKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputEnableSharpeningKey");
			}
			return _EnableSharpeningKey;
		}
	}

	[Field("kCIInputEnableVendorLensCorrectionKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString EnableVendorLensCorrectionKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_EnableVendorLensCorrectionKey == null)
			{
				_EnableVendorLensCorrectionKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputEnableVendorLensCorrectionKey");
			}
			return _EnableVendorLensCorrectionKey;
		}
	}

	[Field("kCIInputIgnoreImageOrientationKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString IgnoreImageOrientationKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_IgnoreImageOrientationKey == null)
			{
				_IgnoreImageOrientationKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputIgnoreImageOrientationKey");
			}
			return _IgnoreImageOrientationKey;
		}
	}

	[Field("kCIInputImageOrientationKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString ImageOrientationKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ImageOrientationKey == null)
			{
				_ImageOrientationKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputImageOrientationKey");
			}
			return _ImageOrientationKey;
		}
	}

	[Field("kCIInputLinearSpaceFilter", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString LinearSpaceFilterKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_LinearSpaceFilterKey == null)
			{
				_LinearSpaceFilterKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputLinearSpaceFilter");
			}
			return _LinearSpaceFilterKey;
		}
	}

	[Field("kCIInputLuminanceNoiseReductionAmountKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString LuminanceNoiseReductionAmountKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_LuminanceNoiseReductionAmountKey == null)
			{
				_LuminanceNoiseReductionAmountKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputLuminanceNoiseReductionAmountKey");
			}
			return _LuminanceNoiseReductionAmountKey;
		}
	}

	[Field("kCIInputMoireAmountKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString MoireAmountKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_MoireAmountKey == null)
			{
				_MoireAmountKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputMoireAmountKey");
			}
			return _MoireAmountKey;
		}
	}

	[Field("kCIInputNeutralChromaticityXKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString NeutralChromaticityXKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_NeutralChromaticityXKey == null)
			{
				_NeutralChromaticityXKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputNeutralChromaticityXKey");
			}
			return _NeutralChromaticityXKey;
		}
	}

	[Field("kCIInputNeutralChromaticityYKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString NeutralChromaticityYKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_NeutralChromaticityYKey == null)
			{
				_NeutralChromaticityYKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputNeutralChromaticityYKey");
			}
			return _NeutralChromaticityYKey;
		}
	}

	[Field("kCIInputNeutralLocationKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString NeutralLocationKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_NeutralLocationKey == null)
			{
				_NeutralLocationKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputNeutralLocationKey");
			}
			return _NeutralLocationKey;
		}
	}

	[Field("kCIInputNeutralTemperatureKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString NeutralTemperatureKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_NeutralTemperatureKey == null)
			{
				_NeutralTemperatureKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputNeutralTemperatureKey");
			}
			return _NeutralTemperatureKey;
		}
	}

	[Field("kCIInputNeutralTintKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString NeutralTintKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_NeutralTintKey == null)
			{
				_NeutralTintKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputNeutralTintKey");
			}
			return _NeutralTintKey;
		}
	}

	[Field("kCIInputNoiseReductionAmountKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString NoiseReductionAmountKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_NoiseReductionAmountKey == null)
			{
				_NoiseReductionAmountKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputNoiseReductionAmountKey");
			}
			return _NoiseReductionAmountKey;
		}
	}

	[Field("kCIInputNoiseReductionContrastAmountKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString NoiseReductionContrastAmountKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_NoiseReductionContrastAmountKey == null)
			{
				_NoiseReductionContrastAmountKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputNoiseReductionContrastAmountKey");
			}
			return _NoiseReductionContrastAmountKey;
		}
	}

	[Field("kCIInputNoiseReductionDetailAmountKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString NoiseReductionDetailAmountKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_NoiseReductionDetailAmountKey == null)
			{
				_NoiseReductionDetailAmountKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputNoiseReductionDetailAmountKey");
			}
			return _NoiseReductionDetailAmountKey;
		}
	}

	[Field("kCIInputNoiseReductionSharpnessAmountKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString NoiseReductionSharpnessAmountKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_NoiseReductionSharpnessAmountKey == null)
			{
				_NoiseReductionSharpnessAmountKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputNoiseReductionSharpnessAmountKey");
			}
			return _NoiseReductionSharpnessAmountKey;
		}
	}

	[Field("kCIOutputNativeSizeKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString OutputNativeSizeKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_OutputNativeSizeKey == null)
			{
				_OutputNativeSizeKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIOutputNativeSizeKey");
			}
			return _OutputNativeSizeKey;
		}
	}

	[Field("kCIInputScaleFactorKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString ScaleFactorKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ScaleFactorKey == null)
			{
				_ScaleFactorKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputScaleFactorKey");
			}
			return _ScaleFactorKey;
		}
	}

	[Field("kCISupportedDecoderVersionsKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString SupportedDecoderVersionsKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_SupportedDecoderVersionsKey == null)
			{
				_SupportedDecoderVersionsKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCISupportedDecoderVersionsKey");
			}
			return _SupportedDecoderVersionsKey;
		}
	}

	[Field("kCIInputDecoderVersionKey", "CoreImage")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString VersionKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_VersionKey == null)
			{
				_VersionKey = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "kCIInputDecoderVersionKey");
			}
			return _VersionKey;
		}
	}
}

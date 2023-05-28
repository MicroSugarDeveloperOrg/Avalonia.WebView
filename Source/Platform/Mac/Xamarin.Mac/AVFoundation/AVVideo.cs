using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class AVVideo
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowFrameReorderingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleProRes422;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AppleProRes4444;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AverageBitRateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AverageNonDroppableFrameRateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanApertureHeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanApertureHorizontalOffsetKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanApertureKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanApertureVerticalOffsetKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanApertureWidthKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CodecH264;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CodecJPEG;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CodecKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CompressionPropertiesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EncoderSpecificationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExpectedSourceFrameRateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _H264EntropyModeCABAC;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _H264EntropyModeCAVLC;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _H264EntropyModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaxKeyFrameIntervalDurationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaxKeyFrameIntervalKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelAspectRatioHorizontalSpacingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelAspectRatioKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelAspectRatioVerticalSpacingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264Baseline30;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264Baseline31;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264Baseline41;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264BaselineAutoLevel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264High40;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264High41;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264HighAutoLevel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264Main30;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264Main31;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264Main32;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264Main41;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelH264MainAutoLevel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevelKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QualityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ScalingModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WidthKey;

	[Field("AVVideoAllowFrameReorderingKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString AllowFrameReorderingKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_AllowFrameReorderingKey == null)
			{
				_AllowFrameReorderingKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoAllowFrameReorderingKey");
			}
			return _AllowFrameReorderingKey;
		}
	}

	[Field("AVVideoCodecAppleProRes422", "AVFoundation")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString AppleProRes422
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_AppleProRes422 == null)
			{
				_AppleProRes422 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCodecAppleProRes422");
			}
			return _AppleProRes422;
		}
	}

	[Field("AVVideoCodecAppleProRes4444", "AVFoundation")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public static NSString AppleProRes4444
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		get
		{
			if (_AppleProRes4444 == null)
			{
				_AppleProRes4444 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCodecAppleProRes4444");
			}
			return _AppleProRes4444;
		}
	}

	[Field("AVVideoAverageBitRateKey", "AVFoundation")]
	public static NSString AverageBitRateKey
	{
		get
		{
			if (_AverageBitRateKey == null)
			{
				_AverageBitRateKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoAverageBitRateKey");
			}
			return _AverageBitRateKey;
		}
	}

	[Field("AVVideoAverageNonDroppableFrameRateKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString AverageNonDroppableFrameRateKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_AverageNonDroppableFrameRateKey == null)
			{
				_AverageNonDroppableFrameRateKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoAverageNonDroppableFrameRateKey");
			}
			return _AverageNonDroppableFrameRateKey;
		}
	}

	[Field("AVVideoCleanApertureHeightKey", "AVFoundation")]
	public static NSString CleanApertureHeightKey
	{
		get
		{
			if (_CleanApertureHeightKey == null)
			{
				_CleanApertureHeightKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCleanApertureHeightKey");
			}
			return _CleanApertureHeightKey;
		}
	}

	[Field("AVVideoCleanApertureHorizontalOffsetKey", "AVFoundation")]
	public static NSString CleanApertureHorizontalOffsetKey
	{
		get
		{
			if (_CleanApertureHorizontalOffsetKey == null)
			{
				_CleanApertureHorizontalOffsetKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCleanApertureHorizontalOffsetKey");
			}
			return _CleanApertureHorizontalOffsetKey;
		}
	}

	[Field("AVVideoCleanApertureKey", "AVFoundation")]
	public static NSString CleanApertureKey
	{
		get
		{
			if (_CleanApertureKey == null)
			{
				_CleanApertureKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCleanApertureKey");
			}
			return _CleanApertureKey;
		}
	}

	[Field("AVVideoCleanApertureVerticalOffsetKey", "AVFoundation")]
	public static NSString CleanApertureVerticalOffsetKey
	{
		get
		{
			if (_CleanApertureVerticalOffsetKey == null)
			{
				_CleanApertureVerticalOffsetKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCleanApertureVerticalOffsetKey");
			}
			return _CleanApertureVerticalOffsetKey;
		}
	}

	[Field("AVVideoCleanApertureWidthKey", "AVFoundation")]
	public static NSString CleanApertureWidthKey
	{
		get
		{
			if (_CleanApertureWidthKey == null)
			{
				_CleanApertureWidthKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCleanApertureWidthKey");
			}
			return _CleanApertureWidthKey;
		}
	}

	[Field("AVVideoCodecH264", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
	public static NSString CodecH264
	{
		[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
		get
		{
			if (_CodecH264 == null)
			{
				_CodecH264 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCodecH264");
			}
			return _CodecH264;
		}
	}

	[Field("AVVideoCodecJPEG", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
	public static NSString CodecJPEG
	{
		[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'AVVideoCodecType' enum instead.")]
		get
		{
			if (_CodecJPEG == null)
			{
				_CodecJPEG = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCodecJPEG");
			}
			return _CodecJPEG;
		}
	}

	[Field("AVVideoCodecKey", "AVFoundation")]
	public static NSString CodecKey
	{
		get
		{
			if (_CodecKey == null)
			{
				_CodecKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCodecKey");
			}
			return _CodecKey;
		}
	}

	[Field("AVVideoCompressionPropertiesKey", "AVFoundation")]
	public static NSString CompressionPropertiesKey
	{
		get
		{
			if (_CompressionPropertiesKey == null)
			{
				_CompressionPropertiesKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCompressionPropertiesKey");
			}
			return _CompressionPropertiesKey;
		}
	}

	[Field("AVVideoEncoderSpecificationKey", "AVFoundation")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString EncoderSpecificationKey
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_EncoderSpecificationKey == null)
			{
				_EncoderSpecificationKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoEncoderSpecificationKey");
			}
			return _EncoderSpecificationKey;
		}
	}

	[Field("AVVideoExpectedSourceFrameRateKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString ExpectedSourceFrameRateKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_ExpectedSourceFrameRateKey == null)
			{
				_ExpectedSourceFrameRateKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoExpectedSourceFrameRateKey");
			}
			return _ExpectedSourceFrameRateKey;
		}
	}

	[Field("AVVideoH264EntropyModeCABAC", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString H264EntropyModeCABAC
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_H264EntropyModeCABAC == null)
			{
				_H264EntropyModeCABAC = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoH264EntropyModeCABAC");
			}
			return _H264EntropyModeCABAC;
		}
	}

	[Field("AVVideoH264EntropyModeCAVLC", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString H264EntropyModeCAVLC
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_H264EntropyModeCAVLC == null)
			{
				_H264EntropyModeCAVLC = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoH264EntropyModeCAVLC");
			}
			return _H264EntropyModeCAVLC;
		}
	}

	[Field("AVVideoH264EntropyModeKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString H264EntropyModeKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_H264EntropyModeKey == null)
			{
				_H264EntropyModeKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoH264EntropyModeKey");
			}
			return _H264EntropyModeKey;
		}
	}

	[Field("AVVideoHeightKey", "AVFoundation")]
	public static NSString HeightKey
	{
		get
		{
			if (_HeightKey == null)
			{
				_HeightKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoHeightKey");
			}
			return _HeightKey;
		}
	}

	[Field("AVVideoMaxKeyFrameIntervalDurationKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString MaxKeyFrameIntervalDurationKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_MaxKeyFrameIntervalDurationKey == null)
			{
				_MaxKeyFrameIntervalDurationKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoMaxKeyFrameIntervalDurationKey");
			}
			return _MaxKeyFrameIntervalDurationKey;
		}
	}

	[Field("AVVideoMaxKeyFrameIntervalKey", "AVFoundation")]
	public static NSString MaxKeyFrameIntervalKey
	{
		get
		{
			if (_MaxKeyFrameIntervalKey == null)
			{
				_MaxKeyFrameIntervalKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoMaxKeyFrameIntervalKey");
			}
			return _MaxKeyFrameIntervalKey;
		}
	}

	[Field("AVVideoPixelAspectRatioHorizontalSpacingKey", "AVFoundation")]
	public static NSString PixelAspectRatioHorizontalSpacingKey
	{
		get
		{
			if (_PixelAspectRatioHorizontalSpacingKey == null)
			{
				_PixelAspectRatioHorizontalSpacingKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioHorizontalSpacingKey");
			}
			return _PixelAspectRatioHorizontalSpacingKey;
		}
	}

	[Field("AVVideoPixelAspectRatioKey", "AVFoundation")]
	public static NSString PixelAspectRatioKey
	{
		get
		{
			if (_PixelAspectRatioKey == null)
			{
				_PixelAspectRatioKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioKey");
			}
			return _PixelAspectRatioKey;
		}
	}

	[Field("AVVideoPixelAspectRatioVerticalSpacingKey", "AVFoundation")]
	public static NSString PixelAspectRatioVerticalSpacingKey
	{
		get
		{
			if (_PixelAspectRatioVerticalSpacingKey == null)
			{
				_PixelAspectRatioVerticalSpacingKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoPixelAspectRatioVerticalSpacingKey");
			}
			return _PixelAspectRatioVerticalSpacingKey;
		}
	}

	[Field("AVVideoProfileLevelH264Baseline30", "AVFoundation")]
	public static NSString ProfileLevelH264Baseline30
	{
		get
		{
			if (_ProfileLevelH264Baseline30 == null)
			{
				_ProfileLevelH264Baseline30 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Baseline30");
			}
			return _ProfileLevelH264Baseline30;
		}
	}

	[Field("AVVideoProfileLevelH264Baseline31", "AVFoundation")]
	public static NSString ProfileLevelH264Baseline31
	{
		get
		{
			if (_ProfileLevelH264Baseline31 == null)
			{
				_ProfileLevelH264Baseline31 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Baseline31");
			}
			return _ProfileLevelH264Baseline31;
		}
	}

	[Field("AVVideoProfileLevelH264Baseline41", "AVFoundation")]
	public static NSString ProfileLevelH264Baseline41
	{
		get
		{
			if (_ProfileLevelH264Baseline41 == null)
			{
				_ProfileLevelH264Baseline41 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Baseline41");
			}
			return _ProfileLevelH264Baseline41;
		}
	}

	[Field("AVVideoProfileLevelH264BaselineAutoLevel", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ProfileLevelH264BaselineAutoLevel
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ProfileLevelH264BaselineAutoLevel == null)
			{
				_ProfileLevelH264BaselineAutoLevel = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264BaselineAutoLevel");
			}
			return _ProfileLevelH264BaselineAutoLevel;
		}
	}

	[Field("AVVideoProfileLevelH264High40", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ProfileLevelH264High40
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ProfileLevelH264High40 == null)
			{
				_ProfileLevelH264High40 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264High40");
			}
			return _ProfileLevelH264High40;
		}
	}

	[Field("AVVideoProfileLevelH264High41", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ProfileLevelH264High41
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ProfileLevelH264High41 == null)
			{
				_ProfileLevelH264High41 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264High41");
			}
			return _ProfileLevelH264High41;
		}
	}

	[Field("AVVideoProfileLevelH264HighAutoLevel", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ProfileLevelH264HighAutoLevel
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ProfileLevelH264HighAutoLevel == null)
			{
				_ProfileLevelH264HighAutoLevel = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264HighAutoLevel");
			}
			return _ProfileLevelH264HighAutoLevel;
		}
	}

	[Field("AVVideoProfileLevelH264Main30", "AVFoundation")]
	public static NSString ProfileLevelH264Main30
	{
		get
		{
			if (_ProfileLevelH264Main30 == null)
			{
				_ProfileLevelH264Main30 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Main30");
			}
			return _ProfileLevelH264Main30;
		}
	}

	[Field("AVVideoProfileLevelH264Main31", "AVFoundation")]
	public static NSString ProfileLevelH264Main31
	{
		get
		{
			if (_ProfileLevelH264Main31 == null)
			{
				_ProfileLevelH264Main31 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Main31");
			}
			return _ProfileLevelH264Main31;
		}
	}

	[Field("AVVideoProfileLevelH264Main32", "AVFoundation")]
	public static NSString ProfileLevelH264Main32
	{
		get
		{
			if (_ProfileLevelH264Main32 == null)
			{
				_ProfileLevelH264Main32 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Main32");
			}
			return _ProfileLevelH264Main32;
		}
	}

	[Field("AVVideoProfileLevelH264Main41", "AVFoundation")]
	public static NSString ProfileLevelH264Main41
	{
		get
		{
			if (_ProfileLevelH264Main41 == null)
			{
				_ProfileLevelH264Main41 = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264Main41");
			}
			return _ProfileLevelH264Main41;
		}
	}

	[Field("AVVideoProfileLevelH264MainAutoLevel", "AVFoundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString ProfileLevelH264MainAutoLevel
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_ProfileLevelH264MainAutoLevel == null)
			{
				_ProfileLevelH264MainAutoLevel = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelH264MainAutoLevel");
			}
			return _ProfileLevelH264MainAutoLevel;
		}
	}

	[Field("AVVideoProfileLevelKey", "AVFoundation")]
	public static NSString ProfileLevelKey
	{
		get
		{
			if (_ProfileLevelKey == null)
			{
				_ProfileLevelKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoProfileLevelKey");
			}
			return _ProfileLevelKey;
		}
	}

	[Field("AVVideoQualityKey", "AVFoundation")]
	public static NSString QualityKey
	{
		get
		{
			if (_QualityKey == null)
			{
				_QualityKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoQualityKey");
			}
			return _QualityKey;
		}
	}

	[Field("AVVideoScalingModeKey", "AVFoundation")]
	public static NSString ScalingModeKey
	{
		get
		{
			if (_ScalingModeKey == null)
			{
				_ScalingModeKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoScalingModeKey");
			}
			return _ScalingModeKey;
		}
	}

	[Field("AVVideoWidthKey", "AVFoundation")]
	public static NSString WidthKey
	{
		get
		{
			if (_WidthKey == null)
			{
				_WidthKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoWidthKey");
			}
			return _WidthKey;
		}
	}
}

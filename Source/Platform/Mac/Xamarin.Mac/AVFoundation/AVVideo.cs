using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVVideo
{
	private static NSString _CodecKey;

	private static NSString _CodecH264;

	private static NSString _CodecJPEG;

	private static NSString _WidthKey;

	private static NSString _HeightKey;

	private static NSString _ScalingModeKey;

	private static NSString _CompressionPropertiesKey;

	private static NSString _AverageBitRateKey;

	private static NSString _MaxKeyFrameIntervalKey;

	private static NSString _ProfileLevelKey;

	private static NSString _QualityKey;

	private static NSString _ProfileLevelH264Baseline30;

	private static NSString _ProfileLevelH264Baseline31;

	private static NSString _ProfileLevelH264Main30;

	private static NSString _ProfileLevelH264Main31;

	private static NSString _ProfileLevelH264Baseline41;

	private static NSString _ProfileLevelH264Main32;

	private static NSString _ProfileLevelH264Main41;

	private static NSString _PixelAspectRatioKey;

	private static NSString _PixelAspectRatioHorizontalSpacingKey;

	private static NSString _PixelAspectRatioVerticalSpacingKey;

	private static NSString _CleanApertureKey;

	private static NSString _CleanApertureWidthKey;

	private static NSString _CleanApertureHeightKey;

	private static NSString _CleanApertureHorizontalOffsetKey;

	private static NSString _CleanApertureVerticalOffsetKey;

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

	[Field("AVVideoCodecH264", "AVFoundation")]
	public static NSString CodecH264
	{
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
	public static NSString CodecJPEG
	{
		get
		{
			if (_CodecJPEG == null)
			{
				_CodecJPEG = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVVideoCodecJPEG");
			}
			return _CodecJPEG;
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

	[Field("AVVideoProfileLevelH264Main32", "AVFoundation")]
	[MountainLion]
	public static NSString ProfileLevelH264Main32
	{
		[MountainLion]
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
}

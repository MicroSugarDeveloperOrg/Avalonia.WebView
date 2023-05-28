using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTCompressionPropertyKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowFrameReordering;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowOpenGop;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowTemporalCompression;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlphaChannelMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AspectRatio16x9;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AverageBitRate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BaseLayerFrameRate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CleanAperture;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorPrimaries;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentLightLevelInfo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataRateLimits;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Depth;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EncoderId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExpectedDuration;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExpectedFrameRate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldDetail;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GammaLevel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _H264EntropyMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ICCProfile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MasteringDisplayColorVolume;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaxFrameDelayCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaxH264SliceBytes;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaxKeyFrameInterval;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaxKeyFrameIntervalDuration;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaximizePowerEfficiency;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MoreFramesAfterEnd;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MoreFramesBeforeStart;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MultiPassStorage;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NumberOfPendingFrames;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelAspectRatio;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelBufferPoolIsShared;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelTransferProperties;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileLevel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProgressiveScan;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Quality;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RealTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SourceFrameCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TargetQualityForAlpha;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TransferFunction;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UsingGpuRegistryId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UsingHardwareAcceleratedVideoEncoder;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VideoEncoderPixelBufferAttributes;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _YCbCrMatrix;

	[Field("kVTCompressionPropertyKey_AllowFrameReordering", "VideoToolbox")]
	public static NSString AllowFrameReordering
	{
		get
		{
			if (_AllowFrameReordering == null)
			{
				_AllowFrameReordering = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AllowFrameReordering");
			}
			return _AllowFrameReordering;
		}
	}

	[Field("kVTCompressionPropertyKey_AllowOpenGOP", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString AllowOpenGop
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AllowOpenGop == null)
			{
				_AllowOpenGop = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AllowOpenGOP");
			}
			return _AllowOpenGop;
		}
	}

	[Field("kVTCompressionPropertyKey_AllowTemporalCompression", "VideoToolbox")]
	public static NSString AllowTemporalCompression
	{
		get
		{
			if (_AllowTemporalCompression == null)
			{
				_AllowTemporalCompression = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AllowTemporalCompression");
			}
			return _AllowTemporalCompression;
		}
	}

	[Field("kVTCompressionPropertyKey_AlphaChannelMode", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString AlphaChannelMode
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AlphaChannelMode == null)
			{
				_AlphaChannelMode = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AlphaChannelMode");
			}
			return _AlphaChannelMode;
		}
	}

	[Field("kVTCompressionPropertyKey_AspectRatio16x9", "VideoToolbox")]
	public static NSString AspectRatio16x9
	{
		get
		{
			if (_AspectRatio16x9 == null)
			{
				_AspectRatio16x9 = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AspectRatio16x9");
			}
			return _AspectRatio16x9;
		}
	}

	[Field("kVTCompressionPropertyKey_AverageBitRate", "VideoToolbox")]
	public static NSString AverageBitRate
	{
		get
		{
			if (_AverageBitRate == null)
			{
				_AverageBitRate = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_AverageBitRate");
			}
			return _AverageBitRate;
		}
	}

	[Field("kVTCompressionPropertyKey_BaseLayerFrameRate", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString BaseLayerFrameRate
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_BaseLayerFrameRate == null)
			{
				_BaseLayerFrameRate = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_BaseLayerFrameRate");
			}
			return _BaseLayerFrameRate;
		}
	}

	[Field("kVTCompressionPropertyKey_CleanAperture", "VideoToolbox")]
	public static NSString CleanAperture
	{
		get
		{
			if (_CleanAperture == null)
			{
				_CleanAperture = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_CleanAperture");
			}
			return _CleanAperture;
		}
	}

	[Field("kVTCompressionPropertyKey_ColorPrimaries", "VideoToolbox")]
	public static NSString ColorPrimaries
	{
		get
		{
			if (_ColorPrimaries == null)
			{
				_ColorPrimaries = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ColorPrimaries");
			}
			return _ColorPrimaries;
		}
	}

	[Field("kVTCompressionPropertyKey_ContentLightLevelInfo", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString ContentLightLevelInfo
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ContentLightLevelInfo == null)
			{
				_ContentLightLevelInfo = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ContentLightLevelInfo");
			}
			return _ContentLightLevelInfo;
		}
	}

	[Field("kVTCompressionPropertyKey_DataRateLimits", "VideoToolbox")]
	public static NSString DataRateLimits
	{
		get
		{
			if (_DataRateLimits == null)
			{
				_DataRateLimits = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_DataRateLimits");
			}
			return _DataRateLimits;
		}
	}

	[Field("kVTCompressionPropertyKey_Depth", "VideoToolbox")]
	public static NSString Depth
	{
		get
		{
			if (_Depth == null)
			{
				_Depth = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_Depth");
			}
			return _Depth;
		}
	}

	[Field("kVTCompressionPropertyKey_EncoderID", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString EncoderId
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_EncoderId == null)
			{
				_EncoderId = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_EncoderID");
			}
			return _EncoderId;
		}
	}

	[Field("kVTCompressionPropertyKey_ExpectedDuration", "VideoToolbox")]
	public static NSString ExpectedDuration
	{
		get
		{
			if (_ExpectedDuration == null)
			{
				_ExpectedDuration = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ExpectedDuration");
			}
			return _ExpectedDuration;
		}
	}

	[Field("kVTCompressionPropertyKey_ExpectedFrameRate", "VideoToolbox")]
	public static NSString ExpectedFrameRate
	{
		get
		{
			if (_ExpectedFrameRate == null)
			{
				_ExpectedFrameRate = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ExpectedFrameRate");
			}
			return _ExpectedFrameRate;
		}
	}

	[Field("kVTCompressionPropertyKey_FieldCount", "VideoToolbox")]
	public static NSString FieldCount
	{
		get
		{
			if (_FieldCount == null)
			{
				_FieldCount = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_FieldCount");
			}
			return _FieldCount;
		}
	}

	[Field("kVTCompressionPropertyKey_FieldDetail", "VideoToolbox")]
	public static NSString FieldDetail
	{
		get
		{
			if (_FieldDetail == null)
			{
				_FieldDetail = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_FieldDetail");
			}
			return _FieldDetail;
		}
	}

	[Field("kVTCompressionPropertyKey_GammaLevel", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString GammaLevel
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_GammaLevel == null)
			{
				_GammaLevel = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_GammaLevel");
			}
			return _GammaLevel;
		}
	}

	[Field("kVTCompressionPropertyKey_H264EntropyMode", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString H264EntropyMode
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_H264EntropyMode == null)
			{
				_H264EntropyMode = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_H264EntropyMode");
			}
			return _H264EntropyMode;
		}
	}

	[Field("kVTCompressionPropertyKey_ICCProfile", "VideoToolbox")]
	public static NSString ICCProfile
	{
		get
		{
			if (_ICCProfile == null)
			{
				_ICCProfile = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ICCProfile");
			}
			return _ICCProfile;
		}
	}

	[Field("kVTCompressionPropertyKey_MasteringDisplayColorVolume", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString MasteringDisplayColorVolume
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MasteringDisplayColorVolume == null)
			{
				_MasteringDisplayColorVolume = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MasteringDisplayColorVolume");
			}
			return _MasteringDisplayColorVolume;
		}
	}

	[Field("kVTCompressionPropertyKey_MaxFrameDelayCount", "VideoToolbox")]
	public static NSString MaxFrameDelayCount
	{
		get
		{
			if (_MaxFrameDelayCount == null)
			{
				_MaxFrameDelayCount = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaxFrameDelayCount");
			}
			return _MaxFrameDelayCount;
		}
	}

	[Field("kVTCompressionPropertyKey_MaxH264SliceBytes", "VideoToolbox")]
	public static NSString MaxH264SliceBytes
	{
		get
		{
			if (_MaxH264SliceBytes == null)
			{
				_MaxH264SliceBytes = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaxH264SliceBytes");
			}
			return _MaxH264SliceBytes;
		}
	}

	[Field("kVTCompressionPropertyKey_MaxKeyFrameInterval", "VideoToolbox")]
	public static NSString MaxKeyFrameInterval
	{
		get
		{
			if (_MaxKeyFrameInterval == null)
			{
				_MaxKeyFrameInterval = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaxKeyFrameInterval");
			}
			return _MaxKeyFrameInterval;
		}
	}

	[Field("kVTCompressionPropertyKey_MaxKeyFrameIntervalDuration", "VideoToolbox")]
	public static NSString MaxKeyFrameIntervalDuration
	{
		get
		{
			if (_MaxKeyFrameIntervalDuration == null)
			{
				_MaxKeyFrameIntervalDuration = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaxKeyFrameIntervalDuration");
			}
			return _MaxKeyFrameIntervalDuration;
		}
	}

	[Field("kVTCompressionPropertyKey_MaximizePowerEfficiency", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString MaximizePowerEfficiency
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_MaximizePowerEfficiency == null)
			{
				_MaximizePowerEfficiency = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MaximizePowerEfficiency");
			}
			return _MaximizePowerEfficiency;
		}
	}

	[Field("kVTCompressionPropertyKey_MoreFramesAfterEnd", "VideoToolbox")]
	public static NSString MoreFramesAfterEnd
	{
		get
		{
			if (_MoreFramesAfterEnd == null)
			{
				_MoreFramesAfterEnd = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MoreFramesAfterEnd");
			}
			return _MoreFramesAfterEnd;
		}
	}

	[Field("kVTCompressionPropertyKey_MoreFramesBeforeStart", "VideoToolbox")]
	public static NSString MoreFramesBeforeStart
	{
		get
		{
			if (_MoreFramesBeforeStart == null)
			{
				_MoreFramesBeforeStart = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MoreFramesBeforeStart");
			}
			return _MoreFramesBeforeStart;
		}
	}

	[Field("kVTCompressionPropertyKey_MultiPassStorage", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString MultiPassStorage
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_MultiPassStorage == null)
			{
				_MultiPassStorage = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_MultiPassStorage");
			}
			return _MultiPassStorage;
		}
	}

	[Field("kVTCompressionPropertyKey_NumberOfPendingFrames", "VideoToolbox")]
	public static NSString NumberOfPendingFrames
	{
		get
		{
			if (_NumberOfPendingFrames == null)
			{
				_NumberOfPendingFrames = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_NumberOfPendingFrames");
			}
			return _NumberOfPendingFrames;
		}
	}

	[Field("kVTCompressionPropertyKey_PixelAspectRatio", "VideoToolbox")]
	public static NSString PixelAspectRatio
	{
		get
		{
			if (_PixelAspectRatio == null)
			{
				_PixelAspectRatio = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_PixelAspectRatio");
			}
			return _PixelAspectRatio;
		}
	}

	[Field("kVTCompressionPropertyKey_PixelBufferPoolIsShared", "VideoToolbox")]
	public static NSString PixelBufferPoolIsShared
	{
		get
		{
			if (_PixelBufferPoolIsShared == null)
			{
				_PixelBufferPoolIsShared = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_PixelBufferPoolIsShared");
			}
			return _PixelBufferPoolIsShared;
		}
	}

	[Field("kVTCompressionPropertyKey_PixelTransferProperties", "VideoToolbox")]
	public static NSString PixelTransferProperties
	{
		get
		{
			if (_PixelTransferProperties == null)
			{
				_PixelTransferProperties = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_PixelTransferProperties");
			}
			return _PixelTransferProperties;
		}
	}

	[Field("kVTCompressionPropertyKey_ProfileLevel", "VideoToolbox")]
	public static NSString ProfileLevel
	{
		get
		{
			if (_ProfileLevel == null)
			{
				_ProfileLevel = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ProfileLevel");
			}
			return _ProfileLevel;
		}
	}

	[Field("kVTCompressionPropertyKey_ProgressiveScan", "VideoToolbox")]
	public static NSString ProgressiveScan
	{
		get
		{
			if (_ProgressiveScan == null)
			{
				_ProgressiveScan = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_ProgressiveScan");
			}
			return _ProgressiveScan;
		}
	}

	[Field("kVTCompressionPropertyKey_Quality", "VideoToolbox")]
	public static NSString Quality
	{
		get
		{
			if (_Quality == null)
			{
				_Quality = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_Quality");
			}
			return _Quality;
		}
	}

	[Field("kVTCompressionPropertyKey_RealTime", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RealTime
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RealTime == null)
			{
				_RealTime = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_RealTime");
			}
			return _RealTime;
		}
	}

	[Field("kVTCompressionPropertyKey_SourceFrameCount", "VideoToolbox")]
	public static NSString SourceFrameCount
	{
		get
		{
			if (_SourceFrameCount == null)
			{
				_SourceFrameCount = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_SourceFrameCount");
			}
			return _SourceFrameCount;
		}
	}

	[Field("kVTCompressionPropertyKey_TargetQualityForAlpha", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString TargetQualityForAlpha
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_TargetQualityForAlpha == null)
			{
				_TargetQualityForAlpha = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_TargetQualityForAlpha");
			}
			return _TargetQualityForAlpha;
		}
	}

	[Field("kVTCompressionPropertyKey_TransferFunction", "VideoToolbox")]
	public static NSString TransferFunction
	{
		get
		{
			if (_TransferFunction == null)
			{
				_TransferFunction = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_TransferFunction");
			}
			return _TransferFunction;
		}
	}

	[Field("kVTCompressionPropertyKey_UsingGPURegistryID", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString UsingGpuRegistryId
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_UsingGpuRegistryId == null)
			{
				_UsingGpuRegistryId = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_UsingGPURegistryID");
			}
			return _UsingGpuRegistryId;
		}
	}

	[Field("kVTCompressionPropertyKey_UsingHardwareAcceleratedVideoEncoder", "VideoToolbox")]
	public static NSString UsingHardwareAcceleratedVideoEncoder
	{
		get
		{
			if (_UsingHardwareAcceleratedVideoEncoder == null)
			{
				_UsingHardwareAcceleratedVideoEncoder = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_UsingHardwareAcceleratedVideoEncoder");
			}
			return _UsingHardwareAcceleratedVideoEncoder;
		}
	}

	[Field("kVTCompressionPropertyKey_VideoEncoderPixelBufferAttributes", "VideoToolbox")]
	public static NSString VideoEncoderPixelBufferAttributes
	{
		get
		{
			if (_VideoEncoderPixelBufferAttributes == null)
			{
				_VideoEncoderPixelBufferAttributes = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_VideoEncoderPixelBufferAttributes");
			}
			return _VideoEncoderPixelBufferAttributes;
		}
	}

	[Field("kVTCompressionPropertyKey_YCbCrMatrix", "VideoToolbox")]
	public static NSString YCbCrMatrix
	{
		get
		{
			if (_YCbCrMatrix == null)
			{
				_YCbCrMatrix = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTCompressionPropertyKey_YCbCrMatrix");
			}
			return _YCbCrMatrix;
		}
	}
}

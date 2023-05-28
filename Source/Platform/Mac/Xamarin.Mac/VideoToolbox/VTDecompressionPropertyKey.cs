using Foundation;
using ObjCRuntime;

namespace VideoToolbox;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
public static class VTDecompressionPropertyKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContentHasInterframeDependencies;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeinterlaceMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeinterlaceMode_Temporal;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DeinterlaceMode_VerticalFilter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldMode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldMode_BothFields;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldMode_BottomFieldOnly;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldMode_DeinterlaceFields;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldMode_SingleField;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FieldMode_TopFieldOnly;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaxOutputPresentationTimeStampOfFramesBeingDecoded;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MaximizePowerEfficiency;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MinOutputPresentationTimeStampOfFramesBeingDecoded;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NumberOfFramesBeingDecoded;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OnlyTheseFrames;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OnlyTheseFrames_AllFrames;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OnlyTheseFrames_IFrames;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OnlyTheseFrames_KeyFrames;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OnlyTheseFrames_NonDroppableFrames;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OutputPoolRequestedMinimumBufferCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelBufferPool;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelBufferPoolIsShared;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelFormatsWithReducedResolutionSupport;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelTransferProperties;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RealTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReducedCoefficientDecode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReducedFrameDelivery;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReducedResolutionDecode;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SuggestedQualityOfServiceTiers;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SupportedPixelFormatsOrderedByPerformance;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SupportedPixelFormatsOrderedByQuality;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TemporalLevelLimit;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThreadCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UsingGpuRegistryId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UsingHardwareAcceleratedVideoDecoder;

	[Field("kVTDecompressionPropertyKey_ContentHasInterframeDependencies", "VideoToolbox")]
	public static NSString ContentHasInterframeDependencies
	{
		get
		{
			if (_ContentHasInterframeDependencies == null)
			{
				_ContentHasInterframeDependencies = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_ContentHasInterframeDependencies");
			}
			return _ContentHasInterframeDependencies;
		}
	}

	[Field("kVTDecompressionPropertyKey_DeinterlaceMode", "VideoToolbox")]
	public static NSString DeinterlaceMode
	{
		get
		{
			if (_DeinterlaceMode == null)
			{
				_DeinterlaceMode = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_DeinterlaceMode");
			}
			return _DeinterlaceMode;
		}
	}

	[Field("kVTDecompressionProperty_DeinterlaceMode_Temporal", "VideoToolbox")]
	public static NSString DeinterlaceMode_Temporal
	{
		get
		{
			if (_DeinterlaceMode_Temporal == null)
			{
				_DeinterlaceMode_Temporal = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_DeinterlaceMode_Temporal");
			}
			return _DeinterlaceMode_Temporal;
		}
	}

	[Field("kVTDecompressionProperty_DeinterlaceMode_VerticalFilter", "VideoToolbox")]
	public static NSString DeinterlaceMode_VerticalFilter
	{
		get
		{
			if (_DeinterlaceMode_VerticalFilter == null)
			{
				_DeinterlaceMode_VerticalFilter = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_DeinterlaceMode_VerticalFilter");
			}
			return _DeinterlaceMode_VerticalFilter;
		}
	}

	[Field("kVTDecompressionPropertyKey_FieldMode", "VideoToolbox")]
	public static NSString FieldMode
	{
		get
		{
			if (_FieldMode == null)
			{
				_FieldMode = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_FieldMode");
			}
			return _FieldMode;
		}
	}

	[Field("kVTDecompressionProperty_FieldMode_BothFields", "VideoToolbox")]
	public static NSString FieldMode_BothFields
	{
		get
		{
			if (_FieldMode_BothFields == null)
			{
				_FieldMode_BothFields = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_FieldMode_BothFields");
			}
			return _FieldMode_BothFields;
		}
	}

	[Field("kVTDecompressionProperty_FieldMode_BottomFieldOnly", "VideoToolbox")]
	public static NSString FieldMode_BottomFieldOnly
	{
		get
		{
			if (_FieldMode_BottomFieldOnly == null)
			{
				_FieldMode_BottomFieldOnly = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_FieldMode_BottomFieldOnly");
			}
			return _FieldMode_BottomFieldOnly;
		}
	}

	[Field("kVTDecompressionProperty_FieldMode_DeinterlaceFields", "VideoToolbox")]
	public static NSString FieldMode_DeinterlaceFields
	{
		get
		{
			if (_FieldMode_DeinterlaceFields == null)
			{
				_FieldMode_DeinterlaceFields = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_FieldMode_DeinterlaceFields");
			}
			return _FieldMode_DeinterlaceFields;
		}
	}

	[Field("kVTDecompressionProperty_FieldMode_SingleField", "VideoToolbox")]
	public static NSString FieldMode_SingleField
	{
		get
		{
			if (_FieldMode_SingleField == null)
			{
				_FieldMode_SingleField = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_FieldMode_SingleField");
			}
			return _FieldMode_SingleField;
		}
	}

	[Field("kVTDecompressionProperty_FieldMode_TopFieldOnly", "VideoToolbox")]
	public static NSString FieldMode_TopFieldOnly
	{
		get
		{
			if (_FieldMode_TopFieldOnly == null)
			{
				_FieldMode_TopFieldOnly = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_FieldMode_TopFieldOnly");
			}
			return _FieldMode_TopFieldOnly;
		}
	}

	[Field("kVTDecompressionPropertyKey_MaxOutputPresentationTimeStampOfFramesBeingDecoded", "VideoToolbox")]
	public static NSString MaxOutputPresentationTimeStampOfFramesBeingDecoded
	{
		get
		{
			if (_MaxOutputPresentationTimeStampOfFramesBeingDecoded == null)
			{
				_MaxOutputPresentationTimeStampOfFramesBeingDecoded = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_MaxOutputPresentationTimeStampOfFramesBeingDecoded");
			}
			return _MaxOutputPresentationTimeStampOfFramesBeingDecoded;
		}
	}

	[Field("kVTDecompressionPropertyKey_MaximizePowerEfficiency", "VideoToolbox")]
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
				_MaximizePowerEfficiency = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_MaximizePowerEfficiency");
			}
			return _MaximizePowerEfficiency;
		}
	}

	[Field("kVTDecompressionPropertyKey_MinOutputPresentationTimeStampOfFramesBeingDecoded", "VideoToolbox")]
	public static NSString MinOutputPresentationTimeStampOfFramesBeingDecoded
	{
		get
		{
			if (_MinOutputPresentationTimeStampOfFramesBeingDecoded == null)
			{
				_MinOutputPresentationTimeStampOfFramesBeingDecoded = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_MinOutputPresentationTimeStampOfFramesBeingDecoded");
			}
			return _MinOutputPresentationTimeStampOfFramesBeingDecoded;
		}
	}

	[Field("kVTDecompressionPropertyKey_NumberOfFramesBeingDecoded", "VideoToolbox")]
	public static NSString NumberOfFramesBeingDecoded
	{
		get
		{
			if (_NumberOfFramesBeingDecoded == null)
			{
				_NumberOfFramesBeingDecoded = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_NumberOfFramesBeingDecoded");
			}
			return _NumberOfFramesBeingDecoded;
		}
	}

	[Field("kVTDecompressionPropertyKey_OnlyTheseFrames", "VideoToolbox")]
	public static NSString OnlyTheseFrames
	{
		get
		{
			if (_OnlyTheseFrames == null)
			{
				_OnlyTheseFrames = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_OnlyTheseFrames");
			}
			return _OnlyTheseFrames;
		}
	}

	[Field("kVTDecompressionProperty_OnlyTheseFrames_AllFrames", "VideoToolbox")]
	public static NSString OnlyTheseFrames_AllFrames
	{
		get
		{
			if (_OnlyTheseFrames_AllFrames == null)
			{
				_OnlyTheseFrames_AllFrames = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_OnlyTheseFrames_AllFrames");
			}
			return _OnlyTheseFrames_AllFrames;
		}
	}

	[Field("kVTDecompressionProperty_OnlyTheseFrames_IFrames", "VideoToolbox")]
	public static NSString OnlyTheseFrames_IFrames
	{
		get
		{
			if (_OnlyTheseFrames_IFrames == null)
			{
				_OnlyTheseFrames_IFrames = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_OnlyTheseFrames_IFrames");
			}
			return _OnlyTheseFrames_IFrames;
		}
	}

	[Field("kVTDecompressionProperty_OnlyTheseFrames_KeyFrames", "VideoToolbox")]
	public static NSString OnlyTheseFrames_KeyFrames
	{
		get
		{
			if (_OnlyTheseFrames_KeyFrames == null)
			{
				_OnlyTheseFrames_KeyFrames = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_OnlyTheseFrames_KeyFrames");
			}
			return _OnlyTheseFrames_KeyFrames;
		}
	}

	[Field("kVTDecompressionProperty_OnlyTheseFrames_NonDroppableFrames", "VideoToolbox")]
	public static NSString OnlyTheseFrames_NonDroppableFrames
	{
		get
		{
			if (_OnlyTheseFrames_NonDroppableFrames == null)
			{
				_OnlyTheseFrames_NonDroppableFrames = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_OnlyTheseFrames_NonDroppableFrames");
			}
			return _OnlyTheseFrames_NonDroppableFrames;
		}
	}

	[Field("kVTDecompressionPropertyKey_OutputPoolRequestedMinimumBufferCount", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString OutputPoolRequestedMinimumBufferCount
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_OutputPoolRequestedMinimumBufferCount == null)
			{
				_OutputPoolRequestedMinimumBufferCount = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_OutputPoolRequestedMinimumBufferCount");
			}
			return _OutputPoolRequestedMinimumBufferCount;
		}
	}

	[Field("kVTDecompressionPropertyKey_PixelBufferPool", "VideoToolbox")]
	public static NSString PixelBufferPool
	{
		get
		{
			if (_PixelBufferPool == null)
			{
				_PixelBufferPool = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_PixelBufferPool");
			}
			return _PixelBufferPool;
		}
	}

	[Field("kVTDecompressionPropertyKey_PixelBufferPoolIsShared", "VideoToolbox")]
	public static NSString PixelBufferPoolIsShared
	{
		get
		{
			if (_PixelBufferPoolIsShared == null)
			{
				_PixelBufferPoolIsShared = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_PixelBufferPoolIsShared");
			}
			return _PixelBufferPoolIsShared;
		}
	}

	[Field("kVTDecompressionPropertyKey_PixelFormatsWithReducedResolutionSupport", "VideoToolbox")]
	public static NSString PixelFormatsWithReducedResolutionSupport
	{
		get
		{
			if (_PixelFormatsWithReducedResolutionSupport == null)
			{
				_PixelFormatsWithReducedResolutionSupport = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_PixelFormatsWithReducedResolutionSupport");
			}
			return _PixelFormatsWithReducedResolutionSupport;
		}
	}

	[Field("kVTDecompressionPropertyKey_PixelTransferProperties", "VideoToolbox")]
	public static NSString PixelTransferProperties
	{
		get
		{
			if (_PixelTransferProperties == null)
			{
				_PixelTransferProperties = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_PixelTransferProperties");
			}
			return _PixelTransferProperties;
		}
	}

	[Field("kVTDecompressionPropertyKey_RealTime", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString RealTime
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_RealTime == null)
			{
				_RealTime = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_RealTime");
			}
			return _RealTime;
		}
	}

	[Field("kVTDecompressionPropertyKey_ReducedCoefficientDecode", "VideoToolbox")]
	public static NSString ReducedCoefficientDecode
	{
		get
		{
			if (_ReducedCoefficientDecode == null)
			{
				_ReducedCoefficientDecode = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_ReducedCoefficientDecode");
			}
			return _ReducedCoefficientDecode;
		}
	}

	[Field("kVTDecompressionPropertyKey_ReducedFrameDelivery", "VideoToolbox")]
	public static NSString ReducedFrameDelivery
	{
		get
		{
			if (_ReducedFrameDelivery == null)
			{
				_ReducedFrameDelivery = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_ReducedFrameDelivery");
			}
			return _ReducedFrameDelivery;
		}
	}

	[Field("kVTDecompressionPropertyKey_ReducedResolutionDecode", "VideoToolbox")]
	public static NSString ReducedResolutionDecode
	{
		get
		{
			if (_ReducedResolutionDecode == null)
			{
				_ReducedResolutionDecode = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_ReducedResolutionDecode");
			}
			return _ReducedResolutionDecode;
		}
	}

	[Field("kVTDecompressionPropertyKey_SuggestedQualityOfServiceTiers", "VideoToolbox")]
	public static NSString SuggestedQualityOfServiceTiers
	{
		get
		{
			if (_SuggestedQualityOfServiceTiers == null)
			{
				_SuggestedQualityOfServiceTiers = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_SuggestedQualityOfServiceTiers");
			}
			return _SuggestedQualityOfServiceTiers;
		}
	}

	[Field("kVTDecompressionPropertyKey_SupportedPixelFormatsOrderedByPerformance", "VideoToolbox")]
	public static NSString SupportedPixelFormatsOrderedByPerformance
	{
		get
		{
			if (_SupportedPixelFormatsOrderedByPerformance == null)
			{
				_SupportedPixelFormatsOrderedByPerformance = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_SupportedPixelFormatsOrderedByPerformance");
			}
			return _SupportedPixelFormatsOrderedByPerformance;
		}
	}

	[Field("kVTDecompressionPropertyKey_SupportedPixelFormatsOrderedByQuality", "VideoToolbox")]
	public static NSString SupportedPixelFormatsOrderedByQuality
	{
		get
		{
			if (_SupportedPixelFormatsOrderedByQuality == null)
			{
				_SupportedPixelFormatsOrderedByQuality = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_SupportedPixelFormatsOrderedByQuality");
			}
			return _SupportedPixelFormatsOrderedByQuality;
		}
	}

	[Field("kVTDecompressionProperty_TemporalLevelLimit", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString TemporalLevelLimit
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_TemporalLevelLimit == null)
			{
				_TemporalLevelLimit = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionProperty_TemporalLevelLimit");
			}
			return _TemporalLevelLimit;
		}
	}

	[Field("kVTDecompressionPropertyKey_ThreadCount", "VideoToolbox")]
	public static NSString ThreadCount
	{
		get
		{
			if (_ThreadCount == null)
			{
				_ThreadCount = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_ThreadCount");
			}
			return _ThreadCount;
		}
	}

	[Field("kVTDecompressionPropertyKey_UsingGPURegistryID", "VideoToolbox")]
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
				_UsingGpuRegistryId = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_UsingGPURegistryID");
			}
			return _UsingGpuRegistryId;
		}
	}

	[Field("kVTDecompressionPropertyKey_UsingHardwareAcceleratedVideoDecoder", "VideoToolbox")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString UsingHardwareAcceleratedVideoDecoder
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_UsingHardwareAcceleratedVideoDecoder == null)
			{
				_UsingHardwareAcceleratedVideoDecoder = Dlfcn.GetStringConstant(Libraries.VideoToolbox.Handle, "kVTDecompressionPropertyKey_UsingHardwareAcceleratedVideoDecoder");
			}
			return _UsingHardwareAcceleratedVideoDecoder;
		}
	}
}

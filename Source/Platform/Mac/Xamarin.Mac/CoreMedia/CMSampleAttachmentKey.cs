using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
internal static class CMSampleAttachmentKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AudioIndependentSampleDecoderRefreshCountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CameraIntrinsicMatrixKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DependsOnOthers;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayEmptyMediaImmediately;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisplayImmediately;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DoNotDisplay;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DrainAfterDecoding;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EarlierDisplayTimesAllowed;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EmptyMedia;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EndsPreviousSampleDuration;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FillDiscontinuitiesWithSilence;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ForceKeyFrameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GradualDecoderRefreshKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HasRedundantCoding;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HevcStepwiseTemporalSubLayerAccessKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HevcSyncSampleNalUnitTypeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HevcTemporalLevelInfoKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HevcTemporalSubLayerAccessKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsDependedOnByOthers;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NotSync;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PartialSync;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PermanentEmptyMedia;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PostNotificationWhenConsumedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResetDecoderBeforeDecoding;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResumeOutputKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Reverse;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SampleReferenceByteOffsetKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SampleReferenceUrlKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SpeedMultiplierKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TransitionIdKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TrimDurationAtEndKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TrimDurationAtStartKey;

	[Field("kCMSampleAttachmentKey_AudioIndependentSampleDecoderRefreshCount", "CoreMedia")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public static NSString AudioIndependentSampleDecoderRefreshCountKey
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AudioIndependentSampleDecoderRefreshCountKey == null)
			{
				_AudioIndependentSampleDecoderRefreshCountKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_AudioIndependentSampleDecoderRefreshCount");
			}
			return _AudioIndependentSampleDecoderRefreshCountKey;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix", "CoreMedia")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString CameraIntrinsicMatrixKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_CameraIntrinsicMatrixKey == null)
			{
				_CameraIntrinsicMatrixKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_CameraIntrinsicMatrix");
			}
			return _CameraIntrinsicMatrixKey;
		}
	}

	[Field("kCMSampleAttachmentKey_DependsOnOthers", "CoreMedia")]
	public static NSString DependsOnOthers
	{
		get
		{
			if (_DependsOnOthers == null)
			{
				_DependsOnOthers = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DependsOnOthers");
			}
			return _DependsOnOthers;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately", "CoreMedia")]
	public static NSString DisplayEmptyMediaImmediately
	{
		get
		{
			if (_DisplayEmptyMediaImmediately == null)
			{
				_DisplayEmptyMediaImmediately = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DisplayEmptyMediaImmediately");
			}
			return _DisplayEmptyMediaImmediately;
		}
	}

	[Field("kCMSampleAttachmentKey_DisplayImmediately", "CoreMedia")]
	public static NSString DisplayImmediately
	{
		get
		{
			if (_DisplayImmediately == null)
			{
				_DisplayImmediately = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DisplayImmediately");
			}
			return _DisplayImmediately;
		}
	}

	[Field("kCMSampleAttachmentKey_DoNotDisplay", "CoreMedia")]
	public static NSString DoNotDisplay
	{
		get
		{
			if (_DoNotDisplay == null)
			{
				_DoNotDisplay = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_DoNotDisplay");
			}
			return _DoNotDisplay;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_DrainAfterDecoding", "CoreMedia")]
	public static NSString DrainAfterDecoding
	{
		get
		{
			if (_DrainAfterDecoding == null)
			{
				_DrainAfterDecoding = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_DrainAfterDecoding");
			}
			return _DrainAfterDecoding;
		}
	}

	[Field("kCMSampleAttachmentKey_EarlierDisplayTimesAllowed", "CoreMedia")]
	public static NSString EarlierDisplayTimesAllowed
	{
		get
		{
			if (_EarlierDisplayTimesAllowed == null)
			{
				_EarlierDisplayTimesAllowed = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_EarlierDisplayTimesAllowed");
			}
			return _EarlierDisplayTimesAllowed;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_EmptyMedia", "CoreMedia")]
	public static NSString EmptyMedia
	{
		get
		{
			if (_EmptyMedia == null)
			{
				_EmptyMedia = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_EmptyMedia");
			}
			return _EmptyMedia;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration", "CoreMedia")]
	public static NSString EndsPreviousSampleDuration
	{
		get
		{
			if (_EndsPreviousSampleDuration == null)
			{
				_EndsPreviousSampleDuration = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_EndsPreviousSampleDuration");
			}
			return _EndsPreviousSampleDuration;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence", "CoreMedia")]
	public static NSString FillDiscontinuitiesWithSilence
	{
		get
		{
			if (_FillDiscontinuitiesWithSilence == null)
			{
				_FillDiscontinuitiesWithSilence = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_FillDiscontinuitiesWithSilence");
			}
			return _FillDiscontinuitiesWithSilence;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_ForceKeyFrame", "CoreMedia")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public static NSString ForceKeyFrameKey
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ForceKeyFrameKey == null)
			{
				_ForceKeyFrameKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ForceKeyFrame");
			}
			return _ForceKeyFrameKey;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_GradualDecoderRefresh", "CoreMedia")]
	public static NSString GradualDecoderRefreshKey
	{
		get
		{
			if (_GradualDecoderRefreshKey == null)
			{
				_GradualDecoderRefreshKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_GradualDecoderRefresh");
			}
			return _GradualDecoderRefreshKey;
		}
	}

	[Field("kCMSampleAttachmentKey_HasRedundantCoding", "CoreMedia")]
	public static NSString HasRedundantCoding
	{
		get
		{
			if (_HasRedundantCoding == null)
			{
				_HasRedundantCoding = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HasRedundantCoding");
			}
			return _HasRedundantCoding;
		}
	}

	[Field("kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess", "CoreMedia")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString HevcStepwiseTemporalSubLayerAccessKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_HevcStepwiseTemporalSubLayerAccessKey == null)
			{
				_HevcStepwiseTemporalSubLayerAccessKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCStepwiseTemporalSubLayerAccess");
			}
			return _HevcStepwiseTemporalSubLayerAccessKey;
		}
	}

	[Field("kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType", "CoreMedia")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString HevcSyncSampleNalUnitTypeKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_HevcSyncSampleNalUnitTypeKey == null)
			{
				_HevcSyncSampleNalUnitTypeKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCSyncSampleNALUnitType");
			}
			return _HevcSyncSampleNalUnitTypeKey;
		}
	}

	[Field("kCMSampleAttachmentKey_HEVCTemporalLevelInfo", "CoreMedia")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString HevcTemporalLevelInfoKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_HevcTemporalLevelInfoKey == null)
			{
				_HevcTemporalLevelInfoKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCTemporalLevelInfo");
			}
			return _HevcTemporalLevelInfoKey;
		}
	}

	[Field("kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess", "CoreMedia")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public static NSString HevcTemporalSubLayerAccessKey
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_HevcTemporalSubLayerAccessKey == null)
			{
				_HevcTemporalSubLayerAccessKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_HEVCTemporalSubLayerAccess");
			}
			return _HevcTemporalSubLayerAccessKey;
		}
	}

	[Field("kCMSampleAttachmentKey_IsDependedOnByOthers", "CoreMedia")]
	public static NSString IsDependedOnByOthers
	{
		get
		{
			if (_IsDependedOnByOthers == null)
			{
				_IsDependedOnByOthers = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_IsDependedOnByOthers");
			}
			return _IsDependedOnByOthers;
		}
	}

	[Field("kCMSampleAttachmentKey_NotSync", "CoreMedia")]
	public static NSString NotSync
	{
		get
		{
			if (_NotSync == null)
			{
				_NotSync = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_NotSync");
			}
			return _NotSync;
		}
	}

	[Field("kCMSampleAttachmentKey_PartialSync", "CoreMedia")]
	public static NSString PartialSync
	{
		get
		{
			if (_PartialSync == null)
			{
				_PartialSync = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleAttachmentKey_PartialSync");
			}
			return _PartialSync;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_PermanentEmptyMedia", "CoreMedia")]
	public static NSString PermanentEmptyMedia
	{
		get
		{
			if (_PermanentEmptyMedia == null)
			{
				_PermanentEmptyMedia = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_PermanentEmptyMedia");
			}
			return _PermanentEmptyMedia;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed", "CoreMedia")]
	public static NSString PostNotificationWhenConsumedKey
	{
		get
		{
			if (_PostNotificationWhenConsumedKey == null)
			{
				_PostNotificationWhenConsumedKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_PostNotificationWhenConsumed");
			}
			return _PostNotificationWhenConsumedKey;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding", "CoreMedia")]
	public static NSString ResetDecoderBeforeDecoding
	{
		get
		{
			if (_ResetDecoderBeforeDecoding == null)
			{
				_ResetDecoderBeforeDecoding = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ResetDecoderBeforeDecoding");
			}
			return _ResetDecoderBeforeDecoding;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_ResumeOutput", "CoreMedia")]
	public static NSString ResumeOutputKey
	{
		get
		{
			if (_ResumeOutputKey == null)
			{
				_ResumeOutputKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_ResumeOutput");
			}
			return _ResumeOutputKey;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_Reverse", "CoreMedia")]
	public static NSString Reverse
	{
		get
		{
			if (_Reverse == null)
			{
				_Reverse = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_Reverse");
			}
			return _Reverse;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_SampleReferenceByteOffset", "CoreMedia")]
	public static NSString SampleReferenceByteOffsetKey
	{
		get
		{
			if (_SampleReferenceByteOffsetKey == null)
			{
				_SampleReferenceByteOffsetKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SampleReferenceByteOffset");
			}
			return _SampleReferenceByteOffsetKey;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_SampleReferenceURL", "CoreMedia")]
	public static NSString SampleReferenceUrlKey
	{
		get
		{
			if (_SampleReferenceUrlKey == null)
			{
				_SampleReferenceUrlKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SampleReferenceURL");
			}
			return _SampleReferenceUrlKey;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_SpeedMultiplier", "CoreMedia")]
	public static NSString SpeedMultiplierKey
	{
		get
		{
			if (_SpeedMultiplierKey == null)
			{
				_SpeedMultiplierKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_SpeedMultiplier");
			}
			return _SpeedMultiplierKey;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_TransitionID", "CoreMedia")]
	public static NSString TransitionIdKey
	{
		get
		{
			if (_TransitionIdKey == null)
			{
				_TransitionIdKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TransitionID");
			}
			return _TransitionIdKey;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_TrimDurationAtEnd", "CoreMedia")]
	public static NSString TrimDurationAtEndKey
	{
		get
		{
			if (_TrimDurationAtEndKey == null)
			{
				_TrimDurationAtEndKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TrimDurationAtEnd");
			}
			return _TrimDurationAtEndKey;
		}
	}

	[Field("kCMSampleBufferAttachmentKey_TrimDurationAtStart", "CoreMedia")]
	public static NSString TrimDurationAtStartKey
	{
		get
		{
			if (_TrimDurationAtStartKey == null)
			{
				_TrimDurationAtStartKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMSampleBufferAttachmentKey_TrimDurationAtStart");
			}
			return _TrimDurationAtStartKey;
		}
	}
}

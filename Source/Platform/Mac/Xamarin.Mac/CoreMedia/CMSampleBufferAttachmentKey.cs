using ObjCRuntime;

namespace CoreMedia;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public enum CMSampleBufferAttachmentKey
{
	NotSync,
	PartialSync,
	HasRedundantCoding,
	IsDependedOnByOthers,
	DependsOnOthers,
	EarlierDisplayTimesAllowed,
	DisplayImmediately,
	DoNotDisplay,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	HevcTemporalLevelInfo,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	HevcTemporalSubLayerAccess,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	HevcStepwiseTemporalSubLayerAccess,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	HevcSyncSampleNalUnitType,
	ResetDecoderBeforeDecoding,
	DrainAfterDecoding,
	PostNotificationWhenConsumed,
	ResumeOutput,
	TransitionId,
	TrimDurationAtStart,
	TrimDurationAtEnd,
	SpeedMultiplier,
	Reverse,
	FillDiscontinuitiesWithSilence,
	EmptyMedia,
	PermanentEmptyMedia,
	DisplayEmptyMediaImmediately,
	EndsPreviousSampleDuration,
	SampleReferenceUrl,
	SampleReferenceByteOffset,
	GradualDecoderRefresh,
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	DroppedFrameReason,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	StillImageLensStabilizationInfo,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	CameraIntrinsicMatrix,
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	DroppedFrameReasonInfo,
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	ForceKeyFrame
}

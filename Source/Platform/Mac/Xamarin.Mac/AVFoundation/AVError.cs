using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVError : long
{
	Unknown = -11800L,
	OutOfMemory = -11801L,
	SessionNotRunning = -11803L,
	DeviceAlreadyUsedByAnotherSession = -11804L,
	NoDataCaptured = -11805L,
	SessionConfigurationChanged = -11806L,
	DiskFull = -11807L,
	DeviceWasDisconnected = -11808L,
	MediaChanged = -11809L,
	MaximumDurationReached = -11810L,
	MaximumFileSizeReached = -11811L,
	MediaDiscontinuity = -11812L,
	MaximumNumberOfSamplesForFileFormatReached = -11813L,
	DeviceNotConnected = -11814L,
	DeviceInUseByAnotherApplication = -11815L,
	DeviceLockedForConfigurationByAnotherProcess = -11817L,
	SessionWasInterrupted = -11818L,
	MediaServicesWereReset = -11819L,
	ExportFailed = -11820L,
	DecodeFailed = -11821L,
	InvalidSourceMedia = -11822L,
	FileAlreadyExists = -11823L,
	CompositionTrackSegmentsNotContiguous = -11824L,
	InvalidCompositionTrackSegmentDuration = -11825L,
	InvalidCompositionTrackSegmentSourceStartTime = -11826L,
	InvalidCompositionTrackSegmentSourceDuration = -11827L,
	FormatNotRecognized = -11828L,
	FailedToParse = -11829L,
	MaximumStillImageCaptureRequestsExceeded = -11830L,
	ContentIsProtected = -11831L,
	NoImageAtTime = -11832L,
	DecoderNotFound = -11833L,
	EncoderNotFound = -11834L,
	ContentIsNotAuthorized = -11835L,
	ApplicationIsNotAuthorized = -11836L,
	DeviceIsNotAvailableInBackground = -11837L,
	OperationNotSupportedForAsset = -11838L,
	DecoderTemporarilyUnavailable = -11839L,
	EncoderTemporarilyUnavailable = -11840L,
	InvalidVideoComposition = -11841L,
	ReferenceForbiddenByReferencePolicy = -11842L,
	InvalidOutputURLPathExtension = -11843L,
	ScreenCaptureFailed = -11844L,
	DisplayWasDisabled = -11845L,
	TorchLevelUnavailable = -11846L,
	OperationInterrupted = -11847L,
	IncompatibleAsset = -11848L,
	FailedToLoadMediaData = -11849L,
	ServerIncorrectlyConfigured = -11850L,
	ApplicationIsNotAuthorizedToUseDevice = -11852L,
	FailedToParse2 = -11853L,
	FileTypeDoesNotSupportSampleReferences = -11854L,
	UndecodableMediaData = -11855L,
	AirPlayControllerRequiresInternet = -11856L,
	AirPlayReceiverRequiresInternet = -11857L,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	VideoCompositorFailed = -11858L,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	UnsupportedOutputSettings = -11861L,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	OperationNotAllowed = -11862L,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	ContentIsUnavailable = -11863L,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	FormatUnsupported = -11864L,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	MalformedDepth = -11865L,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	ContentNotUpdated = -11866L,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	NoLongerPlayable = -11867L,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	NoCompatibleAlternatesForExternalDisplay = -11868L,
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
	NoSourceTrack = -11869L
}

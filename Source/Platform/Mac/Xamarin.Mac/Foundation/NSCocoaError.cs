using ObjCRuntime;

namespace Foundation;

public enum NSCocoaError
{
	None = 0,
	FileNoSuchFile = 4,
	FileLocking = 255,
	FileReadUnknown = 256,
	FileReadNoPermission = 257,
	FileReadInvalidFileName = 258,
	FileReadCorruptFile = 259,
	FileReadNoSuchFile = 260,
	FileReadInapplicableStringEncoding = 261,
	FileReadUnsupportedScheme = 262,
	FileReadTooLarge = 263,
	FileReadUnknownStringEncoding = 264,
	FileWriteUnknown = 512,
	FileWriteNoPermission = 513,
	FileWriteInvalidFileName = 514,
	FileWriteFileExists = 516,
	FileWriteInapplicableStringEncoding = 517,
	FileWriteUnsupportedScheme = 518,
	FileWriteOutOfSpace = 640,
	FileWriteVolumeReadOnly = 642,
	FileManagerUnmountUnknownError = 768,
	FileManagerUnmountBusyError = 769,
	KeyValueValidation = 1024,
	Formatting = 2048,
	UserCancelled = 3072,
	FeatureUnsupported = 3328,
	ExecutableNotLoadable = 3584,
	ExecutableArchitectureMismatch = 3585,
	ExecutableRuntimeMismatch = 3586,
	ExecutableLoad = 3587,
	ExecutableLink = 3588,
	FileErrorMinimum = 0,
	FileErrorMaximum = 1023,
	ValidationErrorMinimum = 1024,
	ValidationErrorMaximum = 2047,
	ExecutableErrorMinimum = 3584,
	ExecutableErrorMaximum = 3839,
	FormattingErrorMinimum = 2048,
	FormattingErrorMaximum = 2559,
	PropertyListReadCorrupt = 3840,
	PropertyListReadUnknownVersion = 3841,
	PropertyListReadStream = 3842,
	PropertyListWriteStream = 3851,
	PropertyListWriteInvalid = 3852,
	PropertyListErrorMinimum = 3840,
	PropertyListErrorMaximum = 4095,
	XpcConnectionInterrupted = 4097,
	XpcConnectionInvalid = 4099,
	XpcConnectionReplyInvalid = 4101,
	XpcConnectionErrorMinimum = 4096,
	XpcConnectionErrorMaximum = 4224,
	UbiquitousFileUnavailable = 4353,
	UbiquitousFileNotUploadedDueToQuota = 4354,
	UbiquitousFileUbiquityServerNotAvailable = 4355,
	UbiquitousFileErrorMinimum = 4352,
	UbiquitousFileErrorMaximum = 4607,
	UserActivityHandoffFailedError = 4608,
	UserActivityConnectionUnavailableError = 4609,
	UserActivityRemoteApplicationTimedOutError = 4610,
	UserActivityHandoffUserInfoTooLargeError = 4611,
	UserActivityErrorMinimum = 4608,
	UserActivityErrorMaximum = 4863,
	CoderReadCorruptError = 4864,
	CoderValueNotFoundError = 4865,
	[Mac(10, 13)]
	[iOS(11, 0)]
	[Watch(4, 0)]
	[TV(11, 0)]
	CoderInvalidValueError = 4866,
	CoderErrorMinimum = 4864,
	CoderErrorMaximum = 4991,
	BundleErrorMinimum = 4992,
	BundleErrorMaximum = 5119,
	BundleOnDemandResourceOutOfSpaceError = 4992,
	BundleOnDemandResourceExceededMaximumSizeError = 4993,
	BundleOnDemandResourceInvalidTagError = 4994,
	[Mac(10, 12)]
	[iOS(10, 0)]
	[NoTV]
	[NoWatch]
	CloudSharingNetworkFailureError = 5120,
	[Mac(10, 12)]
	[iOS(10, 0)]
	[NoTV]
	[NoWatch]
	CloudSharingQuotaExceededError = 5121,
	[Mac(10, 12)]
	[iOS(10, 0)]
	[NoTV]
	[NoWatch]
	CloudSharingTooManyParticipantsError = 5122,
	[Mac(10, 12)]
	[iOS(10, 0)]
	[NoTV]
	[NoWatch]
	CloudSharingConflictError = 5123,
	[Mac(10, 12)]
	[iOS(10, 0)]
	[NoTV]
	[NoWatch]
	CloudSharingNoPermissionError = 5124,
	[Mac(10, 12)]
	[iOS(10, 0)]
	[NoTV]
	[NoWatch]
	CloudSharingOtherError = 5375,
	[Mac(10, 12)]
	[iOS(10, 0)]
	[NoTV]
	[NoWatch]
	CloudSharingErrorMinimum = 5120,
	[Mac(10, 12)]
	[iOS(10, 0)]
	[NoTV]
	[NoWatch]
	CloudSharingErrorMaximum = 5375,
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	CompressionFailedError = 5376,
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	DecompressionFailedError = 5377,
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	CompressionErrorMinimum = 5376,
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	CompressionErrorMaximum = 5503
}

using ObjCRuntime;

namespace QTKit;

[Native]
public enum QTError : long
{
	Unknown = -1L,
	None = 0L,
	IncompatibleInput = 1002L,
	IncompatibleOutput = 1003L,
	InvalidInputsOrOutputs = 1100L,
	DeviceAlreadyUsedbyAnotherSession = 1101L,
	NoDataCaptured = 1200L,
	SessionConfigurationChanged = 1201L,
	DiskFull = 1202L,
	DeviceWasDisconnected = 1203L,
	MediaChanged = 1204L,
	MaximumDurationReached = 1205L,
	MaximumFileSizeReached = 1206L,
	MediaDiscontinuity = 1207L,
	MaximumNumberOfSamplesForFileFormatReached = 1208L,
	DeviceNotConnected = 1300L,
	DeviceInUseByAnotherApplication = 1301L,
	DeviceExcludedByAnotherDevice = 1302L
}

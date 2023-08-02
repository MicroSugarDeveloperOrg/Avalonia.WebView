namespace QTKit;

public enum QTError
{
	Unknown = -1,
	None = 0,
	IncompatibleInput = 1002,
	IncompatibleOutput = 1003,
	InvalidInputsOrOutputs = 1100,
	DeviceAlreadyUsedbyAnotherSession = 1101,
	NoDataCaptured = 1200,
	SessionConfigurationChanged = 1201,
	DiskFull = 1202,
	DeviceWasDisconnected = 1203,
	MediaChanged = 1204,
	MaximumDurationReached = 1205,
	MaximumFileSizeReached = 1206,
	MediaDiscontinuity = 1207,
	MaximumNumberOfSamplesForFileFormatReached = 1208,
	DeviceNotConnected = 1300,
	DeviceInUseByAnotherApplication = 1301,
	DeviceExcludedByAnotherDevice = 1302
}

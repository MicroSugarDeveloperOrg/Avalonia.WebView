namespace AudioToolbox;

public enum AudioQueueStatus
{
	Ok = 0,
	InvalidBuffer = -66687,
	BufferEmpty = -66686,
	DisposalPending = -66685,
	InvalidProperty = -66684,
	InvalidPropertySize = -66683,
	InvalidParameter = -66682,
	CannotStart = -66681,
	InvalidDevice = -66680,
	BufferInQueue = -66679,
	InvalidRunState = -66678,
	InvalidQueueType = -66677,
	Permissions = -66676,
	InvalidPropertyValue = -66675,
	PrimeTimedOut = -66674,
	CodecNotFound = -66673,
	InvalidCodecAccess = -66672,
	QueueInvalidated = -66671,
	TooManyTaps = -66670,
	InvalidTapContext = -66669,
	RecordUnderrun = -66668,
	InvalidTapType = -66667,
	EnqueueDuringReset = -66632,
	InvalidOfflineMode = -66626,
	QueueStopped = 1937010544,
	DataFormatError = 1718449215,
	UnsupportedProperty = 1886547824,
	GeneralParamError = -50
}

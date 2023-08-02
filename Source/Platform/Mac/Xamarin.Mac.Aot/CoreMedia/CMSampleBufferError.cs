namespace CoreMedia;

public enum CMSampleBufferError
{
	None = 0,
	AllocationFailed = -12730,
	RequiredParameterMissing = -12731,
	AlreadyHasDataBuffer = -12732,
	BufferNotReady = -12733,
	SampleIndexOutOfRange = -12734,
	BufferHasNoSampleSizes = -12735,
	BufferHasNoSampleTimingInfo = -12736,
	ArrayTooSmall = -12737,
	InvalidEntryCount = -12738,
	CannotSubdivide = -12739,
	SampleTimingInfoInvalid = -12740,
	InvalidMediaTypeForOperation = -12741,
	InvalidSampleData = -12742,
	InvalidMediaFormat = -12743,
	Invalidated = -12744
}

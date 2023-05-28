using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public enum CMFormatDescriptionError
{
	None = 0,
	InvalidParameter = -12710,
	AllocationFailed = -12711,
	ValueNotAvailable = -12718
}

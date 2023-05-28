using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public enum CMClockError
{
	None = 0,
	MissingRequiredParameter = -12745,
	InvalidParameter = -12746,
	AllocationFailed = -12747,
	UnsupportedOperation = -12756
}

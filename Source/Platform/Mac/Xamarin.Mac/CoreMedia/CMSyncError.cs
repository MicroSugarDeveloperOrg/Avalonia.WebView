using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public enum CMSyncError
{
	None = 0,
	MissingRequiredParameter = -12752,
	InvalidParameter = -12753,
	AllocationFailed = -12754,
	RateMustBeNonZero = -12755
}

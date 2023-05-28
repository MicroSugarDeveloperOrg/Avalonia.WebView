using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSUrlCacheStoragePolicy : ulong
{
	Allowed,
	AllowedInMemoryOnly,
	NotAllowed
}

using ObjCRuntime;

namespace CoreFoundation;

[Native]
public enum CFSocketError : long
{
	Success = 0L,
	Error = -1L,
	Timeout = -2L
}

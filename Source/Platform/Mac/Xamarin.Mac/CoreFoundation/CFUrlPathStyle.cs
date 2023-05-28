using ObjCRuntime;

namespace CoreFoundation;

[Native]
public enum CFUrlPathStyle : long
{
	POSIX,
	HFS,
	Windows
}

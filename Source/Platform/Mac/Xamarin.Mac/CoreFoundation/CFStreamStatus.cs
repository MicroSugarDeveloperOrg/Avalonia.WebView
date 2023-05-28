using ObjCRuntime;

namespace CoreFoundation;

[Native]
public enum CFStreamStatus : long
{
	NotOpen,
	Opening,
	Open,
	Reading,
	Writing,
	AtEnd,
	Closed,
	Error
}

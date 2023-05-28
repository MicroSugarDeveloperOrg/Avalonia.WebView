using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSImageRepLoadStatus : long
{
	UnknownType = -1L,
	ReadingHeader = -2L,
	WillNeedAllData = -3L,
	InvalidData = -4L,
	UnexpectedEOF = -5L,
	Completed = -6L
}

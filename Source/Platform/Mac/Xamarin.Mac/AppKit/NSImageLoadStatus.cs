using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSImageLoadStatus : ulong
{
	Completed,
	Cancelled,
	InvalidData,
	UnexpectedEOF,
	ReadError
}

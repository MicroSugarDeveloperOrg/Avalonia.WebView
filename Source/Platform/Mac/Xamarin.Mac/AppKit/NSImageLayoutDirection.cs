using ObjCRuntime;

namespace AppKit;

[Mac(10, 12)]
[Native]
public enum NSImageLayoutDirection : long
{
	Unspecified = -1L,
	LeftToRight = 2L,
	RightToLeft = 3L
}

using ObjCRuntime;

namespace AppKit;

[Mac(10, 12)]
[Native]
public enum NSTabPosition : ulong
{
	None,
	Top,
	Left,
	Bottom,
	Right
}

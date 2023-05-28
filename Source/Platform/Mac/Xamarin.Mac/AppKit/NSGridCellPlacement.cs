using ObjCRuntime;

namespace AppKit;

[Mac(10, 12)]
[Native]
public enum NSGridCellPlacement : long
{
	Inherited = 0L,
	None = 1L,
	Leading = 2L,
	Top = 2L,
	Trailing = 3L,
	Bottom = 3L,
	Center = 4L,
	Fill = 5L
}

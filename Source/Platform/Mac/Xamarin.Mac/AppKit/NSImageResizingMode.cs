using ObjCRuntime;

namespace AppKit;

[Mac(10, 10)]
[Native]
public enum NSImageResizingMode : long
{
	Stretch,
	Tile
}

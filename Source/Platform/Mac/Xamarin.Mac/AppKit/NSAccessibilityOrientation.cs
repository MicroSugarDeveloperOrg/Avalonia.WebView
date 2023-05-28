using ObjCRuntime;

namespace AppKit;

[Mac(10, 10)]
[Native]
public enum NSAccessibilityOrientation : long
{
	Unknown,
	Vertical,
	Horizontal
}

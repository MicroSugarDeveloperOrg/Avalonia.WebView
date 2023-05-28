using ObjCRuntime;

namespace AppKit;

[Mac(10, 12, 2)]
[Native]
public enum NSScrubberAlignment : long
{
	None,
	Leading,
	Trailing,
	Center
}

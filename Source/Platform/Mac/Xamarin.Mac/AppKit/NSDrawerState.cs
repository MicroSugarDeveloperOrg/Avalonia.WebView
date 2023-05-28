using ObjCRuntime;

namespace AppKit;

[Native]
[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSSplitViewController' instead.")]
public enum NSDrawerState : ulong
{
	Closed,
	Opening,
	Open,
	Closing
}

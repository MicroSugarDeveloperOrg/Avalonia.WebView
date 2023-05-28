using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSUsableScrollerParts : ulong
{
	NoScroller,
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	OnlyArrows,
	All
}

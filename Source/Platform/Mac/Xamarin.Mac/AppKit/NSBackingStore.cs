using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSBackingStore : ulong
{
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'Buffered' instead.")]
	Retained,
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'Buffered' instead.")]
	Nonretained,
	Buffered
}

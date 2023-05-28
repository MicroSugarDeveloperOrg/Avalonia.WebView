using ObjCRuntime;

namespace AppKit;

[Native]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
public enum NSProgressIndicatorThickness : ulong
{
	Small = 10uL,
	Regular = 14uL,
	Aqua = 12uL,
	Large = 18uL
}

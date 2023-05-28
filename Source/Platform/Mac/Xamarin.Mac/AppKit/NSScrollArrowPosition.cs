using ObjCRuntime;

namespace AppKit;

[Native]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
public enum NSScrollArrowPosition : ulong
{
	MaxEnd,
	MinEnd,
	DefaultSetting,
	None
}

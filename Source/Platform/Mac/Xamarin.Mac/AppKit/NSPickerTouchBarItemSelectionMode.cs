using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum NSPickerTouchBarItemSelectionMode : long
{
	SelectOne,
	SelectAny,
	Momentary
}

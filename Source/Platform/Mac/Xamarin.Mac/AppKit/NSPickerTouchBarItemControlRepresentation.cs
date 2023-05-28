using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum NSPickerTouchBarItemControlRepresentation : long
{
	Automatic,
	Expanded,
	Collapsed
}

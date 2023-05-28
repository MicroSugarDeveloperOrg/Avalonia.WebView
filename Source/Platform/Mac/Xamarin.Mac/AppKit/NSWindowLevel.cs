using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSWindowLevel : long
{
	Normal = 0L,
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	Dock = 20L,
	Floating = 3L,
	MainMenu = 24L,
	ModalPanel = 8L,
	PopUpMenu = 101L,
	ScreenSaver = 1000L,
	Status = 25L,
	Submenu = 3L,
	TornOffMenu = 3L
}

namespace AppKit;

public enum NSApplicationPresentationOptions : ulong
{
	Default = 0uL,
	AutoHideDock = 1uL,
	HideDock = 2uL,
	AutoHideMenuBar = 4uL,
	HideMenuBar = 8uL,
	DisableAppleMenu = 0x10uL,
	DisableProcessSwitching = 0x20uL,
	DisableForceQuit = 0x40uL,
	DisableSessionTermination = 0x80uL,
	DisableHideApplication = 0x100uL,
	DisableMenuBarTransparency = 0x200uL,
	FullScreen = 0x400uL,
	AutoHideToolbar = 0x800uL
}

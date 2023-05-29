using System;

namespace AppKit;

[Flags]
public enum NSWorkspaceLaunchOptions : ulong
{
	Print = 2uL,
	InhibitingBackgroundOnly = 0x80uL,
	WithoutAddingToRecents = 0x100uL,
	WithoutActivation = 0x200uL,
	Async = 0x10000uL,
	AllowingClassicStartup = 0x20000uL,
	PreferringClassic = 0x40000uL,
	NewInstance = 0x80000uL,
	Hide = 0x100000uL,
	HideOthers = 0x200000uL,
	Default = 0x30000uL
}

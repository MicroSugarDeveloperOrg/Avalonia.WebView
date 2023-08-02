using System;

namespace AppKit;

[Flags]
public enum NSWindowStyle : ulong
{
	Borderless = 0uL,
	Titled = 1uL,
	Closable = 2uL,
	Miniaturizable = 4uL,
	Resizable = 8uL,
	Utility = 0x10uL,
	DocModal = 0x40uL,
	NonactivatingPanel = 0x80uL,
	TexturedBackground = 0x100uL,
	Unscaled = 0x800uL,
	UnifiedTitleAndToolbar = 0x1000uL,
	Hud = 0x2000uL,
	FullScreenWindow = 0x4000uL
}

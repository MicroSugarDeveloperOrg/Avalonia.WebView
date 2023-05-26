using System;

namespace AppKit;

[Flags]
public enum NSPrintPanelOptions : ulong
{
	ShowsCopies = 1uL,
	ShowsPageRange = 2uL,
	ShowsPaperSize = 4uL,
	ShowsOrientation = 8uL,
	ShowsScaling = 0x10uL,
	ShowsPrintSelection = 0x20uL,
	ShowsPageSetupAccessory = 0x100uL,
	ShowsPreview = 0x20000uL
}

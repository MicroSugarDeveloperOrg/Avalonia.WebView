using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSPrintPanelOptions : long
{
	ShowsCopies = 1L,
	ShowsPageRange = 2L,
	ShowsPaperSize = 4L,
	ShowsOrientation = 8L,
	ShowsScaling = 0x10L,
	ShowsPrintSelection = 0x20L,
	ShowsPageSetupAccessory = 0x100L,
	ShowsPreview = 0x20000L
}

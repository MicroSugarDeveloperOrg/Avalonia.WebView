using System;

namespace CoreGraphics;

[Flags]
public enum CGWindowListOption
{
	All = 0,
	OnScreenOnly = 1,
	OnScreenAboveWindow = 2,
	OnScreenBelowWindow = 4,
	IncludingWindow = 8,
	ExcludeDesktopElements = 0x10
}

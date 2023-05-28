using System;

namespace CoreGraphics;

[Flags]
public enum CGWindowListOption : uint
{
	All = 0u,
	OnScreenOnly = 1u,
	OnScreenAboveWindow = 2u,
	OnScreenBelowWindow = 4u,
	IncludingWindow = 8u,
	ExcludeDesktopElements = 0x10u
}

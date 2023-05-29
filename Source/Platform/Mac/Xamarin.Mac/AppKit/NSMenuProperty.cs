using System;

namespace AppKit;

[Flags]
public enum NSMenuProperty : ulong
{
	Title = 1uL,
	AttributedTitle = 2uL,
	KeyEquivalent = 4uL,
	Image = 8uL,
	Enabled = 0x10uL,
	AccessibilityDescription = 0x20uL
}

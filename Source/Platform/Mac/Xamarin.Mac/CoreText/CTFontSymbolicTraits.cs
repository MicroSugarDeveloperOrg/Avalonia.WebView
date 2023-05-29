using System;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
[Flags]
public enum CTFontSymbolicTraits : uint
{
	None = 0u,
	Italic = 1u,
	Bold = 2u,
	Expanded = 0x20u,
	Condensed = 0x40u,
	MonoSpace = 0x400u,
	Vertical = 0x800u,
	UIOptimized = 0x1000u,
	ColorGlyphs = 0x2000u,
	Composite = 0x4000u,
	Mask = 0xF0000000u
}

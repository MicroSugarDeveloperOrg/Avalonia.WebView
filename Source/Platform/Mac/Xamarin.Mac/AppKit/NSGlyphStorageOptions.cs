using System;

namespace AppKit;

[Flags]
public enum NSGlyphStorageOptions : ulong
{
	ShowControlGlyphs = 1uL,
	ShowInvisibleGlyphs = 2uL,
	WantsBidiLevels = 4uL
}

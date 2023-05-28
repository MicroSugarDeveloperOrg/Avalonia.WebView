using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSGlyphProperty' instead.")]
public enum NSGlyphStorageOptions : ulong
{
	ShowControlGlyphs = 1uL,
	ShowInvisibleGlyphs = 2uL,
	WantsBidiLevels = 4uL
}

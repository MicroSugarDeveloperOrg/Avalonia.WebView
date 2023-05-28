using System;
using ObjCRuntime;

namespace CoreText;

[Native]
[Flags]
public enum CTLineBoundsOptions : ulong
{
	ExcludeTypographicLeading = 1uL,
	ExcludeTypographicShifts = 2uL,
	UseHangingPunctuation = 4uL,
	UseGlyphPathBounds = 8uL,
	UseOpticalBounds = 0x10uL,
	IncludeLanguageExtents = 0x20uL
}

using System;
using ObjCRuntime;

namespace AppKit;

[Mac(10, 13)]
[Native]
[Flags]
public enum NSFontPanelModeMask : ulong
{
	Face = 1uL,
	Size = 2uL,
	Collection = 4uL,
	UnderlineEffect = 0x100uL,
	StrikethroughEffect = 0x200uL,
	TextColorEffect = 0x400uL,
	DocumentColorEffect = 0x800uL,
	ShadowEffect = 0x1000uL,
	AllEffects = 0xFFF00uL,
	StandardModes = 0xFFFFuL,
	AllModes = 0xFFFFFFFFuL
}

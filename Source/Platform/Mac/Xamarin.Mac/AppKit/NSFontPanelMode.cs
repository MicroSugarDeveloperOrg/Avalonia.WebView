using System;

namespace AppKit;

[Flags]
public enum NSFontPanelMode
{
	FaceMask = 1,
	SizeMask = 2,
	CollectionMask = 4,
	UnderlineEffectMask = 0x100,
	StrikethroughEffectMask = 0x200,
	TextColorEffectMask = 0x400,
	DocumentColorEffectMask = 0x800,
	ShadowEffectMask = 0x1000,
	AllEffectsMask = 0xFFF00,
	StandardMask = 0xFFFF,
	AllModesMask = -1
}

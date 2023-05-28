using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSFontPanelMode : ulong
{
	FaceMask = 1uL,
	SizeMask = 2uL,
	CollectionMask = 4uL,
	UnderlineEffectMask = 0x100uL,
	StrikethroughEffectMask = 0x200uL,
	TextColorEffectMask = 0x400uL,
	DocumentColorEffectMask = 0x800uL,
	ShadowEffectMask = 0x1000uL,
	AllEffectsMask = 0xFFF00uL,
	StandardMask = 0xFFFFuL,
	AllModesMask = 0xFFFFFFFFuL
}

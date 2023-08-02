using System;

namespace AudioToolbox;

[Flags]
public enum AudioChannelBit
{
	Left = 1,
	Right = 2,
	Center = 4,
	LFEScreen = 8,
	LeftSurround = 0x10,
	RightSurround = 0x20,
	LeftCenter = 0x40,
	RightCenter = 0x80,
	CenterSurround = 0x100,
	LeftSurroundDirect = 0x200,
	RightSurroundDirect = 0x400,
	TopCenterSurround = 0x800,
	VerticalHeightLeft = 0x1000,
	VerticalHeightCenter = 0x2000,
	VerticalHeightRight = 0x4000,
	TopBackLeft = 0x8000,
	TopBackCenter = 0x10000,
	TopBackRight = 0x20000
}

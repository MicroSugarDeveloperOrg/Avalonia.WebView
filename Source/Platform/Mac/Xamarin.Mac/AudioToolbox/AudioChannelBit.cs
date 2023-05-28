using System;

namespace AudioToolbox;

[Flags]
public enum AudioChannelBit : uint
{
	Left = 1u,
	Right = 2u,
	Center = 4u,
	LFEScreen = 8u,
	LeftSurround = 0x10u,
	RightSurround = 0x20u,
	LeftCenter = 0x40u,
	RightCenter = 0x80u,
	CenterSurround = 0x100u,
	LeftSurroundDirect = 0x200u,
	RightSurroundDirect = 0x400u,
	TopCenterSurround = 0x800u,
	VerticalHeightLeft = 0x1000u,
	VerticalHeightCenter = 0x2000u,
	VerticalHeightRight = 0x4000u,
	TopBackLeft = 0x8000u,
	TopBackCenter = 0x10000u,
	TopBackRight = 0x20000u,
	LeftTopFront = 0x1000u,
	CenterTopFront = 0x2000u,
	RightTopFront = 0x4000u,
	LeftTopMiddle = 0x200000u,
	CenterTopMiddle = 0x800u,
	RightTopMiddle = 0x800000u,
	LeftTopRear = 0x1000000u,
	CenterTopRear = 0x2000000u,
	RightTopRear = 0x4000000u
}

using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSLayoutFormatOptions : ulong
{
	None = 0uL,
	AlignAllLeft = 2uL,
	AlignAllRight = 4uL,
	AlignAllTop = 8uL,
	AlignAllBottom = 0x10uL,
	AlignAllLeading = 0x20uL,
	AlignAllTrailing = 0x40uL,
	AlignAllCenterX = 0x200uL,
	AlignAllCenterY = 0x400uL,
	AlignAllBaseline = 0x800uL,
	[Mac(10, 11)]
	AlignAllLastBaseline = 0x800uL,
	[Mac(10, 11)]
	AlignAllFirstBaseline = 0x1000uL,
	AlignmentMask = 0xFFFFuL,
	DirectionLeadingToTrailing = 0uL,
	DirectionLeftToRight = 0x10000uL,
	DirectionRightToLeft = 0x20000uL,
	DirectionMask = 0x30000uL
}

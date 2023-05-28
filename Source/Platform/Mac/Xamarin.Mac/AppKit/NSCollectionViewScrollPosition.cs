using System;
using ObjCRuntime;

namespace AppKit;

[Mac(10, 11)]
[Native]
[Flags]
public enum NSCollectionViewScrollPosition : ulong
{
	None = 0uL,
	Top = 1uL,
	CenteredVertically = 2uL,
	Bottom = 4uL,
	NearestHorizontalEdge = 0x200uL,
	Left = 8uL,
	CenteredHorizontally = 0x10uL,
	Right = 0x20uL,
	LeadingEdge = 0x40uL,
	TrailingEdge = 0x80uL,
	NearestVerticalEdge = 0x100uL
}

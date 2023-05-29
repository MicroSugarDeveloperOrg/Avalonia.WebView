using System;

namespace AppKit;

[Flags]
public enum NSWritingDirection : long
{
	Natural = -1L,
	LeftToRight = 0L,
	RightToLeft = 1L,
	Embedding = 0L,
	Override = 2L
}

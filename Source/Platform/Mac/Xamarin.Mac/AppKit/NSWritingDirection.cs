using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSWritingDirection : long
{
	Natural = -1L,
	LeftToRight = 0L,
	RightToLeft = 1L,
	Embedding = 0L,
	Override = 2L
}

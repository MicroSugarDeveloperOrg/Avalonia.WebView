using System;
using ObjCRuntime;

namespace Foundation;

[Native]
[Obsolete("Use NSWritingDirection in AppKit instead.")]
public enum NSWritingDirection : long
{
	Natural = -1L,
	LeftToRight,
	RightToLeft
}

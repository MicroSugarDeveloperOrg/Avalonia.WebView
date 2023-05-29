using System;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
[Flags]
public enum CTWritingDirection : sbyte
{
	Natural = -1,
	LeftToRight = 0,
	RightToLeft = 1,
	Embedding = 0,
	Override = 2
}

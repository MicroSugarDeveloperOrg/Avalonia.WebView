using System;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
[Flags]
public enum CTFrameProgression : uint
{
	TopToBottom = 0u,
	RightToLeft = 1u
}

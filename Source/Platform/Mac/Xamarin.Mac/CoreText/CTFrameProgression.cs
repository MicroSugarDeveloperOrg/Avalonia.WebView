using System;

namespace CoreText;

[Flags]
public enum CTFrameProgression : uint
{
	TopToBottom = 0u,
	RightToLeft = 1u
}

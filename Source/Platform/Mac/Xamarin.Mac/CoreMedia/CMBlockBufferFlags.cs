using System;

namespace CoreMedia;

[Flags]
public enum CMBlockBufferFlags : uint
{
	AssureMemoryNow = 1u,
	AlwaysCopyData = 2u,
	DontOptimizeDepth = 4u,
	PermitEmptyReference = 8u
}

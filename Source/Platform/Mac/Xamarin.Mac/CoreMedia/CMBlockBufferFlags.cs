using System;
using ObjCRuntime;

namespace CoreMedia;

[Flags]
[Watch(6, 0)]
public enum CMBlockBufferFlags : uint
{
	AssureMemoryNow = 1u,
	AlwaysCopyData = 2u,
	DontOptimizeDepth = 4u,
	PermitEmptyReference = 8u
}

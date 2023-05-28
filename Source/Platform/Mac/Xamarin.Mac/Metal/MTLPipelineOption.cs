using System;
using ObjCRuntime;

namespace Metal;

[Flags]
[Native]
public enum MTLPipelineOption : ulong
{
	None = 0uL,
	ArgumentInfo = 1uL,
	BufferTypeInfo = 2uL
}

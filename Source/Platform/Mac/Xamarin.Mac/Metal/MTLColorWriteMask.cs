using System;
using ObjCRuntime;

namespace Metal;

[Flags]
[Native]
public enum MTLColorWriteMask : ulong
{
	None = 0uL,
	Red = 8uL,
	Green = 4uL,
	Blue = 2uL,
	Alpha = 1uL,
	All = 0xFuL
}

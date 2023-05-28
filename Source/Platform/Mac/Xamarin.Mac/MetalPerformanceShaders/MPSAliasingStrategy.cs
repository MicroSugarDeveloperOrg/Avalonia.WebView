using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Flags]
[Native]
public enum MPSAliasingStrategy : ulong
{
	Default = 0uL,
	DontCare = 0uL,
	ShallAlias = 1uL,
	ShallNotAlias = 2uL,
	AliasingReserved = 3uL,
	PreferTemporaryMemory = 4uL,
	PreferNonTemporaryMemory = 8uL
}

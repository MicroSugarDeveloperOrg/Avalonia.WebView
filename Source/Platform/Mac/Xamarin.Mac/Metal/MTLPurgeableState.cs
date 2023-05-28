using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLPurgeableState : ulong
{
	KeepCurrent = 1uL,
	NonVolatile,
	Volatile,
	Empty
}

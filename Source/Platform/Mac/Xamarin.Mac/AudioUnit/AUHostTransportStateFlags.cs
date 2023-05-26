using ObjCRuntime;

namespace AudioUnit;

[Native]
public enum AUHostTransportStateFlags : ulong
{
	Changed = 1uL,
	Moving = 2uL,
	Recording = 4uL,
	Cycling = 8uL
}

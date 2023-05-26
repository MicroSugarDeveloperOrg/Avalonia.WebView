using System;
using ObjCRuntime;

namespace Foundation;

[Native]
[Flags]
public enum NSMatchingFlags : ulong
{
	Progress = 1uL,
	Completed = 2uL,
	HitEnd = 4uL,
	RequiredEnd = 8uL,
	InternalError = 0x10uL
}

using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSFileWrapperWritingOptions : ulong
{
	Atomic = 1uL,
	WithNameUpdating = 2uL
}

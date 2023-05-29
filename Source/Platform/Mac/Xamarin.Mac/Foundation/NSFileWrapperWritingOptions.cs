using System;

namespace Foundation;

[Flags]
public enum NSFileWrapperWritingOptions : ulong
{
	Atomic = 1uL,
	WithNameUpdating = 2uL
}

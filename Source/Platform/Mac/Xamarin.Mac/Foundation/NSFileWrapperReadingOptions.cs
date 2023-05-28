using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSFileWrapperReadingOptions : ulong
{
	Immediate = 1uL,
	WithoutMapping = 2uL
}

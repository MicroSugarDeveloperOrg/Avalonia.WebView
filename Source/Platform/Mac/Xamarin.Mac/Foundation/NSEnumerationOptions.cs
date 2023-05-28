using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSEnumerationOptions : ulong
{
	SortConcurrent = 1uL,
	Reverse = 2uL
}

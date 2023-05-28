using System;
using ObjCRuntime;

namespace CoreFoundation;

[Flags]
[Native]
public enum CFPropertyListMutabilityOptions : ulong
{
	Immutable = 0uL,
	MutableContainers = 1uL,
	MutableContainersAndLeaves = 2uL
}

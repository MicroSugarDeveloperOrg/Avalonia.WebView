using System;
using ObjCRuntime;

namespace CoreFoundation;

[Flags]
[Native]
public enum DispatchBlockFlags : ulong
{
	None = 0uL,
	Barrier = 1uL,
	Detached = 2uL,
	AssignCurrent = 4uL,
	NoQosClass = 8uL,
	InheritQosClass = 0x10uL,
	EnforceQosClass = 0x20uL
}

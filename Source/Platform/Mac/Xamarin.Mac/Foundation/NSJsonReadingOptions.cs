using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSJsonReadingOptions : ulong
{
	MutableContainers = 1uL,
	MutableLeaves = 2uL,
	FragmentsAllowed = 4uL,
	[Obsolete("Use 'FragmentsAllowed. instead.")]
	AllowFragments = 4uL
}

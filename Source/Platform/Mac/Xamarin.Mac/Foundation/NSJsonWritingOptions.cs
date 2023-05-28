using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSJsonWritingOptions : ulong
{
	PrettyPrinted = 1uL,
	[Mac(10, 13)]
	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	SortedKeys = 2uL,
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	FragmentsAllowed = 4uL,
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	WithoutEscapingSlashes = 8uL
}

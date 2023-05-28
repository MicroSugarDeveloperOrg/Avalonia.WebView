using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSFileCoordinatorReadingOptions : ulong
{
	WithoutChanges = 1uL,
	ResolvesSymbolicLink = 2uL,
	[Mac(10, 10)]
	[iOS(8, 0)]
	ImmediatelyAvailableMetadataOnly = 4uL,
	[Mac(10, 10)]
	[iOS(8, 0)]
	ForUploading = 8uL
}

using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSDirectoryEnumerationOptions : ulong
{
	SkipsNone = 0uL,
	SkipsSubdirectoryDescendants = 1uL,
	SkipsPackageDescendants = 2uL,
	SkipsHiddenFiles = 4uL,
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	IncludesDirectoriesPostOrder = 8uL,
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	ProducesRelativePathUrls = 0x10uL
}

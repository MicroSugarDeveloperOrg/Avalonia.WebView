using System;
using ObjCRuntime;

namespace Foundation;

[Since(4, 0)]
[Flags]
public enum NSDirectoryEnumerationOptions : ulong
{
	SkipsNone = 0uL,
	SkipsSubdirectoryDescendants = 1uL,
	SkipsPackageDescendants = 2uL,
	SkipsHiddenFiles = 4uL
}

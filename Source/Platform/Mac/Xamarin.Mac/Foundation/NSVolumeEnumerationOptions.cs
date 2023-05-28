using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSVolumeEnumerationOptions : ulong
{
	None = 0uL,
	SkipHiddenVolumes = 2uL,
	ProduceFileReferenceUrls = 4uL
}

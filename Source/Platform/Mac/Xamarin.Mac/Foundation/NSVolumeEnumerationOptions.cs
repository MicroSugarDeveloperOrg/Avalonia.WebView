using System;
using ObjCRuntime;

namespace Foundation;

[Since(4, 0)]
[Flags]
public enum NSVolumeEnumerationOptions : ulong
{
	None = 0uL,
	SkipHiddenVolumes = 2uL,
	ProduceFileReferenceUrls = 4uL
}

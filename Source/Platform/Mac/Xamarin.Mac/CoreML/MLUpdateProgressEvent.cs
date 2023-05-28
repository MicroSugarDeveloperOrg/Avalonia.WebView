using System;
using ObjCRuntime;

namespace CoreML;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum MLUpdateProgressEvent : ulong
{
	TrainingBegin = 1uL,
	EpochEnd = 2uL,
	MiniBatchEnd = 4uL
}

using System;
using ObjCRuntime;

namespace Foundation;

[Mac(10, 11)]
[NoWatch]
[NoTV]
[NoiOS]
[Native]
[Flags]
public enum NSFileManagerUnmountOptions : ulong
{
	AllPartitionsAndEjectDisk = 1uL,
	WithoutUI = 2uL
}

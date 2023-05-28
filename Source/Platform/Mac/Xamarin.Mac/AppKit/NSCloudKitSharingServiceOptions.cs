using System;
using ObjCRuntime;

namespace AppKit;

[Mac(10, 12)]
[Native]
[Flags]
public enum NSCloudKitSharingServiceOptions : ulong
{
	Standard = 0uL,
	AllowPublic = 1uL,
	AllowPrivate = 2uL,
	AllowReadOnly = 0x10uL,
	AllowReadWrite = 0x20uL
}

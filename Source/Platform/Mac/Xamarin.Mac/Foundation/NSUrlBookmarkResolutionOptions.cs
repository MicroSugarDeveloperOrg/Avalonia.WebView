using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSUrlBookmarkResolutionOptions : ulong
{
	WithoutUI = 0x100uL,
	WithoutMounting = 0x200uL,
	WithSecurityScope = 0x400uL
}

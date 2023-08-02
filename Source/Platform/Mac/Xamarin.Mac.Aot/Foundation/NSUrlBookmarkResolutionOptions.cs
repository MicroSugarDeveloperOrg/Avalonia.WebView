using System;

namespace Foundation;

[Flags]
public enum NSUrlBookmarkResolutionOptions : ulong
{
	WithoutUI = 0x100uL,
	WithoutMounting = 0x200uL,
	WithSecurityScope = 0x400uL
}

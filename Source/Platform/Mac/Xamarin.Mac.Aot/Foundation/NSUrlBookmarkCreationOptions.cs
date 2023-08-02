using System;

namespace Foundation;

[Flags]
public enum NSUrlBookmarkCreationOptions : ulong
{
	PreferFileIDResolution = 0x100uL,
	MinimalBookmark = 0x200uL,
	SuitableForBookmarkFile = 0x400uL,
	WithSecurityScope = 0x800uL,
	SecurityScopeAllowOnlyReadAccess = 0x1000uL
}

using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSDataWritingOptions : ulong
{
	Atomic = 1uL,
	WithoutOverwriting = 2uL,
	FileProtectionNone = 0x10000000uL,
	FileProtectionComplete = 0x20000000uL,
	FileProtectionMask = 0xF0000000uL,
	FileProtectionCompleteUnlessOpen = 0x30000000uL,
	FileProtectionCompleteUntilFirstUserAuthentication = 0x40000000uL
}

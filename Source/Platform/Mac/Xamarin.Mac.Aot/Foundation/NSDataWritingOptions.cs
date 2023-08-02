using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
public enum NSDataWritingOptions : ulong
{
	Atomic = 1uL,
	WithoutOverwriting = 2uL,
	[Obsolete("No longer available")]
	Coordinated = 4uL,
	[Since(4, 0)]
	FileProtectionNone = 0x10000000uL,
	[Since(4, 0)]
	FileProtectionComplete = 0x20000000uL,
	[Since(4, 0)]
	FileProtectionMask = 0xF0000000uL,
	[Since(5, 0)]
	FileProtectionCompleteUnlessOpen = 0x30000000uL,
	[Since(5, 0)]
	FileProtectionCompleteUntilFirstUserAuthentication = 0x40000000uL
}

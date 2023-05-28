using System;
using ObjCRuntime;

namespace Security;

[iOS(7, 0)]
[Flags]
[Native]
public enum SecRevocation : ulong
{
	None = 0uL,
	OCSPMethod = 1uL,
	CRLMethod = 2uL,
	PreferCRL = 4uL,
	RequirePositiveResponse = 8uL,
	NetworkAccessDisabled = 0x10uL,
	UseAnyAvailableMethod = 3uL
}

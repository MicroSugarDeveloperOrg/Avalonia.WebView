using System;
using ObjCRuntime;

namespace CoreFoundation;

[Flags]
[Native]
public enum CFStreamEventType : ulong
{
	None = 0uL,
	OpenCompleted = 1uL,
	HasBytesAvailable = 2uL,
	CanAcceptBytes = 4uL,
	ErrorOccurred = 8uL,
	EndEncountered = 0x10uL
}

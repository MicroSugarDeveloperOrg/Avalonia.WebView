using System;

namespace CoreFoundation;

[Flags]
public enum CFStreamEventType
{
	None = 0,
	OpenCompleted = 1,
	HasBytesAvailable = 2,
	CanAcceptBytes = 4,
	ErrorOccurred = 8,
	EndEncountered = 0x10
}

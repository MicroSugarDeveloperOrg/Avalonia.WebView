namespace Foundation;

public enum NSStreamEvent : ulong
{
	None = 0uL,
	OpenCompleted = 1uL,
	HasBytesAvailable = 2uL,
	HasSpaceAvailable = 4uL,
	ErrorOccurred = 8uL,
	EndEncountered = 0x10uL
}

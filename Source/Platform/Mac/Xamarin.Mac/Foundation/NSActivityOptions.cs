using System;

namespace Foundation;

[Flags]
public enum NSActivityOptions : ulong
{
	IdleDisplaySleepDisabled = 0x10000000000uL,
	IdleSystemSleepDisabled = 0x100000uL,
	SuddenTerminationDisabled = 0x4000uL,
	AutomaticTerminationDisabled = 0x8000uL,
	UserInitiated = 0xFFFFFFuL,
	Background = 0xFFuL,
	LatencyCritical = 0xFF00000000uL
}

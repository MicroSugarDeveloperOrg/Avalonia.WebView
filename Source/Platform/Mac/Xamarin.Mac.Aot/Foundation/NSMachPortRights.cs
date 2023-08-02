using System;

namespace Foundation;

[Flags]
public enum NSMachPortRights : ulong
{
	None = 0uL,
	SendRight = 1uL,
	ReceiveRight = 2uL
}

using System;

namespace Foundation;

[Flags]
public enum NSNotificationFlags : ulong
{
	DeliverImmediately = 1uL,
	PostToAllSessions = 2uL
}

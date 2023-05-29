using System;

namespace Foundation;

[Flags]
public enum NSNotificationCoalescing : ulong
{
	NoCoalescing = 0uL,
	CoalescingOnName = 1uL,
	CoalescingOnSender = 2uL
}

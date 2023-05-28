using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSNotificationCoalescing : ulong
{
	NoCoalescing = 0uL,
	CoalescingOnName = 1uL,
	CoalescingOnSender = 2uL
}

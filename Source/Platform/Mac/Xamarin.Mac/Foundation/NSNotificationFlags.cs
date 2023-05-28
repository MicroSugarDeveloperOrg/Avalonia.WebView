using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSNotificationFlags : ulong
{
	DeliverImmediately = 1uL,
	PostToAllSessions = 2uL
}

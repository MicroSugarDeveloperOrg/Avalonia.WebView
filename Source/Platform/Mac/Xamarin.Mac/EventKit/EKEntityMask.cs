using System;
using ObjCRuntime;

namespace EventKit;

[Flags]
[Native]
public enum EKEntityMask : ulong
{
	Event = 1uL,
	Reminder = 2uL
}

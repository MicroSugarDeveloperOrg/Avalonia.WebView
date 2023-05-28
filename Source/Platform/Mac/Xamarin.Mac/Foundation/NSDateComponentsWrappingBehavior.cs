using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSDateComponentsWrappingBehavior : ulong
{
	None = 0uL,
	WrapCalendarComponents = 1uL
}

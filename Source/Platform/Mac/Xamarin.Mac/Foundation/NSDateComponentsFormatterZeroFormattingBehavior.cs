using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
[Mac(10, 10)]
[iOS(8, 0)]
public enum NSDateComponentsFormatterZeroFormattingBehavior : ulong
{
	None = 0uL,
	Default = 1uL,
	DropLeading = 2uL,
	DropMiddle = 4uL,
	DropTrailing = 8uL,
	DropAll = 0xEuL,
	Pad = 0x10000uL
}

using System;

namespace Foundation;

[Flags]
public enum NSByteCountFormatterUnits : ulong
{
	UseDefault = 0uL,
	UseBytes = 1uL,
	UseKB = 2uL,
	UseMB = 4uL,
	UseGB = 8uL,
	UseTB = 0x10uL,
	UsePB = 0x20uL,
	UseEB = 0x40uL,
	UseZB = 0x80uL,
	UseYBOrHigher = 0xFF00uL,
	UseAll = 0xFFFFuL
}

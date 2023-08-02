using System;

namespace Darwin;

[Flags]
public enum EventFlags : ushort
{
	Add = 1,
	Delete = 2,
	Enable = 4,
	Disable = 8,
	OneShot = 0x10,
	Clear = 0x20,
	Receipt = 0x40,
	Dispatch = 0x80,
	Flag0 = 0x1000,
	Flag1 = 0x2000,
	SystemFlags = 0xF000,
	EOF = 0x8000,
	Error = 0x4000
}

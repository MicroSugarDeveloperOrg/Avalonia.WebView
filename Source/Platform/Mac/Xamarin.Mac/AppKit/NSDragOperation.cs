using System;

namespace AppKit;

[Flags]
public enum NSDragOperation : ulong
{
	None = 0uL,
	Copy = 1uL,
	Link = 2uL,
	Generic = 4uL,
	Private = 8uL,
	AllObsolete = 0xFuL,
	Move = 0x10uL,
	Delete = 0x20uL,
	All = ulong.MaxValue
}

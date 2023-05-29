using System;

namespace AppKit;

[Flags]
public enum NSFileWrapperReadingOptions : ulong
{
	Immediate = 1uL,
	WithoutMapping = 2uL
}

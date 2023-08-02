using System;

namespace AppKit;

[Flags]
public enum NSFontCollectionVisibility : ulong
{
	Process = 1uL,
	User = 2uL,
	Computer = 4uL
}

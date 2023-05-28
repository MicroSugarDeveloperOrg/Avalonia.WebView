using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSFontCollectionVisibility : ulong
{
	Process = 1uL,
	User = 2uL,
	Computer = 4uL
}

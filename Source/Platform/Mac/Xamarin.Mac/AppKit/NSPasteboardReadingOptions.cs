using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSPasteboardReadingOptions : ulong
{
	AsData = 0uL,
	AsString = 1uL,
	AsPropertyList = 2uL,
	AsKeyedArchive = 4uL
}

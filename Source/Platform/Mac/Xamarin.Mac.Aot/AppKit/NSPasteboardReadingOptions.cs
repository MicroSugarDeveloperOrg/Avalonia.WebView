using System;

namespace AppKit;

[Flags]
public enum NSPasteboardReadingOptions : ulong
{
	AsData = 0uL,
	AsString = 1uL,
	AsPropertyList = 2uL,
	AsKeyedArchive = 4uL
}

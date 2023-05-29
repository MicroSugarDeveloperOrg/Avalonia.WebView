using System;

namespace AppKit;

[Flags]
public enum NSPasteboardWritingOptions : ulong
{
	WritingPromised = 0x200uL
}

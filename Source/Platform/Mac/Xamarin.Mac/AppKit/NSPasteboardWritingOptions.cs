using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSPasteboardWritingOptions : ulong
{
	WritingPromised = 0x200uL
}

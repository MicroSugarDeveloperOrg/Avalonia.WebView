using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSDraggingItemEnumerationOptions : ulong
{
	Concurrent = 1uL,
	ClearNonenumeratedImages = 0x10000uL
}

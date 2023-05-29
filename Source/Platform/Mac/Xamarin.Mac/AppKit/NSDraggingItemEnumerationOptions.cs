using System;

namespace AppKit;

[Flags]
public enum NSDraggingItemEnumerationOptions : ulong
{
	Concurrent = 1uL,
	ClearNonenumeratedImages = 0x10000uL
}

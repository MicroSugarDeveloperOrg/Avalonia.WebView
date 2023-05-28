using System;

namespace CoreServices;

[Flags]
public enum FSEventStreamCreateFlags : uint
{
	None = 0u,
	NoDefer = 2u,
	WatchRoot = 4u,
	IgnoreSelf = 8u,
	FileEvents = 0x10u,
	[Mac(10, 9)]
	MarkSelf = 0x20u,
	[Mac(10, 13)]
	UseExtendedData = 0x40u
}

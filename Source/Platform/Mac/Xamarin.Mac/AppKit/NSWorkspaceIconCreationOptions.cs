using System;

namespace AppKit;

[Flags]
public enum NSWorkspaceIconCreationOptions : ulong
{
	NSExcludeQuickDrawElements = 2uL,
	NSExclude10_4Elements = 4uL
}

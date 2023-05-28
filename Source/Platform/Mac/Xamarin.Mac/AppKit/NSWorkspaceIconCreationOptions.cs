using System;
using ObjCRuntime;

namespace AppKit;

[Flags]
[Native]
public enum NSWorkspaceIconCreationOptions : ulong
{
	NSExcludeQuickDrawElements = 2uL,
	NSExclude10_4Elements = 4uL
}

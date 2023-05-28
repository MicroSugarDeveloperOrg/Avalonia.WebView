using System;
using ObjCRuntime;

namespace AppKit;

[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use NSTextStorageEditActions instead.")]
[Flags]
[Native]
public enum NSTextStorageEditedFlags : ulong
{
	EditedAttributed = 1uL,
	EditedCharacters = 2uL
}

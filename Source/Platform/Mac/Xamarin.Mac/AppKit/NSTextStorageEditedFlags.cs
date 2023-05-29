using System;

namespace AppKit;

[Flags]
public enum NSTextStorageEditedFlags : ulong
{
	EditedAttributed = 1uL,
	EditedCharacters = 2uL
}

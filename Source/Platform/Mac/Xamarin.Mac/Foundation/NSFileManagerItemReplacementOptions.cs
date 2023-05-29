using System;
using ObjCRuntime;

namespace Foundation;

[Since(4, 0)]
[Flags]
public enum NSFileManagerItemReplacementOptions : ulong
{
	None = 0uL,
	UsingNewMetadataOnly = 1uL,
	WithoutDeletingBackupItem = 2uL
}

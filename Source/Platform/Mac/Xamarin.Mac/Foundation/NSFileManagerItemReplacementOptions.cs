using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSFileManagerItemReplacementOptions : ulong
{
	None = 0uL,
	UsingNewMetadataOnly = 1uL,
	WithoutDeletingBackupItem = 2uL
}

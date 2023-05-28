using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSFileCoordinatorWritingOptions : ulong
{
	ForDeleting = 1uL,
	ForMoving = 2uL,
	ForMerging = 4uL,
	ForReplacing = 8uL
}

using System;

namespace Foundation;

[Flags]
public enum NSFileCoordinatorWritingOptions : ulong
{
	ForDeleting = 1uL,
	ForMoving = 2uL,
	ForMerging = 4uL,
	ForReplacing = 8uL
}

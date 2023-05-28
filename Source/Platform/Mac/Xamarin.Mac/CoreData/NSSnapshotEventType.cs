using ObjCRuntime;

namespace CoreData;

[Native]
public enum NSSnapshotEventType : ulong
{
	UndoInsertion = 2uL,
	UndoDeletion = 4uL,
	UndoUpdate = 8uL,
	Rollback = 0x10uL,
	Refresh = 0x20uL,
	MergePolicy = 0x40uL
}

using ObjCRuntime;

namespace CoreData;

[Native]
public enum NSFetchedResultsChangeType : ulong
{
	Insert = 1uL,
	Delete,
	Move,
	Update
}

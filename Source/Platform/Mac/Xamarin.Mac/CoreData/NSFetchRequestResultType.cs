using System;

namespace CoreData;

[Flags]
public enum NSFetchRequestResultType : ulong
{
	ManagedObject = 0uL,
	ManagedObjectID = 1uL,
	DictionaryResultType = 2uL,
	NSCountResultType = 4uL
}

using System;
using ObjCRuntime;

namespace CoreData;

[Flags]
[Native]
public enum NSFetchRequestResultType : ulong
{
	ManagedObject = 0uL,
	ManagedObjectID = 1uL,
	DictionaryResultType = 2uL,
	NSCountResultType = 4uL
}

using ObjCRuntime;

namespace CoreData;

[Native]
public enum NSPersistentStoreRequestType : ulong
{
	Fetch = 1uL,
	Save = 2uL,
	BatchUpdate = 6uL,
	BatchDelete = 7uL
}

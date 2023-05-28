using ObjCRuntime;

namespace CoreData;

[Native]
public enum ObjectGraphManagementErrorType : ulong
{
	ManagedObjectContextLocking = 132000uL,
	PersistentStoreCoordinatorLocking = 132010uL,
	ManagedObjectReferentialIntegrity = 133000uL,
	ManagedObjectExternalRelationship = 133010uL,
	ManagedObjectMerge = 133020uL
}

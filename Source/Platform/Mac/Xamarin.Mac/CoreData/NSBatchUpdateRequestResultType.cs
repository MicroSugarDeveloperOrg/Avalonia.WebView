using ObjCRuntime;

namespace CoreData;

[Native]
public enum NSBatchUpdateRequestResultType : ulong
{
	StatusOnly,
	UpdatedObjectIDs,
	UpdatedObjectsCount
}

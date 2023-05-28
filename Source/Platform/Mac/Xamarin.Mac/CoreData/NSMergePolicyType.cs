using ObjCRuntime;

namespace CoreData;

[Native]
public enum NSMergePolicyType : ulong
{
	Error,
	PropertyStoreTrump,
	PropertyObjectTrump,
	Overwrite,
	RollbackMerge
}

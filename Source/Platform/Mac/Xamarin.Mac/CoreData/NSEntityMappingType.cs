using ObjCRuntime;

namespace CoreData;

[Native]
public enum NSEntityMappingType : ulong
{
	Undefined,
	Custom,
	Add,
	Remove,
	Copy,
	Transform
}

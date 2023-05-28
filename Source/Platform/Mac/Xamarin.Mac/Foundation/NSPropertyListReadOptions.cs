using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSPropertyListReadOptions : ulong
{
	Immutable,
	MutableContainers,
	MutableContainersAndLeaves
}

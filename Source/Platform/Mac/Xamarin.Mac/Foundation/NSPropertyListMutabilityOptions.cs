using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSPropertyListMutabilityOptions : ulong
{
	Immutable,
	MutableContainers,
	MutableContainersAndLeaves
}

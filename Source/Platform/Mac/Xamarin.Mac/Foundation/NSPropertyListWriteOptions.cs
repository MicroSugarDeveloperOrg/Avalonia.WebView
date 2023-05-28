using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSPropertyListWriteOptions : ulong
{
	Immutable,
	MutableContainers,
	MutableContainersAndLeaves
}

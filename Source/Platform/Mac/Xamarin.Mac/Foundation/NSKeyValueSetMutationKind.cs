using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSKeyValueSetMutationKind : ulong
{
	UnionSet = 1uL,
	MinusSet,
	IntersectSet,
	SetSet
}

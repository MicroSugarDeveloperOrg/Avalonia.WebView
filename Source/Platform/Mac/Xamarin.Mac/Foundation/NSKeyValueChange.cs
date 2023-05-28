using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSKeyValueChange : ulong
{
	Setting = 1uL,
	Insertion,
	Removal,
	Replacement
}

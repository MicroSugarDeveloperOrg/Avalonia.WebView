using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLArgumentAccess : ulong
{
	ReadOnly,
	ReadWrite,
	WriteOnly
}

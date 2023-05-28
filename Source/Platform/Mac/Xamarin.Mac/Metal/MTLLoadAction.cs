using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLLoadAction : ulong
{
	DontCare,
	Load,
	Clear
}

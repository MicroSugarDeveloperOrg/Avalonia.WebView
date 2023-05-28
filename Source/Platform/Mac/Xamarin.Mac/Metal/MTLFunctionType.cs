using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLFunctionType : ulong
{
	Vertex = 1uL,
	Fragment,
	Kernel
}

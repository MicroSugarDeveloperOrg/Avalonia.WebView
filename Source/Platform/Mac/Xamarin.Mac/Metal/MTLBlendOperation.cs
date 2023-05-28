using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLBlendOperation : ulong
{
	Add,
	Subtract,
	ReverseSubtract,
	Min,
	Max
}

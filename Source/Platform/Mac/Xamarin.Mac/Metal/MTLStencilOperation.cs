using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLStencilOperation : ulong
{
	Keep,
	Zero,
	Replace,
	IncrementClamp,
	DecrementClamp,
	Invert,
	IncrementWrap,
	DecrementWrap
}

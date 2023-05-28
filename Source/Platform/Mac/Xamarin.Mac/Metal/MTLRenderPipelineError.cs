using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLRenderPipelineError : ulong
{
	Internal = 1uL,
	Unsupported,
	InvalidInput
}

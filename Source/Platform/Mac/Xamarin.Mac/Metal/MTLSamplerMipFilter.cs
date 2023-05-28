using ObjCRuntime;

namespace Metal;

[Native]
public enum MTLSamplerMipFilter : ulong
{
	NotMipmapped,
	Nearest,
	Linear
}

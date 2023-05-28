using ObjCRuntime;

namespace MetalPerformanceShaders;

[iOS(10, 0)]
[TV(10, 0)]
[Mac(10, 13)]
[Native]
public enum MPSAlphaType : ulong
{
	NonPremultiplied,
	AlphaIsOne,
	Premultiplied
}

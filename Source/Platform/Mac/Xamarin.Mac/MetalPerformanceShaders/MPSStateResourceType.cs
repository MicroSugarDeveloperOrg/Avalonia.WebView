using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[TV(11, 3)]
[iOS(11, 3)]
[Mac(10, 13, 4)]
[Native]
public enum MPSStateResourceType : ulong
{
	None,
	Buffer,
	Texture
}

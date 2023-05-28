using ObjCRuntime;

namespace MetalPerformanceShaders;

[iOS(10, 0)]
[TV(10, 0)]
[Mac(10, 13)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Native]
public enum MPSImageFeatureChannelFormat : ulong
{
	Invalid,
	Unorm8,
	Unorm16,
	Float16,
	Float32,
	[iOS(13, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	Reserved0
}

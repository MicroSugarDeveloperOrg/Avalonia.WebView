using ObjCRuntime;

namespace MetalPerformanceShaders;

[TV(11, 0)]
[Mac(10, 13)]
[iOS(11, 0)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Native]
public enum MPSDataLayout : ulong
{
	HeightPerWidthPerFeatureChannels,
	FeatureChannelsPerHeightPerWidth
}

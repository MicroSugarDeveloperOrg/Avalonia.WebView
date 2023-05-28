using System;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[TV(11, 0)]
[Mac(10, 13)]
[iOS(11, 0)]
public struct MPSImageReadWriteParams
{
	public nuint FeatureChannelOffset;

	public nuint NumberOfFeatureChannelsToReadWrite;
}

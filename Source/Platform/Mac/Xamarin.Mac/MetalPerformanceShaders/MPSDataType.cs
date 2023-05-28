using ObjCRuntime;

namespace MetalPerformanceShaders;

[iOS(10, 0)]
[TV(10, 0)]
[Mac(10, 13)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
public enum MPSDataType : uint
{
	Invalid = 0u,
	FloatBit = 268435456u,
	Float16 = 268435472u,
	Float32 = 268435488u,
	SignedBit = 536870912u,
	Int8 = 536870920u,
	Int16 = 536870928u,
	Int32 = 536870944u,
	UInt8 = 8u,
	UInt16 = 16u,
	UInt32 = 32u,
	[iOS(11, 0)]
	[TV(11, 0)]
	NormalizedBit = 1073741824u,
	[iOS(11, 0)]
	[TV(11, 0)]
	Unorm1 = 1073741825u,
	[iOS(11, 0)]
	[TV(11, 0)]
	Unorm8 = 1073741832u
}

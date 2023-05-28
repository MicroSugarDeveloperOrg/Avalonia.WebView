using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Native]
public enum CBCharacteristicWriteType : long
{
	WithResponse,
	WithoutResponse
}

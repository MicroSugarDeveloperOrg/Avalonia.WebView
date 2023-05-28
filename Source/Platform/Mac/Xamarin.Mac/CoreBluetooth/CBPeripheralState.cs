using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Native]
public enum CBPeripheralState : long
{
	Disconnected,
	Connecting,
	Connected,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	Disconnecting
}

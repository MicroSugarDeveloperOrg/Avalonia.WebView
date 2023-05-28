using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Native]
public enum CBManagerState : long
{
	Unknown,
	Resetting,
	Unsupported,
	Unauthorized,
	PoweredOff,
	PoweredOn
}

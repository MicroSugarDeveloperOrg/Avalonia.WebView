using ObjCRuntime;

namespace CoreBluetooth;

[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CBManagerState' instead.")]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Native]
public enum CBPeripheralManagerState : long
{
	Unknown,
	Resetting,
	Unsupported,
	Unauthorized,
	PoweredOff,
	PoweredOn
}

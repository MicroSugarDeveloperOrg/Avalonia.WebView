using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Native]
public enum CBPeripheralManagerAuthorizationStatus : long
{
	NotDetermined,
	Restricted,
	Denied,
	Authorized
}

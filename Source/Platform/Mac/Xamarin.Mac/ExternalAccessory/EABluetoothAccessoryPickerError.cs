using ObjCRuntime;

namespace ExternalAccessory;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Native]
public enum EABluetoothAccessoryPickerError : long
{
	AlreadyConnected,
	NotFound,
	Cancelled,
	Failed
}

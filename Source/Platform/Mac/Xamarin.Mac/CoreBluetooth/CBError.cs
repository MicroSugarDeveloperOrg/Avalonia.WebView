using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Native]
public enum CBError : long
{
	None = 0L,
	Unknown = 0L,
	InvalidParameters = 1L,
	InvalidHandle = 2L,
	NotConnected = 3L,
	OutOfSpace = 4L,
	OperationCancelled = 5L,
	ConnectionTimeout = 6L,
	PeripheralDisconnected = 7L,
	UUIDNotAllowed = 8L,
	AlreadyAdvertising = 9L,
	[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	ConnectionFailed = 10L,
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	ConnectionLimitReached = 11L,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	UnknownDevice = 12L,
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	OperationNotSupported = 13L,
	PeerRemovedPairingInformation = 14L,
	EncryptionTimedOut = 15L
}

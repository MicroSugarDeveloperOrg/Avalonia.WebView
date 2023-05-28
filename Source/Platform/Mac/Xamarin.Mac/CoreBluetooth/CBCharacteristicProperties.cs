using System;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum CBCharacteristicProperties : ulong
{
	Broadcast = 1uL,
	Read = 2uL,
	WriteWithoutResponse = 4uL,
	Write = 8uL,
	Notify = 0x10uL,
	Indicate = 0x20uL,
	AuthenticatedSignedWrites = 0x40uL,
	ExtendedProperties = 0x80uL,
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	NotifyEncryptionRequired = 0x100uL,
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	IndicateEncryptionRequired = 0x200uL
}

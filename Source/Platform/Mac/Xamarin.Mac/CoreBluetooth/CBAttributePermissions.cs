using System;
using ObjCRuntime;

namespace CoreBluetooth;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum CBAttributePermissions : ulong
{
	Readable = 1uL,
	Writeable = 2uL,
	ReadEncryptionRequired = 4uL,
	WriteEncryptionRequired = 8uL
}

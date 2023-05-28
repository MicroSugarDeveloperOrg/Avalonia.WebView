using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Native]
public enum NEVpnStatus : long
{
	Invalid,
	Disconnected,
	Connecting,
	Connected,
	Reasserting,
	Disconnecting
}

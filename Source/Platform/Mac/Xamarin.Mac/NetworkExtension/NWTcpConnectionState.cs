using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Native]
public enum NWTcpConnectionState : long
{
	Invalid,
	Connecting,
	Waiting,
	Connected,
	Disconnected,
	Cancelled
}

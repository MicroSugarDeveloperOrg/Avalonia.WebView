using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Native]
public enum NWUdpSessionState : long
{
	Invalid,
	Waiting,
	Preparing,
	Ready,
	Failed,
	Cancelled
}

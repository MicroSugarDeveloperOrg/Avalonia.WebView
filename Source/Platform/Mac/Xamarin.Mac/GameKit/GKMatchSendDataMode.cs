using ObjCRuntime;

namespace GameKit;

[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
[Native]
public enum GKMatchSendDataMode : long
{
	Reliable,
	Unreliable
}

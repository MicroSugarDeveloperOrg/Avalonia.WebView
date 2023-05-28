using ObjCRuntime;

namespace GameKit;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Native]
public enum GKChallengeState : long
{
	Invalid,
	Pending,
	Completed,
	Declined
}

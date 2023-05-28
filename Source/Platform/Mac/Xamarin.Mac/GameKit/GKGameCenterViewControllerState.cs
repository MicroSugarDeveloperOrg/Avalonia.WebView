using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Native]
public enum GKGameCenterViewControllerState : long
{
	Default = -1L,
	Leaderboards,
	Achievements,
	Challenges
}

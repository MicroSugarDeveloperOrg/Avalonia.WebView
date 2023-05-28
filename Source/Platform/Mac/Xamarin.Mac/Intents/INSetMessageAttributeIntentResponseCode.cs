using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Native]
public enum INSetMessageAttributeIntentResponseCode : long
{
	Unspecified,
	Ready,
	InProgress,
	Success,
	Failure,
	FailureRequiringAppLaunch,
	FailureMessageNotFound,
	FailureMessageAttributeNotSet
}

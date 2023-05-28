using ObjCRuntime;

namespace Intents;

[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'INStartCallIntentResponseCode' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'INStartCallIntentResponseCode' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'INStartCallIntentResponseCode' instead.")]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[Native]
public enum INStartAudioCallIntentResponseCode : long
{
	Unspecified,
	Ready,
	ContinueInApp,
	Failure,
	FailureRequiringAppLaunch,
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.Arch64, null)]
	FailureAppConfigurationRequired,
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.Arch64, null)]
	FailureCallingServiceNotAvailable,
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	FailureContactNotSupportedByApp,
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	FailureNoValidNumber
}

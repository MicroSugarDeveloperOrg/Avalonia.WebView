using ObjCRuntime;

namespace GameKit;

[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
[Native]
public enum GKAuthenticationType : ulong
{
	WithoutUI,
	GreenBuddyUI,
	AuthKitInvocation
}

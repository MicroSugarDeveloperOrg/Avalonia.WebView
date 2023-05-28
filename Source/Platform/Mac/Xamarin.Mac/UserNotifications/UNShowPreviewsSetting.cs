using ObjCRuntime;

namespace UserNotifications;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Native]
public enum UNShowPreviewsSetting : long
{
	Always,
	WhenAuthenticated,
	Never
}

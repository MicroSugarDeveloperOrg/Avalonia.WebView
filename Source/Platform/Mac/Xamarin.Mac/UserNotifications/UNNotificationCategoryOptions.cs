using System;
using ObjCRuntime;

namespace UserNotifications;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum UNNotificationCategoryOptions : ulong
{
	None = 0uL,
	CustomDismissAction = 1uL,
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	AllowInCarPlay = 2uL,
	HiddenPreviewsShowTitle = 4uL,
	HiddenPreviewsShowSubtitle = 8uL,
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	AllowAnnouncement = 0x10uL
}

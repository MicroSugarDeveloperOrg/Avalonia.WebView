using System;
using ObjCRuntime;

namespace UserNotifications;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum UNNotificationPresentationOptions : ulong
{
	None = 0uL,
	Badge = 1uL,
	Sound = 2uL,
	Alert = 4uL
}

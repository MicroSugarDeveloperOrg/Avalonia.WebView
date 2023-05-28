using System;
using ObjCRuntime;

namespace UserNotifications;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum UNNotificationActionOptions : ulong
{
	None = 0uL,
	AuthenticationRequired = 1uL,
	Destructive = 2uL,
	Foreground = 4uL
}

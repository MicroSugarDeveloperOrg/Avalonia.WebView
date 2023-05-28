using System;
using ObjCRuntime;

namespace UserNotifications;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum UNAuthorizationOptions : ulong
{
	None = 0uL,
	Badge = 1uL,
	Sound = 2uL,
	Alert = 4uL,
	CarPlay = 8uL,
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	CriticalAlert = 0x10uL,
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	ProvidesAppNotificationSettings = 0x20uL,
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	Provisional = 0x40uL
}

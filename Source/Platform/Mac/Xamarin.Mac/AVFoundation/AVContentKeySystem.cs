using System;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public enum AVContentKeySystem
{
	FairPlayStreaming = 0,
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	ClearKey = 1,
	[Obsolete("Use 'AVContentKeySystem.SystemClearKey' instead.", false)]
	AVContentKeySystemClearKey = 1,
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	AuthorizationToken = 2
}

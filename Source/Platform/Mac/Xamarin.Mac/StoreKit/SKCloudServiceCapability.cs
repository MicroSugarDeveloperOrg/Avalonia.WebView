using ObjCRuntime;

namespace StoreKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
[Native]
public enum SKCloudServiceCapability : ulong
{
	None = 0uL,
	MusicCatalogPlayback = 1uL,
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 1, PlatformArchitecture.All, null)]
	MusicCatalogSubscriptionEligible = 2uL,
	AddToCloudMusicLibrary = 0x100uL
}

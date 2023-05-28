using ObjCRuntime;

namespace AVKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVKitError : long
{
	None = 0L,
	Unknown = -1000L,
	PictureInPictureStartFailed = -1001L,
	ContentRatingUnknown = -1100L,
	ContentDisallowedByPasscode = -1101L,
	ContentDisallowedByProfile = -1102L
}

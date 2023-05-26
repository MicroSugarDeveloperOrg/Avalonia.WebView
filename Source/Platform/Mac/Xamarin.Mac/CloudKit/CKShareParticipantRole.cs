using ObjCRuntime;

namespace CloudKit;

[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Native]
public enum CKShareParticipantRole : long
{
	Unknown = 0L,
	Owner = 1L,
	PrivateUser = 3L,
	PublicUser = 4L
}

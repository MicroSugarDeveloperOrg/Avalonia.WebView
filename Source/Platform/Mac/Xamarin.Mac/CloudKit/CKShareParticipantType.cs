using ObjCRuntime;

namespace CloudKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum CKShareParticipantType : long
{
	Unknown = 0L,
	Owner = 1L,
	PrivateUser = 3L,
	PublicUser = 4L
}

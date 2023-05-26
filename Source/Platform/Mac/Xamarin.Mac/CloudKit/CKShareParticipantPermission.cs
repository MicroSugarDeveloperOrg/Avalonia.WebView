using ObjCRuntime;

namespace CloudKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum CKShareParticipantPermission : long
{
	Unknown,
	None,
	ReadOnly,
	ReadWrite
}

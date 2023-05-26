using ObjCRuntime;

namespace CloudKit;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum CKQuerySubscriptionOptions : ulong
{
	RecordCreation = 1uL,
	RecordUpdate = 2uL,
	RecordDeletion = 4uL,
	FiresOnce = 8uL
}

using System;
using ObjCRuntime;

namespace CloudKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'CKQuerySubscriptionOptions' instead.")]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'CKQuerySubscriptionOptions' instead.")]
[Flags]
[Native]
public enum CKSubscriptionOptions : ulong
{
	FiresOnRecordCreation = 1uL,
	FiresOnRecordUpdate = 2uL,
	FiresOnRecordDeletion = 4uL,
	FiresOnce = 8uL
}

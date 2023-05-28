using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVAssetReferenceRestrictions : ulong
{
	ForbidNone = 0uL,
	ForbidRemoteReferenceToLocal = 1uL,
	ForbidLocalReferenceToRemote = 2uL,
	ForbidCrossSiteReference = 4uL,
	ForbidLocalReferenceToLocal = 8uL,
	ForbidAll = 65535uL
}

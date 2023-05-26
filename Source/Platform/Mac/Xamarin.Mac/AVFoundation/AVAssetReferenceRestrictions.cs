namespace AVFoundation;

public enum AVAssetReferenceRestrictions
{
	ForbidNone = 0,
	ForbidRemoteReferenceToLocal = 1,
	ForbidLocalReferenceToRemote = 2,
	ForbidCrossSiteReference = 4,
	ForbidLocalReferenceToLocal = 8,
	ForbidAll = 65535
}

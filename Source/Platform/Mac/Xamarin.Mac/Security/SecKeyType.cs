using ObjCRuntime;

namespace Security;

public enum SecKeyType
{
	Invalid = -1,
	RSA,
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	EC,
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	ECSecPrimeRandom
}

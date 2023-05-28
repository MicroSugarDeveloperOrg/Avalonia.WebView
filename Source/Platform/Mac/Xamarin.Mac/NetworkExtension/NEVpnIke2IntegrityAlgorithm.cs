using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Native]
public enum NEVpnIke2IntegrityAlgorithm : long
{
	SHA96 = 1L,
	SHA160,
	SHA256,
	SHA384,
	SHA512
}

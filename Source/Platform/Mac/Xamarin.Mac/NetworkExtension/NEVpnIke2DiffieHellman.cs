using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Native]
public enum NEVpnIke2DiffieHellman : long
{
	Invalid = 0L,
	Group0 = 0L,
	Group1 = 1L,
	Group2 = 2L,
	Group5 = 5L,
	Group14 = 14L,
	Group15 = 15L,
	Group16 = 16L,
	Group17 = 17L,
	Group18 = 18L,
	Group19 = 19L,
	Group20 = 20L,
	Group21 = 21L,
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	Group31 = 31L
}

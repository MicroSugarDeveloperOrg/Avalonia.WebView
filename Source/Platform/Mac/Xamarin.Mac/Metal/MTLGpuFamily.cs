using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum MTLGpuFamily : long
{
	Apple1 = 1001L,
	Apple2 = 1002L,
	Apple3 = 1003L,
	Apple4 = 1004L,
	Apple5 = 1005L,
	Mac1 = 2001L,
	Mac2 = 2002L,
	Common1 = 3001L,
	Common2 = 3002L,
	Common3 = 3003L,
	iOSMac1 = 4001L,
	iOSMac2 = 4002L
}

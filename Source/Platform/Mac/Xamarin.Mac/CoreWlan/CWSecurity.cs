using ObjCRuntime;

namespace CoreWlan;

[Native]
public enum CWSecurity : ulong
{
	None = 0uL,
	WEP = 1uL,
	WPAPersonal = 2uL,
	WPAPersonalMixed = 3uL,
	WPA2Personal = 4uL,
	Personal = 5uL,
	DynamicWEP = 6uL,
	WPAEnterprise = 7uL,
	WPAEnterpriseMixed = 8uL,
	WPA2Enterprise = 9uL,
	Enterprise = 10uL,
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	Wpa3Personal = 11uL,
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	Wpa3Enterprise = 12uL,
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	Wpa3Transition = 13uL,
	Unknown = 2147483647uL
}

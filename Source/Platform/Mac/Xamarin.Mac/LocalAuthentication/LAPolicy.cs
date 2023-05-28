using ObjCRuntime;

namespace LocalAuthentication;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Native]
public enum LAPolicy : long
{
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	DeviceOwnerAuthenticationWithBiometrics = 1L,
	DeviceOwnerAuthentication,
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	DeviceOwnerAuthenticationWithWatch,
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	OwnerAuthenticationWithBiometricsOrWatch
}

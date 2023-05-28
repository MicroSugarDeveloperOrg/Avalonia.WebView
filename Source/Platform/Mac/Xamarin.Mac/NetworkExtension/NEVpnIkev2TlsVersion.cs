using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Native]
public enum NEVpnIkev2TlsVersion : long
{
	Default,
	Tls1_0,
	Tls1_1,
	Tls1_2
}

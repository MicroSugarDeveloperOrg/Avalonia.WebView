using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Native]
public enum NEVpnIkeAuthenticationMethod : long
{
	None,
	Certificate,
	SharedSecret
}

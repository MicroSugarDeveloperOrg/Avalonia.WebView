using ObjCRuntime;

namespace NetworkExtension;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum NEFilterPacketProviderVerdict : long
{
	Allow,
	Drop,
	Delay
}

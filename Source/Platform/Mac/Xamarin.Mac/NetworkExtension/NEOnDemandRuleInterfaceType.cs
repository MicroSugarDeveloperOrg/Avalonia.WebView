using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Native]
public enum NEOnDemandRuleInterfaceType : long
{
	Any,
	Ethernet,
	WiFi,
	Cellular
}

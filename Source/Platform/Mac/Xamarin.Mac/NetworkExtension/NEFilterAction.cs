using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum NEFilterAction : long
{
	Invalid,
	Allow,
	Drop,
	Remediate,
	FilterData
}

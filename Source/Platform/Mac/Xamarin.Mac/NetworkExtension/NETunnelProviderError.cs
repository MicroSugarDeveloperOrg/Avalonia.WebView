using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Native]
public enum NETunnelProviderError : long
{
	None,
	Invalid,
	Canceled,
	Failed
}

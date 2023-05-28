using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Native]
public enum NEOnDemandRuleAction : long
{
	Connect = 1L,
	Disconnect,
	EvaluateConnection,
	Ignore
}

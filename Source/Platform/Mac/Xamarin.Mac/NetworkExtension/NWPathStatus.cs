using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Native]
public enum NWPathStatus : long
{
	Invalid,
	Satisfied,
	Unsatisfied,
	Satisfiable
}

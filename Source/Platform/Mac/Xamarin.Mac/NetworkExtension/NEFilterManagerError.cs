using ObjCRuntime;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Native]
public enum NEFilterManagerError : long
{
	None,
	Invalid,
	Disabled,
	Stale,
	CannotBeRemoved,
	ConfigurationPermissionDenied,
	ConfigurationInternalError
}

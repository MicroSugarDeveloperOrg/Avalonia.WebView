using ObjCRuntime;

namespace ExecutionPolicy;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum EPDeveloperToolStatus : long
{
	NotDetermined,
	Restricted,
	Denied,
	Authorized
}

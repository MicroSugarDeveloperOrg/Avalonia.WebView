using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public enum SecAuthenticationUI
{
	NotSet = -1,
	Allow,
	Fail,
	Skip
}

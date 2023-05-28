using ObjCRuntime;

namespace AuthenticationServices;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum ASAuthorizationAppleIdButtonType : long
{
	SignIn = 0L,
	Continue = 1L,
	[Introduced(PlatformName.TvOS, 13, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 2, PlatformArchitecture.All, null)]
	SignUp = 2L,
	Default = 0L
}

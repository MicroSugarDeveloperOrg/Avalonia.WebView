using ObjCRuntime;

namespace AuthenticationServices;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum ASAuthorizationAppleIdButtonStyle : long
{
	White,
	WhiteOutline,
	Black
}

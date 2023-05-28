using ObjCRuntime;

namespace AuthenticationServices;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Native]
public enum ASWebAuthenticationSessionErrorCode : long
{
	CanceledLogin = 1L,
	PresentationContextNotProvided,
	PresentationContextInvalid
}

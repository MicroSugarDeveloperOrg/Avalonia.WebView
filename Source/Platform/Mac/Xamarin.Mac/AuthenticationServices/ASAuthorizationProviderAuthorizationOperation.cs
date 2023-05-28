using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
public enum ASAuthorizationProviderAuthorizationOperation
{
	None
}

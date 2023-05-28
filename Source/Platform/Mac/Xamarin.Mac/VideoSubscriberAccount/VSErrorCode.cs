using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
[Native]
public enum VSErrorCode : long
{
	AccessNotGranted,
	UnsupportedProvider,
	UserCancelled,
	ServiceTemporarilyUnavailable,
	ProviderRejected,
	InvalidVerificationToken,
	Rejected,
	Unsupported
}

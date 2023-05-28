using Foundation;
using ObjCRuntime;

namespace SafariServices;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
[Native]
public enum SFErrorCode : long
{
	Ok,
	NoExtensionFound,
	NoAttachmentFound,
	LoadingInterrupted
}

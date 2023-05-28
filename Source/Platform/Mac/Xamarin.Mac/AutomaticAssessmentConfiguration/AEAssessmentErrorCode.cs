using Foundation;
using ObjCRuntime;

namespace AutomaticAssessmentConfiguration;

[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
[Native]
public enum AEAssessmentErrorCode : long
{
	Unknown = 1L
}

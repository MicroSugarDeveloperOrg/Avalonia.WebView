using System;
using ObjCRuntime;

namespace SafariServices;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Native]
[Obsolete("Enum not used by any API.", false)]
public enum SFSafariServicesVersion : long
{
	V10_0,
	V10_1,
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	V11_0
}

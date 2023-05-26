using ObjCRuntime;

namespace WebKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum WKContentMode : long
{
	Recommended,
	Mobile,
	Desktop
}

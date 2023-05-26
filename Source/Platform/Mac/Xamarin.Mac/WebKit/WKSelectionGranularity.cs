using ObjCRuntime;

namespace WebKit;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Native]
public enum WKSelectionGranularity : long
{
	Dynamic,
	Character
}

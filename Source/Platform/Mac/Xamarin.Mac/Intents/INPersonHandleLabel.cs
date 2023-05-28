using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public enum INPersonHandleLabel
{
	None,
	Home,
	Work,
	iPhone,
	Mobile,
	Main,
	HomeFax,
	WorkFax,
	Pager,
	Other
}
